var builder = WebApplication.CreateBuilder(args);

// Сервисы

// builder.Services.AddMvc();

// builder.Services.AddControllersWithViews();

// builder.Services.AddControllers();

var app = builder.Build();

// app.UseStaticFiles();

app.MapGet("/", () => "Hello World!");

// app.MapGet("/1/1", () => "Hello one");

app.Run();