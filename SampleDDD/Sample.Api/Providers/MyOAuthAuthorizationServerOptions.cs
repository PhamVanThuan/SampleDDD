using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;

namespace Sample.Api.Providers
{
    public class MyOAuthAuthorizationServerOptions: IOAuthAuthorizationServerOptions
    {
        private readonly SimpleAuthorizationServerProvider _provider;

        public MyOAuthAuthorizationServerOptions(SimpleAuthorizationServerProvider provider)
        {
            _provider = provider;
        }

        public OAuthAuthorizationServerOptions GetOptions()
        {
            return new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,

                TokenEndpointPath = new PathString("/token"),

                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),

                Provider = _provider
            };
        }
    }
}