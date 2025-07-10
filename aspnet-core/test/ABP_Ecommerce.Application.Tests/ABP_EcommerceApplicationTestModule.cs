using Volo.Abp.Modularity;

namespace ABP_Ecommerce;

[DependsOn(
    typeof(ABP_EcommerceApplicationModule),
    typeof(ABP_EcommerceDomainTestModule)
)]
public class ABP_EcommerceApplicationTestModule : AbpModule
{

}
