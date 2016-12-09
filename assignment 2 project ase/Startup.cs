using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(assignment_2_project_ase.Startup))]
namespace assignment_2_project_ase
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
