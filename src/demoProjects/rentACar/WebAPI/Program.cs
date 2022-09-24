<<<<<<< HEAD
=======
using Application;
using Core.CrossCuttingConcerns.Exceptions;
>>>>>>> 125547c3f212856527ebc54ce59074606f091a66
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
<<<<<<< HEAD
//builder.Services.AddApplicationServices();
=======
builder.Services.AddApplicationServices();
>>>>>>> 125547c3f212856527ebc54ce59074606f091a66
//builder.Services.AddSecurityServices();
builder.Services.AddPersistenceServices(builder.Configuration);
//builder.Services.AddInfrastructureServices();
//builder.Services.AddHttpContextAccessor();

<<<<<<< HEAD
builder.Services.AddControllers();
=======
>>>>>>> 125547c3f212856527ebc54ce59074606f091a66
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

<<<<<<< HEAD
=======
//if (app.Environment.IsProduction())
    app.ConfigureCustomExceptionMiddleware();

>>>>>>> 125547c3f212856527ebc54ce59074606f091a66
app.UseAuthorization();

app.MapControllers();

<<<<<<< HEAD
app.Run();
=======
app.Run();
>>>>>>> 125547c3f212856527ebc54ce59074606f091a66
