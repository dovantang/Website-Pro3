using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NetCore_Model.Models;
using NetCore_MVC.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("NetCore_MVCContextConnection") ?? throw new InvalidOperationException("Connection string 'NetCore_MVCContextConnection' not found.");
var connectionString1 = builder.Configuration.GetConnectionString("DataConText") ?? throw new InvalidOperationException("Connection string 'NetCore_MVCContextConnection' not found.");

builder.Services.AddDbContext<NetCore_MVCContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDbContext<PimvContext>(options =>
    options.UseSqlServer(connectionString1));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<NetCore_MVCContext>();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
