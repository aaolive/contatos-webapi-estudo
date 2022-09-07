using contatos_webapi.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Api de contatos!");

//app.MapGet("/", () => new Contato());

// rota para todos os contatos
app.MapGet("/contato", () => DadosDeContatos.listaDeContatos);

// rota para trazer um contato
app.MapGet("/contato/{id}", (Guid id) =>
    DadosDeContatos.listaDeContatos.Find(contato => contato.Id == id));

// rota para criar um contato
app.MapPost("/contato", (Contato contato) =>
{
    DadosDeContatos.listaDeContatos.Add(contato);
    Results.Ok("Contato criado");

});

// rota para deletar um contato
app.MapDelete("/contato/{id}", (Guid id) =>
{

    var contatoParaDeletar = DadosDeContatos.listaDeContatos.FirstOrDefault(contato => contato.Id == id);
    if (contatoParaDeletar != null)
    {
        DadosDeContatos.listaDeContatos.Remove(contatoParaDeletar);
        Results.Ok();
    }
    else
    {
        Results.NotFound("Nao foi encontrado um contato");
    }

});

// rota para atualizar um contato
app.MapPut("/contato/atualizar/{id}", (Guid id, Contato contatoRecebidoParaAtualizar) =>
{

    var contatoParaAtualizar = DadosDeContatos.listaDeContatos.Find(contato => contato.Id == id);
    var indiceDoContatoParaAtualizar=DadosDeContatos.listaDeContatos.FindIndex(contato =>contato.Id==id);

    if (contatoParaAtualizar != null)
    {
        contatoParaAtualizar.Nome = contatoRecebidoParaAtualizar.Nome;
        contatoParaAtualizar.Telefone = contatoRecebidoParaAtualizar.Telefone;
        DadosDeContatos.listaDeContatos.Insert(indiceDoContatoParaAtualizar,contatoParaAtualizar);
    }

});

app.Run();