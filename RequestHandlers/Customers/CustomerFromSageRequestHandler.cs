namespace crgolden.Sage.Customers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Shared;

    public abstract class CustomerFromSageRequestHandler<TRequest, TEntity> : RecordFromSageRequestHandler<TRequest, TEntity>
        where TRequest : CustomerFromSageRequest<TEntity>
        where TEntity : Customer
    {
        protected override Func<
            IEnumerable<string>,
            string,
            string
            > KeyFilter => (keys, keyColumn) => $"POS(ARDivisionNo$+\"~\"+CustomerNo$=\"{string.Join("Š", keys.Select(x => x.Substring(0, 2) + "~" + x.Substring(2)))}\")";

        protected CustomerFromSageRequestHandler(
            IMapper mapper,
            DbContext context,
            ILogger logger,
            IOptions<SageOptions> sageOptions) : base(mapper, context, logger, sageOptions)
        {
        }
    }
}
