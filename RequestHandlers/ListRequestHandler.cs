namespace crgolden.Sage100
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using Shared;

    public abstract class ListRequestHandler<TRequest, TModel> : IRequestHandler<TRequest, TModel[]>
        where TRequest : ListRequest<TModel>
        where TModel : class
    {
        protected readonly IIntegrationService IntegrationService;

        protected ListRequestHandler(IEnumerable<IIntegrationService> integrationServices)
        {
            IntegrationService = integrationServices.Single(x => x is Sage100IntegrationService);
        }

        public virtual async Task<TModel[]> Handle(TRequest request, CancellationToken token)
        {
            return await IntegrationService.List<TModel, TRequest>(request, token).ConfigureAwait(false);
        }
    }
}
