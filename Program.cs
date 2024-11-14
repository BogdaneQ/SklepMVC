using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using SklepMVC.Data;

var builder = WebApplication.CreateBuilder(args);

// Dodaj DbContext z connection stringiem
builder.Services.AddDbContext<PumpPalaceDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PumpBase")));

// Dodaj us³ugi MVC oraz obs³ugê plików statycznych dla SPA
builder.Services.AddControllersWithViews();
builder.Services.AddSpaStaticFiles(configuration =>
{
    configuration.RootPath = "ClientApp/reactapp/build";
});

var app = builder.Build();

// Konfiguracja potoku HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

if (!app.Environment.IsDevelopment())
{
    app.UseSpaStaticFiles(); // Obs³uga plików statycznych w trybie produkcyjnym
}

app.UseRouting();
app.UseAuthorization();

// Mapowanie routingu dla MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Konfiguracja aplikacji SPA dla React
app.UseSpa(spa =>
{
    spa.Options.SourcePath = "ClientApp/reactapp";

    if (app.Environment.IsDevelopment())
    {
        // W trybie deweloperskim uruchamia serwer deweloperski React
        spa.UseReactDevelopmentServer(npmScript: "start");
    }
});

app.Run();
