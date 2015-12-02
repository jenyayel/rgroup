using Rg.ServiceCore.DbModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Security.Claims;
using Microsoft.Azure.AppService.ApiApps.Service;
using System.Data.Entity;
using System.Collections.Generic;
using System.Configuration;
using System;

namespace Rg.Api.Controllers
{
    public class ApiControllerBase : ApiController
    {
        private ApplicationDbContext _dbContext;
        private Task<Dictionary<string, string>> _apiTokenDictionaryTask;
        private Task<UserInfo> _userInfoTask;
        private static HashSet<string> _masterUserEmails;

        protected ApplicationDbContext DbContext
        {
            get
            {
                return LazyInitializer.EnsureInitialized(
                    ref _dbContext,
                    ApplicationDbContext.Create);
            }
        }

        protected Task<Dictionary<string, string>> GetApiTokenClaimsAsync()
        {
            return LazyInitializer.EnsureInitialized(
                ref _apiTokenDictionaryTask,
                async () =>
                {
                    var runtime = Runtime.FromAppSettings(Request);
                    var user = runtime.CurrentUser;
                    TokenResult token = await user.GetRawTokenAsync("microsoftaccount");
                    return token.Claims.ToDictionary(c => c.Key, c => c.Value);
                });
        }

        protected static HashSet<string> MasterEmails
        {
            get
            {
                return LazyInitializer.EnsureInitialized(
                    ref _masterUserEmails,
                    () => new HashSet<string>(ConfigurationManager.AppSettings["MasterUsers"].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)));
            }
        }

        protected Task<UserInfo> GetUserInfoAsync(string userId = null)
        {
            if (userId != null)
            {
                return DbContext.UserInfos.SingleOrDefaultAsync(u => u.UserInfoId == userId);
            }

            return LazyInitializer.EnsureInitialized(
                ref _userInfoTask,
                async () =>
                {
                    string email = (await GetApiTokenClaimsAsync())[ClaimTypes.Email];

                    UserInfo info = await DbContext.UserInfos.SingleOrDefaultAsync(u => u.Email == email);
                    return info;
                });
        }
    }
}
