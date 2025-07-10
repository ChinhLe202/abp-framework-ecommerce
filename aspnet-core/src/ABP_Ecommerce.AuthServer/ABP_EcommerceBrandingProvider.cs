using Microsoft.Extensions.Localization;
using ABP_Ecommerce.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ABP_Ecommerce;

[Dependency(ReplaceServices = true)]
public class ABP_EcommerceBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ABP_EcommerceResource> _localizer;

    public ABP_EcommerceBrandingProvider(IStringLocalizer<ABP_EcommerceResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
