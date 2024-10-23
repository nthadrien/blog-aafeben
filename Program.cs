using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Localization.Routing;
using Microsoft.AspNetCore.Mvc.Razor;


var builder = WebApplication.CreateBuilder(args);

// i18n Localizers +++++++++++++++++++++


var supportedCultures = new[] { new CultureInfo(name:"en"), new CultureInfo(name:"fr") };
var supportedCulturesString = new[] { 
    "en","fr"
};

builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.Services.AddMvc()
    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization();


builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture(culture: "fr", uiCulture: "fr");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
    options.FallBackToParentCultures= true;
    options.FallBackToParentUICultures= true;
});
// +++++++++++++++++++++

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// i18n middleware +++++++++++++++++++

var requestProvider = new RouteDataRequestCultureProvider();
 
var requestLocalizationOptions = new RequestLocalizationOptions 
{
    DefaultRequestCulture = new RequestCulture("fr"),
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures,
};

requestLocalizationOptions.RequestCultureProviders.Insert(index: 0, requestProvider );
app.UseRequestLocalization(requestLocalizationOptions);

// ----------------------------------------

app.MapControllerRoute(
    name: "default",
    pattern: "{culture=fr}/{controller=Home}/{action=Index}/{id?}");

app.Run();