using booklu.api.Infraestructure.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseSession();
app.MapControllers();

app.Run();
