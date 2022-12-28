using Blogger.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Blogger.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BloggerController : AbpControllerBase
{
    protected BloggerController()
    {
        LocalizationResource = typeof(BloggerResource);
    }
}
