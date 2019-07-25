namespace crgolden.Sage100.SalesOrderHistoryDetails
{
    using System.Collections.Generic;
    using Shared;

    public abstract class SalesOrderHistoryDetailListRequestHandler<TRequest, TModel> : ListRequestHandler<TRequest, TModel>
        where TRequest : SalesOrderHistoryDetailListRequest<TModel>
        where TModel : SalesOrderHistoryDetail
    {
        protected SalesOrderHistoryDetailListRequestHandler(IEnumerable<IIntegrationService> integrationServices) : base(integrationServices)
        {
        }
    }
}
