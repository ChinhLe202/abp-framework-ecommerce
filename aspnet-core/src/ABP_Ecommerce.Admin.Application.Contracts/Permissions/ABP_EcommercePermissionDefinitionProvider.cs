using ABP_Ecommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ABP_Ecommerce.Admin.Permissions;

public class ABP_EcommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ABP_EcommercePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ABP_EcommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ABP_EcommerceResource>(name);
    }
}
