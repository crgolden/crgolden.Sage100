namespace Clarity.Sage.InvoiceHeaders
{
    using System;

    public abstract class InvoiceHeaderFromSageRequest<THeader, TLine> : RecordFromSageRequest<THeader>
        where THeader : InvoiceHeader<TLine>
        where TLine : InvoiceDetail
    {
        protected InvoiceHeaderFromSageRequest(
            DateTime? compareDate,
            string descColumn = InvoiceHeader<TLine>.DefaultDesc,
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
