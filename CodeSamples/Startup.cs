using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeSamples.Startup))]
namespace CodeSamples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
