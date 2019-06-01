namespace crgolden.Sage.Items
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Shared;

    public abstract class ItemFromSageRequestHandler<TRequest, TEntity> : RecordFromSageRequestHandler<TRequest, TEntity>
        where TRequest : ItemFromSageRequest<TEntity>
        where TEntity : Item
    {
        protected ItemFromSageRequestHandler(
            IMapper mapper,
            DbContext context,
            ILogger logger,
            IOptions<SageOptions> sageOptions) : base(mapper, context, logger, sageOptions)
        {
        }
    }
}
