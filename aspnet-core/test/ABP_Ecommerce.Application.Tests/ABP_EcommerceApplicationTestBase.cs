using Volo.Abp.Modularity;

namespace ABP_Ecommerce;

public abstract class ABP_EcommerceApplicationTestBase<TStartupModule> : ABP_EcommerceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
