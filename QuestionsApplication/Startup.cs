using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuestionsApplication.Startup))]
namespace QuestionsApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
