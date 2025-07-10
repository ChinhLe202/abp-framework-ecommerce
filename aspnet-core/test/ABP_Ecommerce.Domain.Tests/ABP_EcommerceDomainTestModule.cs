using Volo.Abp.Modularity;

namespace ABP_Ecommerce;

[DependsOn(
    typeof(ABP_EcommerceDomainModule),
    typeof(ABP_EcommerceTestBaseModule)
)]
public class ABP_EcommerceDomainTestModule : AbpModule
{

}
