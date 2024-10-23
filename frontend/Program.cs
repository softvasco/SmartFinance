using frontend.Components;
using Microsoft.AspNetCore.DataProtection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDataProtection()
        .PersistKeysToFileSystem(new DirectoryInfo("/app/DataProtectionKeys"));

// Adicionar HttpClient
builder.Services.AddScoped(sp =>
{
    var configuration = sp.GetRequiredService<IConfiguration>();
    var apiUrl = !builder.Environment.IsEnvironment("Development") ? "http://smart_finance_api/" : "http://localhost:5192/";
    return new HttpClient { BaseAddress = new Uri(apiUrl) };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
