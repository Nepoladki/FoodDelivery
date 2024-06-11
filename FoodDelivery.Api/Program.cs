using FoodDelivery.Api.Common.Errors;
using FoodDelivery.Application;
using FoodDelivery.Infrastructure;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.
    AddApplication().
    AddInfrastructure(builder.Configuration);

builder.Services.AddControllers();

builder.Services.AddSingleton<ProblemDetailsFactory, FoodDeliveryProblemDetailsFactory>();

var app = builder.Build();

app.UseExceptionHandler("/error");
//app.UseHttpsRedirection();
app.MapControllers();

app.Run(); 
