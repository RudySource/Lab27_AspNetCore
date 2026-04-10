var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello от ИСП-233! Автор: RUDY");

app.Run();
