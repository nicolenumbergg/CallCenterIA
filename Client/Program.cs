using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Client;
using ClientLibrary.Helpers;
using ClientLibrary.Services.Contracts;
using ClientLibrary.Services.Implementations;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.FluentUI.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components.Components.Tooltip;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddTransient<CustomHttpHandler>();
builder.Services.AddHttpClient("SystemApiClient", client =>
{
    client.BaseAddress = new Uri("http://localhost:5117");
}).AddHttpMessageHandler<CustomHttpHandler>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5117") });

builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<GetHttpClient>();
builder.Services.AddScoped<LocalStorageService>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddScoped<ToastService>();
builder.Services.AddScoped<ITooltipService, TooltipService>();
builder.Services.AddFluentUIComponents();

builder.Services.AddScoped<IUserAccountService, UserAccountService>();


await builder.Build().RunAsync();