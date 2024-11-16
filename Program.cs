using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using SklepMVC.Data;

var builder = WebApplication.CreateBuilder(args);

// Dodanie DbContext z connection string z appsettings.json
builder.Services.AddDbContext<PumpPalaceDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Konfiguracja CORS (umo�liwienie po��cze� z aplikacj� React na innym porcie)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp", policy =>
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());
});

// Dodanie us�ug MVC oraz obs�ugi plik�w statycznych dla SPA
builder.Services.AddControllersWithViews();
builder.Services.AddSpaStaticFiles(configuration =>
{
    configuration.RootPath = "ClientApp/reactapp/build";  // �cie�ka do zbudowanej aplikacji React
});

var app = builder.Build();

// Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();  // W��cz HSTS (HTTP Strict Transport Security) w trybie produkcyjnym
}

app.UseHttpsRedirection();  // Przekierowanie do HTTPS
app.UseStaticFiles();  // Obs�uguje pliki statyczne w trybie produkcyjnym

// W��czanie plik�w statycznych dla SPA w trybie produkcyjnym
if (!app.Environment.IsDevelopment())
{
    app.UseSpaStaticFiles();
}

app.UseRouting();
app.UseCors("AllowReactApp");  // W��cz CORS
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
