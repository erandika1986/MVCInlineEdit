using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCInlineEdit.Startup))]
namespace MVCInlineEdit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
