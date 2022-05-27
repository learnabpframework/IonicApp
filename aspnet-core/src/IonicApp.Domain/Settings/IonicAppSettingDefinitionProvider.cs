using Volo.Abp.Settings;

namespace IonicApp.Settings;

public class IonicAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(IonicAppSettings.MySetting1));
    }
}
