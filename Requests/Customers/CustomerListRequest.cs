namespace crgolden.Sage100.Customers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class CustomerListRequest<T> : ListRequest<T>
        where T : Customer
    {
        public override Func<
            IEnumerable<string>,
            string,
            string
        > KeyFilter => (keys, keyColumn) => $"POS(ARDivisionNo$+\"~\"+CustomerNo$=\"{string.Join("Š", keys.Select(x => x.Substring(0, 2) + "~" + x.Substring(2)))}\")";

        protected CustomerListRequest(
            DateTime? compareDate,
            string descColumn = Customer.DefaultDesc,
            string defaultDescColumn = Record.DefaultDesc,
            string filter = "",
            string begin = "",
            string end = "") : base(
            compareDate: compareDate,
            moduleName: "A/R",
            programName: "AR_Customer_ui",
            busObjName: "AR_Customer_bus",
            keyColumn: "ARDivisionNo$+CustomerNo$",
            descColumn: descColumn,
            defaultDescColumn: defaultDescColumn,
            filter: filter,
            begin: begin,
            end: end)
        {
        }
    }
}