namespace crgolden.Sage100.Customers
{
    using System.Collections.Generic;
    using Shared;

    public abstract class CustomerListRequestHandler<TRequest, TModel> : ListRequestHandler<TRequest, TModel>
        where TRequest : CustomerListRequest<TModel>
        where TModel : Customer
    {
        protected CustomerListRequestHandler(IEnumerable<IIntegrationService> integrationServices) : base(integrationServices)
        {
        }
    }
}