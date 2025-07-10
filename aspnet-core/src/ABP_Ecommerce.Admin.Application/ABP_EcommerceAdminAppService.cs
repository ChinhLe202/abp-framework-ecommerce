using System;
using System.Collections.Generic;
using System.Text;
using ABP_Ecommerce.Localization;
using Volo.Abp.Application.Services;

namespace ABP_Ecommerce.Admin;

/* Inherit your application services from this class.
 */
public abstract class ABP_EcommerceAdminAppService : ApplicationService
{
    protected ABP_EcommerceAdminAppService()
    {
        LocalizationResource = typeof(ABP_EcommerceResource);
    }
}
