using System;
using System.Collections.Generic;
using System.Text;
using Blogger.Localization;
using Volo.Abp.Application.Services;

namespace Blogger;

/* Inherit your application services from this class.
 */
public abstract class BloggerAppService : ApplicationService
{
    protected BloggerAppService()
    {
        LocalizationResource = typeof(BloggerResource);
    }
}
