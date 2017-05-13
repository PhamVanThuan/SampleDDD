using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Security.OAuth;

namespace Sample.Api.Providers
{
    public interface IOAuthAuthorizationServerOptions
    {
        OAuthAuthorizationServerOptions GetOptions();
    }
}
