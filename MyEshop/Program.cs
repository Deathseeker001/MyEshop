using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyEshop.Data;
using MyEshop.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region Db Context 
builder.Services.AddDbContext<MyEshopContext>(options =>
 options.UseSqlServer("Data Source = GHAZALEH\\SQLEXPRESS; Initial Catalog = EshopCore_DB ; Integrated Security = True; TrustServerCertificate=True;"));
#endregion

#region Ioc

builder.Services.AddScoped<IGroupRepository , GroupRepository>();

#endregion
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
