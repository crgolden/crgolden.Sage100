namespace crgolden.Sage100.MainAccounts
{
    using System.Collections.Generic;
    using Shared;

    public abstract class MainAccountListRequestHandler<TRequest, TModel> : ListRequestHandler<TRequest, TModel>
        where TRequest : MainAccountListRequest<TModel>
        where TModel : MainAccount
    {
        protected MainAccountListRequestHandler(IEnumerable<IIntegrationService> integrationServices) : base(integrationServices)
        {
        }
    }
}