using DECO_Pets.Data;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(60);
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();

RequestLocalizationOptions localizationOptions = new RequestLocalizationOptions

{

    SupportedCultures = new List<CultureInfo> { new CultureInfo("en-US") },

    SupportedUICultures = new List<CultureInfo> { new CultureInfo("en-US") },

    DefaultRequestCulture = new RequestCulture("en-US")

};

app.UseRequestLocalization(localizationOptions);
/*app.MapControllerRoute(

    name: "Admin",

    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");*/

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
