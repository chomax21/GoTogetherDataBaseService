using GoTogetherDataBaseService.Data.AppContext;
using GoTogetherDataBaseService.Data.Models;
using GoTogetherDataBaseService.Interfaces;
using GoTogetherDataBaseService.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connetcionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<GoTogetherContext>(options => options.UseNpgsql(connetcionString));
builder.Services.AddScoped<IPersonCreator<User>,PersonCreator>();

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
