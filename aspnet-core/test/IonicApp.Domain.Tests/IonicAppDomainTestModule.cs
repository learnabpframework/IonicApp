using IonicApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace IonicApp;

[DependsOn(
    typeof(IonicAppEntityFrameworkCoreTestModule)
    )]
public class IonicAppDomainTestModule : AbpModule
{

}
