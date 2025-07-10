using System;
using System.Collections.Generic;
using System.Text;
using ABP_Ecommerce.Localization;
using Volo.Abp.Application.Services;

namespace ABP_Ecommerce;

/* Inherit your application services from this class.
 */
public abstract class ABP_EcommerceAppService : ApplicationService
{
    protected ABP_EcommerceAppService()
    {
        LocalizationResource = typeof(ABP_EcommerceResource);
    }
}
