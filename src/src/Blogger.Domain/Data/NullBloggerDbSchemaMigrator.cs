using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Blogger.Data;

/* This is used if database provider does't define
 * IBloggerDbSchemaMigrator implementation.
 */
public class NullBloggerDbSchemaMigrator : IBloggerDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
