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

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Context>();

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
