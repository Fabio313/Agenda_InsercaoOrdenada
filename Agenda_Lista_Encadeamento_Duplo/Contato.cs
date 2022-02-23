using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Lista_Encadeamento_Duplo
{
    internal class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public ListaTelefones ListaTelefones { get; set; }
        public Contato Proximo { get; set; }
        public Contato Anterior { get; set; }

        public Contato(string nome, string email, ListaTelefones lista)
        {
            Nome = nome;
            Email = email;
            ListaTelefones = lista;
            Proximo = null;
            Anterior = null;
        }
        public override string ToString()
        {
            return "--------------------------\nNome: " + Nome + "\nE-mail: " + Email + "\nTelefones: ";
        }
    }
}
