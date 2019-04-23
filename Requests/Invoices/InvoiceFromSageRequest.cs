namespace Clarity.Sage.Invoices
{
    using System;

    public abstract class InvoiceFromSageRequest<THeader, TLine> : RecordFromSageRequest<THeader>
        where THeader : Invoice<TLine>
        where TLine : InvoiceLine
    {
        protected InvoiceFromSageRequest(
            DateTime? compareDate,
            string descColumn = Invoice<TLine>.DefaultDesc,
            string defaultDescColumn = Record.DefaultDesc,
            string filter = "",
            string begin = "",
            string end = "") : base(
                compareDate: compareDate,
                moduleName: "S/O",
                programName: "SO_Invoice_ui",
                busObjName: "SO_Invoice_bus",
                keyColumn: "InvoiceNo$",
                descColumn: descColumn,
                defaultDescColumn: defaultDescColumn,
                filter: filter,
                begin: begin,
                end: end)
        {
        }
    }
}
