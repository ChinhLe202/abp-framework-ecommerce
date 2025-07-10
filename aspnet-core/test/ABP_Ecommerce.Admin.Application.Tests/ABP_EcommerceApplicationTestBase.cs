using Volo.Abp.Modularity;

namespace ABP_Ecommerce.Admin;

public abstract class ABP_EcommerceApplicationTestBase<TStartupModule> : ABP_EcommerceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
