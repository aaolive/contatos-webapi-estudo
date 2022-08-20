using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contatos_webapi.Models
{
    public class Contato
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Contato()
        {
        }

        public Contato(string nome, string telefone)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Telefone = telefone;
        }

    }
}