using System.Threading.Tasks;

namespace ABP_Ecommerce.Data;

public interface IABP_EcommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
