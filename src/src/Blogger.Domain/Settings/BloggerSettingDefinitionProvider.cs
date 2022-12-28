using Volo.Abp.Settings;

namespace Blogger.Settings;

public class BloggerSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BloggerSettings.MySetting1));
    }
}
