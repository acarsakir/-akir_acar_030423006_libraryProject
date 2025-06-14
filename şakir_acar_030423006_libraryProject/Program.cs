using businessLayer.abstracts;
using businessLayer.concrete;
using dataAccessLayer;
using dataAccessLayer.abstracts;
using dataAccessLayer.concrete;
using dataAccessLayer.entityFramework;
using entityLayer.concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Render'ın verdiği portu al
var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";

builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.ListenAnyIP(int.Parse(port));  // Tüm IP'lerde belirtilen portu dinle
});

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddDbContext<Context>();
builder.Services.AddDbContext<Context>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddIdentity<appUser, appRole>()
    .AddEntityFrameworkStores<Context>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<IKitaplarDal, EfKitaplarDal>();
builder.Services.AddScoped<IKitaplarService, kitaplarManager>();

builder.Services.AddScoped<IAppUserDal, EfAppUserDal>();
builder.Services.AddScoped<IAppUserService, appUserManager>();

builder.Services.AddScoped<IAppRoleDal, EfAppRoleDal>();
builder.Services.AddScoped<IAppRoleService, appRoleManager>();


builder.Services.AddScoped<IUyelerDal, EfUyelerDal>();
builder.Services.AddScoped<IUyelerService, uyelerManager>();

builder.Services.AddScoped<IOduncDal, EfOduncKitaplarDal>();
builder.Services.AddScoped<IOduncServis, oduncVerilenManager>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
