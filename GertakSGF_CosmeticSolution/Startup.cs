using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GertakSGF_CosmeticSolution.Startup))]
namespace GertakSGF_CosmeticSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
