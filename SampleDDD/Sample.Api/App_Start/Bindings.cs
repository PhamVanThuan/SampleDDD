using Microsoft.Owin.Security.OAuth;
using Ninject.Modules;
using Ninject.Web.Common;
using Sample.Api.Providers;
using Sample.Data;
using Sample.Data.Abstractions;
using Sample.Data.Repositories;
using Sample.Services;
using Sample.Services.Abstractions;

namespace Sample.Api
{
    public class Bindings: NinjectModule
    {
        public override void Load()
        {
            Bind<IOAuthAuthorizationServerOptions>().To<MyOAuthAuthorizationServerOptions>();
            Bind<IOAuthAuthorizationServerProvider>().To<SimpleAuthorizationServerProvider>();
            Bind<ISampleDbContext>()
                .To<SampleDbContext>()
                .InRequestScope();
            Bind<ICountryRepository>()
                .To<CountryRepository>()
                .InRequestScope();
            Bind<ICountryService>()
                .To<CountryService>()
                .InRequestScope();
            Bind<IAuthRepository>()
                .To<AuthRepository>()
                .InRequestScope();
            Bind<IAuthService>()
                .To<AuthService>()
                .InRequestScope();

        }
    }
}