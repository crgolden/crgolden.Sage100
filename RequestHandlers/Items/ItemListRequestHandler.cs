namespace crgolden.Sage100.Items
{
    using System.Collections.Generic;
    using Shared;

    public abstract class ItemListRequestHandler<TRequest, TModel> : ListRequestHandler<TRequest, TModel>
        where TRequest : ItemListRequest<TModel>
        where TModel : Item
    {
        protected ItemListRequestHandler(IEnumerable<IIntegrationService> integrationServices) : base(integrationServices)
        {
        }
    }
}
