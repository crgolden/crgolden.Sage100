namespace crgolden.Sage100.SalesOrderHistoryHeaders
{
    using System.Collections.Generic;
    using Shared;

    public abstract class SalesOrderHistoryHeaderListRequestHandler<TRequest, THeader, TLine> : ListRequestHandler<TRequest, THeader>
        where TRequest : SalesOrderHistoryHeadersListRequest<THeader, TLine>
        where THeader : SalesOrderHistoryHeader<TLine>
        where TLine : SalesOrderHistoryDetail
    {
        protected SalesOrderHistoryHeaderListRequestHandler(IEnumerable<IIntegrationService> integrationServices) : base(integrationServices)
        {
        }
    }
}
