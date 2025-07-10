using Volo.Abp.Settings;

namespace ABP_Ecommerce.Settings;

public class ABP_EcommerceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ABP_EcommerceSettings.MySetting1));
    }
}
