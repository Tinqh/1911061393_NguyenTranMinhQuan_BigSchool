using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911061393_NguyenTranMinhQuan_Bigschool.Startup))]
namespace _1911061393_NguyenTranMinhQuan_Bigschool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
