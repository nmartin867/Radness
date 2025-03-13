using TimeApp.Api.Routes;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();
app.MapClockRoutes();

app.Run();
