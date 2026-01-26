using System.Net.Http.Headers;
using Blazored.LocalStorage;
using System.Net;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace PruebaMudBlazor2.Client.Auth
{
    public class BearerTokenHandler : DelegatingHandler
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly NavigationManager _navigationManager;
        private readonly ApiAuthenticationStateProvider _authenticationStateProvider;

        public BearerTokenHandler(ILocalStorageService localStorageService, NavigationManager navigationManager, AuthenticationStateProvider authenticationStateProvider)
        {
            _localStorageService = localStorageService;
            _navigationManager = navigationManager;
            _authenticationStateProvider = (ApiAuthenticationStateProvider)authenticationStateProvider;
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            // 1. Obtener el token de manera ASÍNCRONA
            var token = await _localStorageService.GetItemAsync<string>("authToken");

            if (!string.IsNullOrEmpty(token))
            {
                // 2. Añadir la cabecera de autorización a la solicitud actual
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            // 3. Dejar que la solicitud continúe
            var response = await base.SendAsync(request, cancellationToken);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                await _authenticationStateProvider.MarkUserAsLoggedOut();
                _navigationManager.NavigateTo("/login", forceLoad: false);
            }

            return response;
        }
    }
}
