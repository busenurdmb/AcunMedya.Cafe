using AcunMedya.Cafe.Context;
using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddFluentValidationAutoValidation(). //ModelState �s valid fluentvalidation entegresi
                AddFluentValidationClientsideAdapters(). // taray�c� taraf�nda hata g�stermek i�in
                AddValidatorsFromAssembly(Assembly.GetExecutingAssembly()); //validator s�n�flar�n� tan�mas� i�in 

builder.Services.AddDbContext<CafeContext>();

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
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
