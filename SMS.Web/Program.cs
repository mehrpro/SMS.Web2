using Microsoft.EntityFrameworkCore;
using SMS.Web;
using SMS.Web.Models;
using SMS.Web.Infrastructure;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddHostedService<Worker>();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(opts =>
{
    string conn = builder.Configuration.GetConnectionString("Conn");
    opts.UseMySql(conn, ServerVersion.AutoDetect(conn));
});

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


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
