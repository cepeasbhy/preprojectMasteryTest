using System.Data;
using Microsoft.Data.SqlClient;
using PojectMastery.Data;
using PojectMastery.Interfaces;
using PojectMastery.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddTransient<IDbConnection>(e => new SqlConnection(connectionString));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

var fileUploadOutputPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\products");
builder.Services.AddScoped<IFileUpload, LocalFileUpload>(e => new LocalFileUpload(fileUploadOutputPath));

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
