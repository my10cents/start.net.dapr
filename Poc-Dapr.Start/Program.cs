var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGet("/teste", async context =>
{
    await context.Response.WriteAsync("Hello World!");
});

app.Run();