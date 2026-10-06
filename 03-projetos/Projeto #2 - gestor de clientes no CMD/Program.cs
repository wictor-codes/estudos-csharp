using System.Runtime.Serialization.Formatters.Binary;

namespace Projeto_2___gestor_de_clientes_no_CMD
{

    using System.IO;    //para poder colocar em arquivos e não perde-los cada vez que roda o programa

    internal class Program
    {
        struct Cliente
        {
            public string nome;
            public string email;
            public string cpf;
        }

        static List<Cliente> clientes = new List<Cliente>(); // variavel global

        enum Menu { Listagem = 1, Adicionar, Remover, Sair }


        static void Main(string[] args)
        {
            carregar();             // para carregar a listagem desde o inicio do programa

            bool sair = false;
            while (!sair)           // (sair) = true (!sair) = false 
            {
                Console.WriteLine("Sistema de clientes - Bem vindo!");
                Console.WriteLine("1-Listagem\n2-Adicionar\n3-Remover\n4-Sair");
                Console.Write("Digite uma opção: ");
                int option = int.Parse(Console.ReadLine());
                Menu Opcao = (Menu)option;

                switch (Opcao)
                {
                    case Menu.Listagem:
                        acessarLista();
                        break;
                    case Menu.Adicionar:
                        adicionar();
                        break;
                    case Menu.Remover:
                        remover();
                        break;
                    case Menu.Sair:
                        sair = true;
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
        }



        static void adicionar()
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("====== Cadastro de cliente ======");

            Console.Write("Nome do cliente: ");
            cliente.nome = Console.ReadLine();
            Console.Write("Email do cliente: ");
            cliente.email = Console.ReadLine();
            Console.Write("CPF do cliente: ");
            cliente.cpf = Console.ReadLine();

            clientes.Add(cliente);
            salvar();               // para salar sempre que adiciona um novo cliente

            Console.WriteLine("Cadastro concluído! Aperte enter para sair");
            Console.ReadLine();
        }


        static void acessarLista()
        {
            if (clientes.Count > 0)
            {
                Console.WriteLine("====== Lista de clientes ======");

                int i = 0;
                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine($"ID: {i}");
                    Console.WriteLine($"Nome: {cliente.nome}");
                    Console.WriteLine($"Email: {cliente.email}");
                    Console.WriteLine($"CPF: {cliente.cpf}");
                    Console.WriteLine("========================");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Não tem nenhum cliente cadastrado!");
            }
        }

        static void listagem()
        {
            acessarLista();
            Console.WriteLine("Aperte enter para sair");
            Console.ReadLine();
        }


        static void salvar()
        {
            using (StreamWriter escrever = new StreamWriter("clientela.txt"))
            {
                foreach (Cliente cliente in clientes)
                {
                    escrever.WriteLine(cliente.nome);
                    escrever.WriteLine(cliente.email);
                    escrever.WriteLine(cliente.cpf);
                    escrever.WriteLine("========================");
                }
                escrever.Close();   // mas não precisa disso quando usa o 'using'
            }
        }


        static void carregar()
        {
            if (!File.Exists("clientela.txt"))
                return; // se não tem arquivo ainda, não tem nada pra carregar

            using (StreamReader ler = new StreamReader("clientela.txt"))
            {
                List<string> linhas = new List<string>();

                string linha;
                while ((linha = ler.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }

                // cada cliente ocupa 4 linhas: nome, email, cpf e o separador(===)
                for (int i = 0; i < linhas.Count; i += 4)       // o i pular de 3 em 3 a cada volta, mas o loop continua rodando enquanto i < linhas.Count
                {
                    Cliente cliente = new Cliente();
                    cliente.nome = linhas[i];
                    cliente.email = linhas[i + 1];
                    cliente.cpf = linhas[i + 2];
                    // linhas[i + 3] é o "========", só ignorar ele

                    clientes.Add(cliente);
                }
            }
        }


        static void remover()
        {
            acessarLista();             // só mostra a lista, sem travar esperando Enter
            Console.Write("Digite o ID do cliente que você quer remover: ");
            int id = int.Parse(Console.ReadLine());

            if (id >= 0 && id < clientes.Count)
            {
                clientes.RemoveAt(id);
                salvar();               // para salvar essa modificação
            }
            else
            {
                Console.WriteLine("ID informado é inválido, tente novamente!");
            }
            Console.ReadLine();
        }



    }
}
