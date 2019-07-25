namespace crgolden.Sage100.Customers
{
    public abstract class CustomerCreateRequest<T> : CreateRequest<T>
        where T : class
    {
        protected CustomerCreateRequest(
            T model,
            string key = null) : base(
            model: model,
            moduleName: "A/R",
            programName: "AR_Customer_ui",
            busObjName: "AR_Customer_bus",
            key: key,
            getKeyName: "nGetNextCustomerNo")
        {
        }
    }
}