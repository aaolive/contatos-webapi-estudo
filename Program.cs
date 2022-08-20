using contatos_webapi.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Api de contatos!");

//app.MapGet("/", () => new Contato());

// rota para todos os contatos
app.MapGet("/todoscontatos", () => DadosDeContatos.listaDeContatos);

app.Run();