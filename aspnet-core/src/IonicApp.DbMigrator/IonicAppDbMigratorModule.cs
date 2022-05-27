using IonicApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace IonicApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(IonicAppEntityFrameworkCoreModule),
    typeof(IonicAppApplicationContractsModule)
    )]
public class IonicAppDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
