using Microsoft.OpenApi.Models;
using Polly;
using SpaceX.Common.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors();
builder.Services.AddSwaggerGen();

builder.Services.AddLaunchApiClient((httpClient) =>
{
    httpClient.BaseAddress = new(builder.Configuration.GetSection("SpaceX:BaseUrl").Value);
}).AddTransientHttpErrorPolicy(builder => builder.WaitAndRetryAsync(new[]
{
    TimeSpan.FromSeconds(1),
    TimeSpan.FromSeconds(4),
    TimeSpan.FromSeconds(8)
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors(builder => builder
    .AllowAnyHeader()
    .AllowAnyMethod()
    .WithOrigins("http://localhost:4200"));
//app.UseAuthentication();
//app.UseAuthorization();
app.MapControllers();
app.Run();