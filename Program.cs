using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using SklepMVC.Data;

var builder = WebApplication.CreateBuilder(args);

// Dodanie DbContext z connection string z appsettings.json
builder.Services.AddDbContext<PumpPalaceDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Konfiguracja CORS (umo¿liwienie po³¹czeñ z aplikacj¹ React na innym porcie)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp", policy =>
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());
});

// Dodanie us³ug MVC oraz obs³ugi plików statycznych dla SPA
builder.Services.AddControllersWithViews();
builder.Services.AddSpaStaticFiles(configuration =>
{
    configuration.RootPath = "ClientApp/reactapp/build";  // Œcie¿ka do zbudowanej aplikacji React
});

var app = builder.Build();

// Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();  // W³¹cz HSTS (HTTP Strict Transport Security) w trybie produkcyjnym
}

app.UseHttpsRedirection();  // Przekierowanie do HTTPS
app.UseStaticFiles();  // Obs³uguje pliki statyczne w trybie produkcyjnym

// W³¹czanie plików statycznych dla SPA w trybie produkcyjnym
if (!app.Environment.IsDevelopment())
{
    app.UseSpaStaticFiles();
}

app.UseRouting();
app.UseCors("AllowReactApp");  // W³¹cz CORS
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();  // Mapowanie routingu dla API
});

// Konfiguracja aplikacji SPA dla React
app.UseSpa(spa =>
{
    spa.Options.SourcePath = "ClientApp/reactapp";

    if (app.Environment.IsDevelopment())
    {
        // Uruchomienie serwera deweloperskiego React w trybie deweloperskim
        spa.UseReactDevelopmentServer(npmScript: "start");
    }
});

app.Run();
