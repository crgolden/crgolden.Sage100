namespace Clarity.Sage.Orders
{
    using System;

    public abstract class OrderFromSageRequest<THeader, TLine> : RecordFromSageRequest<THeader>
        where THeader : Order<TLine>
        where TLine : OrderLine
    {
        protected OrderFromSageRequest(
            DateTime? compareDate,
            string descColumn = Order<TLine>.DefaultDesc,
            string defaultDescColumn = Record.DefaultDesc,
            string filter = "",
            string begin = "",
            string end = "") : base(
                compareDate: compareDate,
                moduleName: "S/O",
                programName: "SO_SalesOrder_ui",
                busObjName: "SO_SalesOrder_bus",
                keyColumn: "SalesOrderNo$",
                descColumn: descColumn,
                defaultDescColumn: defaultDescColumn,
                filter: filter,
                begin: begin,
                end: end)
        {
        }
    }
}
