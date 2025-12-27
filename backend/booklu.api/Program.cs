using booklu.api.Infraestructure.DependencyInjection;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Documentación OpenAPI nativa de Microsoft
builder.Services.AddOpenApi();

builder.Services.AddDistributedMemoryCache(); 
builder.Services.AddSession(options => { 
    options.IdleTimeout = TimeSpan.FromDays(7); 
    options.Cookie.HttpOnly = true; options.Cookie.IsEssential = true; }
);
builder.Services.AddHttpContextAccessor();

//Booklu services, cache and repositories
builder.Services.AddBookluServices();
builder.Services.AddBookluRepositories();
builder.Services.AddBookluCustomCache();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseSession();
app.MapControllers();

app.Run();
