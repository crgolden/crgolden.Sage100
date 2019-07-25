namespace crgolden.Sage100.SalesOrderHistoryHeaders
{
    using System;

    public abstract class SalesOrderHistoryHeadersListRequest<THeader, TLine> : ListRequest<THeader>
        where THeader : SalesOrderHistoryHeader<TLine>
        where TLine : SalesOrderHistoryDetail
    {
        protected SalesOrderHistoryHeadersListRequest(
            DateTime? compareDate,
            string descColumn = SalesOrderHistoryHeader<TLine>.DefaultDesc,
            string defaultDescColumn = Record.DefaultDesc,
            string filter = "",
            string begin = "",
            string end = "") : base(
            compareDate: compareDate,
            moduleName: "S/O",
            programName: "SO_SalesOrderHistoryInquiry_ui",
            busObjName: "SO_SalesOrderHistoryInquiry_bus",
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