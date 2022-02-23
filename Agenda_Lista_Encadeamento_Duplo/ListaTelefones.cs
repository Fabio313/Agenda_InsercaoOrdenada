using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Lista_Encadeamento_Duplo
{
    internal class ListaTelefones
    {
        public Telefone Head { get; set; }
        public Telefone Tail { get; set; }

        public ListaTelefones()
        {
            Head = Tail = null;
        }
        public void Push(Telefone aux)
        {
            if (Vazio())
            {
                Head = Tail = aux;
            }
            else
            {
                Tail.Proximo = aux;
                aux.Anterior = Tail;
                Tail = aux;
            }
        }
        public void Print()
        {
            if (Vazio())
            {
                Console.WriteLine(">>>>>>NENHUM TELEFONE ADICIONADO<<<<<<");
            }
            else
            {
                Telefone aux = Head;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                } while (aux != null);
            }
        }
        public bool Vazio()
        {
            if ((Head == null) && (Tail == null))
                return true;
            return false;
        }
    }
}
