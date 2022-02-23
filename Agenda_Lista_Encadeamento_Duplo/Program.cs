using System;

namespace Agenda_Lista_Encadeamento_Duplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaContatos meuscontatos = new ListaContatos();
            int opc;
            do
            {
                opc = menu();
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        meuscontatos.Push(cadastro());
                        Console.WriteLine(">>>>>>CONTATO INSERIDO COM SUCESSO<<<<<<");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        if (meuscontatos.Vazio())
                        {
                            Console.WriteLine(">>>>>>AGENDA VAZIA<<<<<<");
                            Console.ReadKey();
                        }
                        else
                        {
                            meuscontatos.Buscar(meuscontatos.Encontrar(buscar()));
                            Console.ReadKey();
                        }
                         break;
                    case 3:
                        Console.Clear();
                        if (meuscontatos.Vazio())
                        {
                            Console.WriteLine(">>>>>>AGENDA VAZIA<<<<<<");
                            Console.ReadKey();
                        }
                        else
                        {
                            meuscontatos.Pop(meuscontatos.Encontrar(buscar()));
                            Console.ReadKey();
                        }
                         break;
                    case 4:
                        Console.Clear();
                        if (meuscontatos.Vazio())
                        {
                            Console.WriteLine(">>>>>>AGENDA VAZIA<<<<<<");
                            Console.ReadKey();
                        }
                        else
                        {
                            meuscontatos.Alterar(meuscontatos.Encontrar(buscar()));
                            Console.ReadKey();
                        }
                         break;
                    case 5:
                        Console.Clear();
                        meuscontatos.Print();
                        Console.ReadKey();
                        break;
                }
            } while (opc != 0);
        }
        public static int menu()
        {
            int opc;
            Console.Clear();
            Console.WriteLine("========MENU PRINCIPAL========");
            Console.WriteLine("1-Cadastrar contato");
            Console.WriteLine("2-Localizar contato");
            Console.WriteLine("3-Remover contato");
            Console.WriteLine("4-Editar contato");
            Console.WriteLine("5-Imprimir contatos");
            Console.WriteLine("0-sair");
            if (int.TryParse(Console.ReadLine(), out int canParse))
            {
                opc = canParse;
            }
            else
            {
                opc = -1;
            }
            return opc;
        }
        public static Contato cadastro()
        {
            string nome, email;
            Console.WriteLine(">>>>>>CADASTRO CONTATO<<<<<<");
            Console.Write("Nome: ");
            nome = Console.ReadLine().Trim();
            Console.Write("E-mail: ");
            email = Console.ReadLine();

            ListaTelefones aux = new ListaTelefones();
            int tipo, ddd;
            string tipoescolhido, numero;
            int nnumero = 1;
            do
            {

                if (nnumero == 1)
                {
                    do
                    {
                        do
                        {
                            Console.WriteLine("Digite o tipo de telefone\n1-Celular\n2-Residencial\n3-Trabalho\n4-Recado");
                            if (int.TryParse(Console.ReadLine(), out int canParse))
                            {
                                tipo = canParse;
                            }
                            else
                            {
                                tipo = -1;
                                Console.WriteLine("Opção invalido!\nDigite novamente");
                            }
                        }while ((tipo > 4) || (tipo < 1));
                        switch (tipo)
                        {
                            case 1:
                                tipoescolhido = "Celular";
                                break;
                            case 2:
                                tipoescolhido = "Residencial";
                                break;
                            case 3:
                                tipoescolhido = "Trabalho";
                                break;
                            case 4:
                                tipoescolhido = "Recado";
                                break;
                            default:
                                tipoescolhido = "Invalido";
                                break;
                        }
                    } while ((tipo > 4) || (tipo < 1));
                    do
                    {
                        Console.Write("Digite o DDD da sua cidade: ");
                        if (int.TryParse(Console.ReadLine(), out int canParse))
                        {
                            ddd = canParse;
                        }
                        else
                        {
                            ddd = -1;
                            Console.WriteLine("DDD invalido!\nDigite novamente");
                        }
                    } while (ddd<1);
                    Console.Write("Digite o numero de telefone: ");
                    numero = Console.ReadLine();
                    aux.Push(new Telefone(tipoescolhido, ddd, numero));
                    Console.WriteLine("Deseja adicionar um novo numero?(1-para sim | 0 para nao)");
                    nnumero = int.Parse(Console.ReadLine());
                }
            } while (nnumero == 1);

            return new Contato(nome, email, aux);
        }
        public static string buscar()
        {
            string busca;
            Console.Write("Digite o nome do contato: ");
            busca = Console.ReadLine().ToLower();
            return busca;
        }
    }
}
