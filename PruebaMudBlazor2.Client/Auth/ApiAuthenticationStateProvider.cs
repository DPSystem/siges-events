using Microsoft.AspNetCore.Components.Authorization;
using Blazored.LocalStorage;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PruebaMudBlazor2.Client.Auth
{
    public class ApiAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorage;
        private readonly string _tokenKey = "authToken";
        private ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());

        public ApiAuthenticationStateProvider(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var token = await _localStorage.GetItemAsync<string>(_tokenKey);

            if (string.IsNullOrWhiteSpace(token))
            {
                return new AuthenticationState(_anonymous);
            }

            var claims = JwtParser.ParseClaimsFromJwt(token);
            var identity = new ClaimsIdentity(claims, "jwt", ClaimTypes.Name, ClaimTypes.Role);
            var user = new ClaimsPrincipal(identity);

            return new AuthenticationState(user);
        }

        public async Task MarkUserAsAuthenticated(string token)
        {
            await _localStorage.SetItemAsync(_tokenKey, token);
            var claims = JwtParser.ParseClaimsFromJwt(token);
            var identity = new ClaimsIdentity(claims, "jwt", ClaimTypes.Name, ClaimTypes.Role);
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public async Task MarkUserAsLoggedOut()
        {
            await _localStorage.RemoveItemAsync(_tokenKey);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(_anonymous)));
        }
    }
}
