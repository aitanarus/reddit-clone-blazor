using System.Security.Claims;
using Contracts.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;


namespace Application.Authentication;

public class SimpleAuthenticationProvider: AuthenticationStateProvider
{
    private readonly IAuthService authService;

    public SimpleAuthenticationProvider(IAuthService authService)
    {
        this.authService = authService;
        authService.OnAuthStateChanged += AuthStateChanged;
    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        ClaimsPrincipal principal = await authService.GetAuthAsync();
        return await Task.FromResult(new AuthenticationState(principal));
    }

    private void AuthStateChanged(ClaimsPrincipal principal)
    {
        NotifyAuthenticationStateChanged(
            Task.FromResult(
                new AuthenticationState(principal)
            )
        );
    }
}
