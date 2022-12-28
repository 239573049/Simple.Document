using System.Threading.Tasks;

namespace Blogger.Data;

public interface IBloggerDbSchemaMigrator
{
    Task MigrateAsync();
}
