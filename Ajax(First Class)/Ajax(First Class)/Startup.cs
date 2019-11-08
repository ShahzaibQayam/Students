using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ajax_First_Class_.Startup))]
namespace Ajax_First_Class_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
