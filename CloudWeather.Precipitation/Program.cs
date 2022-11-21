using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/observation/{town}", (string town, [FromQuery] int? days) =>
{
    return Results.Ok(town);
});

app.Run();

