namespace crgolden.Sage100.SalesOrderHeaders
{
    using System.Collections.Generic;
    using Shared;

    public abstract class SalesOrderHeaderCreateRequestHandler<TRequest, THeader, TLine> : CreateRequestHandler<TRequest, THeader>
        where TRequest : SalesOrderHeaderCreateRequest<THeader, TLine>
        where THeader : SalesOrderHeader<TLine>
        where TLine : SalesOrderDetail
    {
        protected SalesOrderHeaderCreateRequestHandler(IEnumerable<IIntegrationService> integrationServices) : base(integrationServices)
        {
        }
    }
}