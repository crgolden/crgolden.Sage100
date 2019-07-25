namespace crgolden.Sage100.Customers
{
    using System.Collections.Generic;
    using Shared;

    public abstract class CustomerCreateRequestHandler<TRequest, TModel> : CreateRequestHandler<TRequest, TModel>
        where TRequest : CustomerCreateRequest<TModel>
        where TModel : Customer
    {
        protected CustomerCreateRequestHandler(IEnumerable<IIntegrationService> integrationServices) : base(integrationServices)
        {
        }
    }
}
