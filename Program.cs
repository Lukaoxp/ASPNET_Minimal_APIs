using Microsoft.EntityFrameworkCore;
using MinimalAPIS.DTOs;
using MinimalAPIS.Infraestrutura.Db;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbContexto>(options => {
    options.UseMySql(builder.Configuration.GetConnectionString("ConexaoPadrao"), 
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("ConexaoPadrao")));
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (LoginDTO loginDTO) => {
    if(loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456"){
        return Results.Ok("Login com sucesso");
    }
    else{
        return Results.Unauthorized();
    }
});

app.Run();