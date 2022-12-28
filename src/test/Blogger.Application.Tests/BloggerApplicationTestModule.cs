using Volo.Abp.Modularity;

namespace Blogger;

[DependsOn(
    typeof(BloggerApplicationModule),
    typeof(BloggerDomainTestModule)
    )]
public class BloggerApplicationTestModule : AbpModule
{

}
