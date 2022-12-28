using Blogger.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Blogger.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BloggerEntityFrameworkCoreModule),
    typeof(BloggerApplicationContractsModule)
    )]
public class BloggerDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
