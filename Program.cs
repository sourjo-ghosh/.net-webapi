var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    return "Hello world";
});

app.MapGet("/hello", () =>
{
    return "hi this is joy ghosh sourjoo and i am learning c#/dotnet/webapi thank you";
});

app.Run();
