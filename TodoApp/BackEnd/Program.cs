using BackEnd;

var builder = WebApplication.CreateBuilder(args);

// database 
builder.Services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("TodoList"));

// CORS policy for the client
builder.Services.AddCors(
    options => options.AddPolicy(
        "wasm",
        policy => policy.WithOrigins([
                builder.Configuration["BackendUrl"] ?? "http://localhost:8080",
                builder.Configuration["FrontendUrl"] ?? "http://localhost:8081"
            ])
            .AllowAnyMethod()
            .AllowAnyHeader()));

builder.Services.AddControllers();
// Add services to the container
builder.Services.AddEndpointsApiExplorer();
// Add NSwag services
builder.Services.AddOpenApiDocument();

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    // Seed the database
    await using var scope = app.Services.CreateAsyncScope();
    await SeedData.InitializeAsync(scope.ServiceProvider);
    // Add OpenAPI/Swagger generator and the Swagger UI
    app.UseOpenApi();
    app.UseSwaggerUi();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
