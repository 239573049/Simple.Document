using Blogger.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Blogger;

[DependsOn(
    typeof(BloggerEntityFrameworkCoreTestModule)
    )]
public class BloggerDomainTestModule : AbpModule
{

}
