using ABP_Ecommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABP_Ecommerce.Admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ABP_EcommerceController : AbpControllerBase
{
    protected ABP_EcommerceController()
    {
        LocalizationResource = typeof(ABP_EcommerceResource);
    }
}
