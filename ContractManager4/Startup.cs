using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContractManager4.Startup))]
namespace ContractManager4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
