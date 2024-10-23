using BankAccounts.API.Infrastructure;
using BankAccounts.API.Infrastructure.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.RegisterInfrastructure();


var app = builder.Build();

app.ApplySeedData();
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
