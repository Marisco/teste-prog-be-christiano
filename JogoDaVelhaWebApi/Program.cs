using System.Globalization;
using System.Text.Json.Serialization;
using AutoMapper;
using JogoDaVelha.WebApi.Mappers;


var builder = WebApplication.CreateBuilder(args);

var DefaultCulture = new CultureInfo("pt-BR");

CultureInfo.DefaultThreadCurrentCulture = DefaultCulture;
CultureInfo.CurrentCulture = DefaultCulture;
CultureInfo.DefaultThreadCurrentUICulture = DefaultCulture;

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{    
    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AutomapperConfig());
});

var mapper = config.CreateMapper();

builder.Services.AddSingleton(mapper);

builder.Services.AddCors(options => options.AddPolicy("AllowAll", p => p
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod()
                ));

//builder.Services.AddMvc();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowSpecificOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
