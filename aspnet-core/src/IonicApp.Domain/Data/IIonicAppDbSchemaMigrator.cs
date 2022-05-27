using System.Threading.Tasks;

namespace IonicApp.Data;

public interface IIonicAppDbSchemaMigrator
{
    Task MigrateAsync();
}
