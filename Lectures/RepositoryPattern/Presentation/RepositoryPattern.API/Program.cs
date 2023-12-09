using RepositoryPattern.Application.Repositories.CustomerRepositories;
using RepositoryPattern.Application.Repositories.ProductRepositories;
using RepositoryPattern.Persistence.Contexts;
using RepositoryPattern.Persistence.Repositories.CustomerRepositories;
using RepositoryPattern.Persistence.Repositories.ProductRepositories;
using RepositoryPattern.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddPersistenceServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
