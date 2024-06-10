using FoodDelivery.Api.Errors;
using FoodDelivery.Api.Filters;
using FoodDelivery.Api.Middleware;
using FoodDelivery.Application;
using FoodDelivery.Infrastructure;
using Microsoft.AspNetCore.Mvc.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.
    AddApplication().
    AddInfrastructure(builder.Configuration);
//builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlingFilterAttribute>());
builder.Services.AddControllers();

builder.Services.AddSingleton<ProblemDetailsFactory, FoodDeliveryProblemDetailsFactory>();

var app = builder.Build();

//app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseExceptionHandler("/error");
//app.UseHttpsRedirection();
app.MapControllers();

app.Run(); 
