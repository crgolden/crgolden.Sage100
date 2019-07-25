namespace crgolden.Sage100.Accounts
{
    using System.Collections.Generic;
    using Shared;

    public abstract class AccountListRequestHandler<TRequest, TModel> : ListRequestHandler<TRequest, TModel>
        where TRequest : AccountListRequest<TModel>
        where TModel : Account
    {
        protected AccountListRequestHandler(IEnumerable<IIntegrationService> integrationServices) : base(integrationServices)
        {
        }
    }
}