using Microsoft.EntityFrameworkCore;
using Web.Api.Infrastucture.Context;
using Web.Api.Service.Faculty.Command;
using Web.Api.Service.Faculty.Query;
using Web.Api.Service.ProgramStudy.Command;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<FacultyCommand>();
builder.Services.AddScoped<FacultyQuery>();
builder.Services.AddScoped<ProgramStudyCommand>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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
