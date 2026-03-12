using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware

//app.Use(async (context, next) =>
//{
//    Console.WriteLine("Middleware 1 - Before Request");

//    await next();

//    Console.WriteLine("Middleware 1 - After Response");
//});

//app.UseMiddleware<ExceptionMiddleware>();

//app.MapGet("/", () => Console.WriteLine("Hello World"));


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware<ExceptionMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();