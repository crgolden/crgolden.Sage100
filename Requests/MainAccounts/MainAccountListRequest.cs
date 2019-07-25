namespace crgolden.Sage100.MainAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class MainAccountListRequest<T> : ListRequest<T>
        where T : MainAccount
    {
        public override Func<
            IEnumerable<string>,
            string,
            string
        > KeyFilter => (keys, keyColumn) => $"POS(SegmentNo$+\"~\"+MainAccountCode$=\"{string.Join("Š", keys.Select(x => x.Substring(0, 2) + "~" + x.Substring(2)))}\")";

        protected MainAccountListRequest(
            DateTime? compareDate,
            string descColumn = MainAccount.DefaultDesc,
            string defaultDescColumn = Record.DefaultDesc,
            string filter = "",
            string begin = "",
            string end = "") : base(
            compareDate: compareDate,
            moduleName: "G/L",
            programName: "GL_MainAccount_ui",
            busObjName: "GL_MainAccount_bus",
            keyColumn: "SegmentNo$+MainAccountCode$",
            descColumn: descColumn,
            defaultDescColumn: defaultDescColumn,
            filter: filter,
            begin: begin,
            end: end)
        {
        }
    }
}