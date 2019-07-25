namespace crgolden.Sage100.Accounts
{
    using System;

    public abstract class AccountListRequest<T> : ListRequest<T>
        where T : Account
    {
        protected AccountListRequest(
            DateTime? compareDate,
            string descColumn = Account.DefaultDesc,
            string defaultDescColumn = Record.DefaultDesc,
            string filter = "",
            string begin = "",
            string end = "") : base(
            compareDate: compareDate,
            moduleName: "G/L",
            programName: "GL_Account_ui",
            busObjName: "GL_Account_bus",
            keyColumn: "AccountKey$",
            descColumn: descColumn,
            defaultDescColumn: defaultDescColumn,
            filter: filter,
            begin: begin,
            end: end)
        {
        }
    }
}