namespace crgolden.Sage100.SalesOrderHistoryDetails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class SalesOrderHistoryDetailListRequest<T> : ListRequest<T>
        where T : SalesOrderHistoryDetail
    {
        public override Func<
            IEnumerable<string>,
            string,
            string
        > KeyFilter => (keys, keyColumn) => $"POS(SalesOrderNo$+\"~\"+SequenceNo$=\"{string.Join("Š", keys.Select(x => x.Substring(0, 7) + "~" + x.Substring(7)))}\")";

        protected SalesOrderHistoryDetailListRequest(
            DateTime? compareDate,
            string descColumn = SalesOrderHistoryDetail.DefaultDesc,
            string defaultDescColumn = Record.DefaultDesc,
            string filter = "",
            string begin = "",
            string end = "",
            string keyValue = "") : base(
            compareDate: compareDate,
            moduleName: "S/O",
            programName: "SO_SalesOrderHistoryInquiry_UI",
            busObjName: "SO_SalesOrderHistoryInquiryDetail_bus",
            keyColumn: "SalesOrderNo$+SequenceNo$",
            descColumn: descColumn,
            defaultDescColumn: defaultDescColumn,
            filter: filter,
            begin: begin,
            end: end,
            keyValue: keyValue)
        {
        }
    }
}