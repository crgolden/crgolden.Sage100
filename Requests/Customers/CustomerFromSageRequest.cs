namespace Clarity.Sage.Customers
{
    using System;

    public abstract class CustomerFromSageRequest<T> : RecordFromSageRequest<T>
        where T : Customer
    {
        protected CustomerFromSageRequest(
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
