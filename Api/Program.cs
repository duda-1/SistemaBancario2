using Core_Banco._1__Service;
using Core_Banco._1__Service.Interface;
using Core_Banco._2__Reposiotry;
using Core_Banco._2__Reposiotry.Data;
using Core_Banco._2__Reposiotry.Interface;
using TrabalhoFinal._03_Entidades.DTOs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
InicializadorBD.Inicializar();
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped<IContaCorrenteService, ContaCorrenteService>();
builder.Services.AddScoped<IContaCorrenteRepository, ContaCorrenteRepositry>();

builder.Services.AddScoped<IContaPoupancaService, ContaPoupancaService>();
builder.Services.AddScoped<IContaPoupancaRepository, ContaPoupancaRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
