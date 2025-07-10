using Volo.Abp.Modularity;

namespace ABP_Ecommerce;

/* Inherit from this class for your domain layer tests. */
public abstract class ABP_EcommerceDomainTestBase<TStartupModule> : ABP_EcommerceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
