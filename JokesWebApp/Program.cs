using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using JokesWebApp.Data;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>(options =>


    options.UseSqlServer(builder.Configuration.GetConnectionString("Context") ?? throw new InvalidOperationException("Connection string 'Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMvc();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

void ConfigureServices(IServiceCollection services)
{
    services.AddMvc();
    services.AddControllers();
    //services.AddSingleton<JokeRepository, HotelRepository>();
    //services.AddSingleton<IHotelService, HotelManager>();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
