namespace crgolden.Sage.MainAccounts
{
    using System;

    public abstract class MainAccountFromSageRequest<T> : RecordFromSageRequest<T>
        where T : MainAccount
    {
        protected MainAccountFromSageRequest(
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
