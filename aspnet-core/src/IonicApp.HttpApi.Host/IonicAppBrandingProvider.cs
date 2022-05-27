using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace IonicApp;

[Dependency(ReplaceServices = true)]
public class IonicAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "IonicApp";
}
