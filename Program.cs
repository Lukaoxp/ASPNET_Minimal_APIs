using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinimalAPIS.Dominio.Interfaces;
using MinimalAPIS.Dominio.Servicos;
using MinimalAPIS.DTOs;
using MinimalAPIS.Infraestrutura.Db;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAdministradorServico, AdministradorServico>();

builder.Services.AddDbContext<DbContexto>(options => {
    options.UseMySql(builder.Configuration.GetConnectionString("ConexaoPadrao"), 
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("ConexaoPadrao")));
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", ([FromBody] LoginDTO loginDTO, IAdministradorServico administradorServico) => {
    if(administradorServico.Login(loginDTO) != null){
        return Results.Ok("Login com sucesso");
    }
    else{
        return Results.Unauthorized();
    }
});

app.Run();