namespace Clarity.Sage
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

    public static class RecordExtensions
    {
        public static async Task<T[]> ProcessAsync<T>(
            this T[] entities,
            DbContext context,
            CancellationToken token)
            where T : Record
        {
            var entityType = typeof(T);
            if (entityType.BaseType.GenericTypeArguments.Length == 1)
            {
                var genericType = entityType.BaseType.GenericTypeArguments[0];
                if (genericType.IsSubclassOf(typeof(OrderLine)))
                {
                    return await ((Task<T[]>)typeof(RecordExtensions)
                        .GetMethod(
                            name: nameof(ProcessOrders),
                            bindingAttr: BindingFlags.NonPublic | BindingFlags.Static)
                        .MakeGenericMethod(new Type[] { entityType, genericType })
                        .Invoke(null, new object[] { entities, context, token }))
                        .ConfigureAwait(false);
                }

                if (genericType.IsSubclassOf(typeof(InvoiceLine)))
                {
                    var method = typeof(RecordExtensions).GetMethod(
                        name: nameof(ProcessInvoices),
                        bindingAttr: BindingFlags.NonPublic | BindingFlags.Static);
                    var generic = method.MakeGenericMethod(new Type[] { entityType, genericType });
                    return (T[])generic.Invoke(null, new object[] { entities });
                }
            }

            return entities;
        }

        private static async Task<THeader[]> ProcessOrders<THeader, TLine>(
            THeader[] headers,
            DbContext context,
            CancellationToken token)
            where THeader : Order<TLine>
            where TLine : OrderLine
        {
            var orders = headers.Where(x => string.IsNullOrEmpty(x.CurrentInvoiceNo)).ToArray();
            var invoices = headers.Where(x => !string.IsNullOrEmpty(x.CurrentInvoiceNo)).ToArray();
            for (var i = 0; i < invoices.Length; i++)
            {
                var invoice = invoices[i];
                Debug.WriteLine($"Index: {i}");
                Debug.WriteLine($"SalesOrderNo: {invoice.SalesOrderNo}");
                Debug.WriteLine($"CurrentInvoiceNo: {invoice.CurrentInvoiceNo}");
                var orderNumber = invoice.Lines?.FirstOrDefault()?.SalesOrderNo;
                if (orderNumber == null) continue;
                var order = orders.SingleOrDefault(x => x.SalesOrderNo == orderNumber) ??
                    await context
                        .Set<THeader>()
                        .SingleOrDefaultAsync(x => x.SalesOrderNo == orderNumber, token)
                        .ConfigureAwait(false);
                if (order == null) throw new ArgumentException($"Order number {orderNumber} not found.");
                order.CurrentInvoiceNo = invoice.CurrentInvoiceNo;
            }

            return orders;
        }

        private static THeader[] ProcessInvoices<THeader, TLine>(THeader[] headers)
            where THeader : Invoice<TLine>
            where TLine : InvoiceLine
        {
            foreach (var invoice in headers)
            {
                invoice.Lines = invoice.Lines.Where(x => x.InvoiceNo == invoice.InvoiceNo).ToArray();
            }

            return headers;
        }
    }
}
