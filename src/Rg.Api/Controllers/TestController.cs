using Microsoft.Azure.AppService.ApiApps.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace Rg.Api.Controllers
{
    /// <summary>
    /// Test endpoint to explore API App behavior.
    /// </summary>
    public class TestController : ApiController
    {
        /// <summary>
        /// Returns the claims associated with the Microsoft Account token,
        /// or reports errors if any occur.
        /// </summary>
        /// <returns></returns>
        public async Task<IList<string>> Get()
        {
            try
            {
                var runtime = Runtime.FromAppSettings(Request);
                if (runtime == null)
                {
                    return new[] { "No runtime" };
                }
                var user = runtime.CurrentUser;
                if (user == null)
                {
                    return new[] { "No user" };
                }
                TokenResult token = await user.GetRawTokenAsync("microsoftaccount");
                if (token == null)
                {
                    return new[] { "No token" };
                }
                return token.Claims.Select(c => $"{c.Key}: {c.Value}").ToList();
            }
            catch (Exception x)
            {
                return new[] { "Exception: " + x };
            }
        }
    }
}
