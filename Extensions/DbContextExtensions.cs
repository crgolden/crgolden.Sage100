namespace crgolden.Sage
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

    public static class DbContextExtensions
    {
        public static async Task<int> ProcessAsync<T>(
            this DbContext context,
            Dictionary<EntityState, T[]> keyValuePairs,
            CancellationToken token)
            where T : class
        {
            foreach (var keyValuePair in keyValuePairs)
            {
                switch (keyValuePair.Key)
                {
                    case EntityState.Added:
                        context.Set<T>().AddRange(keyValuePair.Value);
                        break;
                    case EntityState.Deleted:
                        context.Set<T>().RemoveRange(keyValuePair.Value);
                        break;
                    case EntityState.Modified:
                        context.Set<T>().UpdateRange(keyValuePair.Value);
                        break;
                }
            }

            return await context.SaveChangesAsync(token).ConfigureAwait(false);
        }
    }
}
