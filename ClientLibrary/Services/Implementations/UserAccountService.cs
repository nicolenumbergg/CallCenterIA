using System.Net.Http.Json;
using BaseLibrary.DTOs;
using BaseLibrary.Responses;
using ClientLibrary.Helpers;
using ClientLibrary.Services.Contracts;

namespace ClientLibrary.Services.Implementations;

public class UserAccountService(GetHttpClient getHttpClient) : IUserAccountService
{
    public const string AuthUrl = "api/authentication";
    
    public async Task<GeneralResponse> CreateAsync(Register? user)
    {
        var httpClient = getHttpClient.GetPublicHttpClient();
        var result = await httpClient.PostAsJsonAsync($"{AuthUrl}/register", user);
        if (!result.IsSuccessStatusCode) return new GeneralResponse(false, "Ocurrio un error al crear el usuario");
        return (await result.Content.ReadFromJsonAsync<GeneralResponse>())!;
    }

    public async Task<LoginResponse> SignInAsync(Login user)
    {
        var httpClient = getHttpClient.GetPublicHttpClient();
        var result = await httpClient.PostAsJsonAsync($"{AuthUrl}/login", user);
        if (!result.IsSuccessStatusCode) return new LoginResponse(false, "Ocurrio un error al iniciar sesion");
        
        return (await result.Content.ReadFromJsonAsync<LoginResponse>())!;
    }

    public async Task<LoginResponse> RefreshTokenAsync(RefreshToken token)
    {
        var httpClient = getHttpClient.GetPublicHttpClient();
        var result = await httpClient.PostAsJsonAsync($"{AuthUrl}/refresh", token);
        if (!result.IsSuccessStatusCode) return new LoginResponse(false, "Ocurrio un error al refrescar el token");
        
        return (await result.Content.ReadFromJsonAsync<LoginResponse>())!;
    }
}