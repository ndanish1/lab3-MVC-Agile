using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCAgile_ProcessWith_Agile.Data;
using MvcMovie.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MVCAgile_ProcessWith_AgileContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MVCAgile_ProcessWith_AgileContext") ?? throw new InvalidOperationException("Connection string 'MVCAgile_ProcessWith_AgileContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}


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

static void Main()
{
    Console.WriteLine("Enter a string:");
    string input = Console.ReadLine();

    // Output original string
    Console.WriteLine($"Original string: {input}");

    // Output string in uppercase
    Console.WriteLine($"Uppercase string: {input.ToUpper()}");

    Console.WriteLine("Press any key to exit.");
    Console.ReadKey();
}
