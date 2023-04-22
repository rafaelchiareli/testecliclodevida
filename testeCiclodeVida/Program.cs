using testeCiclodeVida.Interfaces;
using testeCiclodeVida.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IScopedService, Servico>();
builder.Services.AddSingleton<ISingletonService, Servico>();
builder.Services.AddTransient<ITransientService, Servico>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

