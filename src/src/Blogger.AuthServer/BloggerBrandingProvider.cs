using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Blogger;

[Dependency(ReplaceServices = true)]
public class BloggerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Blogger";
}
