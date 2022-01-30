using Boilerplate_Microservice_WebAPI.DBContexts;
using Boilerplate_Microservice_WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

#region Defaults
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#endregion

#region User Defined 
builder.Services.AddDbContext<ProductContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("ProductDB")));
builder.Services.AddTransient<IProductRepository, ProductRepository>();
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
