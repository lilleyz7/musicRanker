using Microsoft.EntityFrameworkCore;
using musicRanker.Data;
var builder = WebApplication.CreateBuilder(args);

//services
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

var environmentStatus = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

if (environmentStatus == "Production")
{
    string productionDatabaseConnection = Environment.GetEnvironmentVariable("ProductionDatabaseConnection") ?? throw new NullReferenceException("Invalid production string");
    builder.Services.AddDbContext<MusicDbContext>(
        options => options.UseSqlite(productionDatabaseConnection)
    );
}
else
{
    builder.Services.AddDbContext<MusicDbContext>(
        options => options.UseSqlite("Data Source=music.db")
    );
}

// app settings

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();