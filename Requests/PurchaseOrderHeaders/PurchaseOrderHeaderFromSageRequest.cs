namespace Clarity.Sage.PurchaseOrderHeaders
{
    using System;

    public abstract class PurchaseOrderHeaderFromSageRequest<THeader, TLine> : RecordFromSageRequest<THeader>
        where THeader : PurchaseOrderHeader<TLine>
        where TLine : PurchaseOrderDetail
    {
        protected PurchaseOrderHeaderFromSageRequest(
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
