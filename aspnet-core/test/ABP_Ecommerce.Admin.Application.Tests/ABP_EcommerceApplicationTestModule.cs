using Volo.Abp.Modularity;

namespace ABP_Ecommerce.Admin;

[DependsOn(
    typeof(ABP_EcommerceAdminApplicationModule),
    typeof(ABP_EcommerceDomainTestModule)
)]
public class ABP_EcommerceApplicationTestModule : AbpModule
{

}
