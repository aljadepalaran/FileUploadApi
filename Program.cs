var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapPost("/upload", (IFormFile file) => 
{
    if(file == null)
    {
        return "Bad file";
    }
    else
    {
        var fileReader = new StreamReader(file.OpenReadStream());
        var content = fileReader.ReadToEnd();
        return content;
    }
})
.WithName("File Upload")
.DisableAntiforgery();

app.Run();
