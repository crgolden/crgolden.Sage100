namespace crgolden.Sage100.InvoiceHeaders
{
    using System;

    public abstract class InvoiceHeaderListRequest<THeader, TLine> : ListRequest<THeader>
        where THeader : InvoiceHeader<TLine>
        where TLine : InvoiceDetail
    {
        protected InvoiceHeaderListRequest(
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