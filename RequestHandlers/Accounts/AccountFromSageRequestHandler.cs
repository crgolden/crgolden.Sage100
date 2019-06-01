namespace crgolden.Sage.Accounts
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Shared;

    public abstract class AccountFromSageRequestHandler<TRequest, TEntity> : RecordFromSageRequestHandler<TRequest, TEntity>
        where TRequest : AccountFromSageRequest<TEntity>
        where TEntity : Account
    {
        protected AccountFromSageRequestHandler(
            IMapper mapper,
            DbContext context,
            ILogger logger,
            IOptions<SageOptions> sageOptions) : base(mapper, context, logger, sageOptions)
        {
        }
    }
}
