namespace crgolden.Sage100.PurchaseOrderHeaders
{
    using System;

    public abstract class PurchaseOrderHeaderListRequest<THeader, TLine> : ListRequest<THeader>
        where THeader : PurchaseOrderHeader<TLine>
        where TLine : PurchaseOrderDetail
    {
        protected PurchaseOrderHeaderListRequest(
            DateTime? compareDate,
            string descColumn = PurchaseOrderHeader<TLine>.DefaultDesc,
            string defaultDescColumn = Record.DefaultDesc,
            string filter = "",
            string begin = "",
            string end = "") : base(
            compareDate: compareDate,
            moduleName: "P/O",
            programName: "PO_PurchaseOrder_ui",
            busObjName: "PO_PurchaseOrder_bus",
            keyColumn: "PurchaseOrderNo$",
            descColumn: descColumn,
            defaultDescColumn: defaultDescColumn,
            filter: filter,
            begin: begin,
            end: end)
        {
        }
    }
}