using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MFTWebForm.Startup))]
namespace MFTWebForm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
