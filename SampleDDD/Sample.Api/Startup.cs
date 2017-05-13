using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Ninject;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using Sample.Api.Providers;
using Sample.Services.Abstractions;

[assembly: OwinStartup(typeof(Sample.Api.Startup))]
namespace Sample.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            HttpConfiguration config = new HttpConfiguration();


            app.UseNinjectMiddleware(() => kernel)
                .UseOAuthAuthorizationServer(kernel.Get<MyOAuthAuthorizationServerOptions>().GetOptions())
                .UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions())
                .UseNinjectWebApi(config)
                .UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }

//        private static StandardKernel CreateKernel()
//        {
//            var kernel = new StandardKernel();
//            kernel.Load(Assembly.GetExecutingAssembly());
//            return kernel;
//        }
    }
}