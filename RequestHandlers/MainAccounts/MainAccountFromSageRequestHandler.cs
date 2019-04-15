namespace Clarity.Sage.MainAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Shared;

    public abstract class MainAccountFromSageRequestHandler<TRequest, TEntity> : RecordFromSageRequestHandler<TRequest, TEntity>
        where TRequest : MainAccountFromSageRequest<TEntity>
        where TEntity : MainAccount
    {
        protected override Func<
            IEnumerable<string>,
            string,
            string
            > KeyFilter => (keys, keyColumn) => $"POS(SegmentNo$+\"~\"+MainAccountCode$=\"{string.Join("Š", keys.Select(x => x.Substring(0, 2) + "~" + x.Substring(2)))}\")";

        protected MainAccountFromSageRequestHandler(
            IMapper mapper,
            DbContext context,
            ILogger logger,
            IOptions<SageOptions> sageOptions) : base(mapper, context, logger, sageOptions)
        {
        }
    }
}
