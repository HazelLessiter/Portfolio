using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecipeWebsite.Startup))]
namespace RecipeWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
