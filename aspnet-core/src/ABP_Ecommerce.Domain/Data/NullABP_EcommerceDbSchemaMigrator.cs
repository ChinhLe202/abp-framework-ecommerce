using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABP_Ecommerce.Data;

/* This is used if database provider does't define
 * IABP_EcommerceDbSchemaMigrator implementation.
 */
public class NullABP_EcommerceDbSchemaMigrator : IABP_EcommerceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
