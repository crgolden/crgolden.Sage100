namespace crgolden.Sage100
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using Shared;

    public abstract class CreateRequestHandler<TRequest, TModel> : IRequestHandler<TRequest, TModel>
        where TRequest : CreateRequest<TModel>
        where TModel : class
    {
        protected readonly IIntegrationService IntegrationService;

        protected CreateRequestHandler(IEnumerable<IIntegrationService> integrationServices)
        {
            IntegrationService = integrationServices.Single(x => x is Sage100IntegrationService);
        }

        public virtual async Task<TModel> Handle(TRequest request, CancellationToken token)
        {
            return await IntegrationService.Create<TModel, TRequest>(request, token).ConfigureAwait(false);
        }
    }
}