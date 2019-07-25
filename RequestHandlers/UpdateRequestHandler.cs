namespace crgolden.Sage100
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using Shared;

    public abstract class UpdateRequestHandler<TRequest, TModel> : IRequestHandler<TRequest>
        where TRequest : UpdateRequest<TModel>
        where TModel : class
    {
        protected readonly IIntegrationService IntegrationService;

        protected UpdateRequestHandler(IEnumerable<IIntegrationService> integrationServices)
        {
            IntegrationService = integrationServices.Single(x => x is Sage100IntegrationService);
        }

        public virtual async Task<Unit> Handle(TRequest request, CancellationToken token)
        {
            await IntegrationService.Update<TModel, TRequest>(request, token).ConfigureAwait(false);
            return Unit.Value;
        }
    }
}