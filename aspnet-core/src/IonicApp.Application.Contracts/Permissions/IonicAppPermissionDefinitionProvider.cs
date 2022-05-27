using IonicApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace IonicApp.Permissions;

public class IonicAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(IonicAppPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(IonicAppPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<IonicAppResource>(name);
    }
}
