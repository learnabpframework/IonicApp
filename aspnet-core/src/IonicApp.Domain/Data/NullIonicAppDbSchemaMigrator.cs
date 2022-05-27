using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace IonicApp.Data;

/* This is used if database provider does't define
 * IIonicAppDbSchemaMigrator implementation.
 */
public class NullIonicAppDbSchemaMigrator : IIonicAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
