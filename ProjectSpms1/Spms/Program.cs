using Microsoft.EntityFrameworkCore;
using spms.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
// builder.Services.AddDbContext<spms.Models.SiteDbContext>();
builder.Services.AddDbContext<SiteDbContext>(options =>
    options.UseMySQL("Data Source=172.20.160.1;Database=spms;User Id=root;Password=root"));

builder.Services.AddAuthentication()
                .AddCookie(option => option.LoginPath = "");
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.UseAuthentication();
app.UseAuthorization();
app.UseCors(permission => permission.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.MapDefaultControllerRoute();
app.Run();
