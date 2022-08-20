using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contatos_webapi.Models
{
    public class DadosDeContatos
    {
        public static List<Contato> listaDeContatos = new List<Contato>(){
            new Contato(){
                Id=Guid.NewGuid(),
                Nome="Maria",
                Telefone="3369-4569"
            },
            new Contato(){
                Id=Guid.NewGuid(),
                Nome="Anderson",
                Telefone="3369-4569"
            },
            new Contato(){
                Id=Guid.NewGuid(),
                Nome="Luiz",
                Telefone="8765-4523"
            },
            new Contato(){
                Id=Guid.NewGuid(),
                Nome="Carla",
                Telefone="9899-0022"
            }
        };
    }
}