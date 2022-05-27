using Volo.Abp.Modularity;

namespace IonicApp;

[DependsOn(
    typeof(IonicAppApplicationModule),
    typeof(IonicAppDomainTestModule)
    )]
public class IonicAppApplicationTestModule : AbpModule
{

}
