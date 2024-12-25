using TestTakip.BusinessLayer.Abstract;
using TestTakip.BusinessLayer.Concrete;
using TestTakip.DataAccessLayer.Abstract;
using TestTakip.DataAccessLayer.Context;
using TestTakip.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<TestContext>();

builder.Services.AddScoped<IEmployeeDal, EfEmplyoeeDal>();
builder.Services.AddScoped<IEmplyoeeService, EmplyoeeManager>();

builder.Services.AddScoped<IJobDal, EfJobDal>();
builder.Services.AddScoped<IJobService, JobManager>();


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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
