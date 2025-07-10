using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ABP_Ecommerce.Data;
using Volo.Abp.DependencyInjection;

namespace ABP_Ecommerce.EntityFrameworkCore;

public class EntityFrameworkCoreABP_EcommerceDbSchemaMigrator
    : IABP_EcommerceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreABP_EcommerceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ABP_EcommerceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ABP_EcommerceDbContext>()
            .Database
            .MigrateAsync();
    }
}
