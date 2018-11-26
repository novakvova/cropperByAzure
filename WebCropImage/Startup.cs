using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebCropImage.Startup))]
namespace WebCropImage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
