using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoListsApp.Startup))]
namespace ToDoListsApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
