using System.Globalization;
using System.Text.Json.Serialization;
using AutoMapper;
using JogoDaVelha.Aplicacao.Interfaces;
using JogoDaVelha.Aplicacao.Servicos;
using JogoDaVelha.Dados.Repositorios;
using JogoDaVelha.Negocios.Interfaces.Repositorios;
using JogoDaVelha.Negocios.Interfaces.Servicos;
using JogoDaVelha.Negocios.Servicos;
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

builder.Services.AddScoped(typeof(IJogadorServico), typeof(JogadorServico));
builder.Services.AddScoped(typeof(IJogadorRepositorio), typeof(JogadorRepositorio));
builder.Services.AddScoped(typeof(IJogadorServicoAplicacao), typeof(JogadorServicoAplicacao));

builder.Services.AddScoped(typeof(IPartidaServico), typeof(PartidaServico));
builder.Services.AddScoped(typeof(IPartidaRepositorio), typeof(PartidaRepositorio));
builder.Services.AddScoped(typeof(IPartidaServicoAplicacao), typeof(PartidaServicoAplicacao));

builder.Services.AddScoped(typeof(ISituacaoServico), typeof(SituacaoServico));
builder.Services.AddScoped(typeof(ISituacaoRepositorio), typeof(SituacaoRepositorio));
builder.Services.AddScoped(typeof(ISituacaoServicoAplicacao), typeof(SituacaoServicoAplicacao));

builder.Services.AddScoped(typeof(ITabuleiroServico), typeof(TabuleiroServico));
builder.Services.AddScoped(typeof(ITabuleiroRepositorio), typeof(TabuleiroRepositorio));
builder.Services.AddScoped(typeof(ITabuleiroServicoAplicacao), typeof(TabuleiroServicoAplicacao));

builder.Services.AddCors(options => options.AddPolicy("AllowAll", p => p
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod()
                ));

builder.Services.AddMvc();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAll");
//app.UseMvc();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
