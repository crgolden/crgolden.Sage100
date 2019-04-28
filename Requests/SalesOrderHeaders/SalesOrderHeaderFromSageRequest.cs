namespace Clarity.Sage.SalesOrderHeaders
{
    using System;

    public abstract class SalesOrderHeaderFromSageRequest<THeader, TLine> : RecordFromSageRequest<THeader>
        where THeader : SalesOrderHeader<TLine>
        where TLine : SalesOrderDetail
    {
        protected SalesOrderHeaderFromSageRequest(
            DateTime? compareDate,
            string descColumn = SalesOrderHeader<TLine>.DefaultDesc,
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
