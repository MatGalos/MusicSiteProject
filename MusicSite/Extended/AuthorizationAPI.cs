using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Net.Http.Headers;
using MusicSite.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace MusicSite.Extended
{
    public class AuthorizationAPI : IAsyncAuthorizationFilter
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AuthorizationAPI([FromServices] UserManager<User> userManager, [FromServices] SignInManager<User> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            if (context.Filters.OfType<AuthorizationTokenAttribute>().Any())
            {
                IHeaderDictionary requestHeader = context.HttpContext.Request.Headers;

                if (!requestHeader.Keys.Contains(HeaderNames.Authorization))
                {
                    context.Result = new UnauthorizedResult();
                }
                else
                {
                    String[] token = requestHeader.GetAuthentication();

                    if (await this.Validate(token[0], token[1])) {
                        GenericIdentity identity = new(token[0]);
                        GenericPrincipal principal = new(identity, null);
                        Thread.CurrentPrincipal = principal;
                }
                    else
                    {
                        context.Result = new UnauthorizedResult();
                    }
                }
            }
        }

        private async Task<Boolean> Validate(String userName, String Password)
        {
            User user = await _userManager.FindByNameAsync(userName);

            if (user != null)
            {
                await this._signInManager.SignOutAsync();
                return (await _signInManager.PasswordSignInAsync(user, Password, false, false)).Succeeded;
            }
            return false;
        }

        [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
        public class AuthorizationTokenAttribute : Attribute, IFilterMetadata { };
    } }
