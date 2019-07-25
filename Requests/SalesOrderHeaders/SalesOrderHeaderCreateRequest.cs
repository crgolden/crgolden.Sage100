namespace crgolden.Sage100.SalesOrderHeaders
{
    public abstract class SalesOrderHeaderCreateRequest<THeader, TLine> : CreateRequest<THeader>
        where THeader : SalesOrderHeader<TLine>
        where TLine : SalesOrderDetail
    {
        protected SalesOrderHeaderCreateRequest(THeader model) : base(
            model: model,
            moduleName: "S/O",
            programName: "SO_SalesOrder_ui",
            busObjName: "SO_SalesOrder_bus",
            key: null,
            getKeyName: "nGetNextSalesOrderNo")
        {
        }
    }
}