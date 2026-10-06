using System.IO;

namespace Projeto__3___Gestor_de_estoque_POO_no_CMD
{ 
    internal class Program
    {

        static List<IEstoque> produtos = new List<IEstoque>();                      // para acessar em métodos estaticos e para guardar uma lista que respeite os metodos da interface
        enum Menu { Listar = 1, Adicionar, Remover, Entrada, Saída, Sair }

        static void Main(string[] args)
        {
            Carregar();

            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("Sistema de estoque");
                Console.WriteLine("1- Listar\n2- Adicionar\n3- Remover\n4- Registrar entrada\n5- Registrar saída\n6- Sair");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao > 0 && opcao < 7)
                {
                    Menu escolha = (Menu)opcao;
                    switch (escolha)
                    {
                        case Menu.Listar:
                            Listagem();
                            break;
                        case Menu.Adicionar:
                            Cadastro();
                            break;
                        case Menu.Remover:
                            Remover();
                            break;
                        case Menu.Entrada:
                            Entrada();
                            break;
                        case Menu.Saída:
                            Saida();
                            break;
                        case Menu.Sair:
                            Salvar();
                            sair = true;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida, pressione ENTER e tente novamente");
                    Console.ReadLine();
                }
                Console.Clear();
            }
        }





        




        static void Cadastro()
        {
            Console.WriteLine("====== Cadastro de Produto ======");
            Console.WriteLine("1- Produto Físico\n2- Ebook\n3- Curso");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                 case 1:
                    CadastrarProdFisico();
                    break;
                 case 2:
                    CadastrarEbook();
                    break;
                 case 3:
                    CadastrarCurso();
                    break;
            }
        }



       static void CadastrarProdFisico()
       {
            Console.WriteLine("Cadastrando produto físico:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            float preco = float.Parse(Console.ReadLine());

            Console.Write("Frete: ");
            float frete = float.Parse(Console.ReadLine());

            ProdutoFísico pf = new ProdutoFísico(nome, preco, frete);
            produtos.Add(pf);
       }



       static void CadastrarEbook()
       {
            Console.WriteLine("Cadastrando Ebook:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            float preco = float.Parse(Console.ReadLine());

            Console.Write("Autor: ");
            string autor = Console.ReadLine();

            Ebook eb = new Ebook(nome, preco, autor);
            produtos.Add(eb);
       }



       static void CadastrarCurso()
       {
            Console.WriteLine("Cadastrando Curso:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            float preco = float.Parse(Console.ReadLine());

            Console.Write("Autor: ");
            string autor = Console.ReadLine();

            Curso cs = new Curso(nome, preco, autor);
            produtos.Add(cs);
       }

                
      
       static void Salvar()
       {
            StreamWriter escrita = File.CreateText("ListaEstoque.txt");

            foreach (IEstoque produto in produtos)
            {
               produto.Salvar(escrita);                    // "Produto, execute seu método Salvar e use esse arquivo (escrita) para escrever"
            }

            escrita.Close();
       }



        static void Listagem()
        {
            Console.WriteLine("====== Listagem de Produtos ======");
            Console.WriteLine($"Quantidade de produtos: {produtos.Count}");

            int i = 0;
            foreach (IEstoque produto in produtos)
            {
                Console.WriteLine($"ID: {i}");
                produto.Exibir();
                i++;
            }

            Console.WriteLine("Fim da listagem.");
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
        }



        static void Carregar()
        {
            Console.WriteLine("CARREGANDO...");

            if (!File.Exists("ListaEstoque.txt"))
            {
                Console.WriteLine("Arquivo não encontrado!");
                return;                                                 // se nao existir, não passa daqui
            }

            StreamReader leitura = new StreamReader("ListaEstoque.txt");

            List<string> linhas = new List<string>();               // leitura com lista
            string linha = "";



            while ((linha = leitura.ReadLine()) != null)
            {
                if (linha == "EBOOK")
                {
                    string nome = leitura.ReadLine().Replace("Nome:", "");
                    string autor = leitura.ReadLine().Replace("Autor:", "");
                    float preco = float.Parse(leitura.ReadLine().Replace("Preço:", ""));
                    int vendas = int.Parse(leitura.ReadLine().Replace("Vendas:", ""));


                    Ebook ebook = new Ebook(nome, preco, autor, vendas);

                    produtos.Add(ebook);
                }

                else if (linha == "CURSO")
                {
                    string nome = leitura.ReadLine().Replace("Nome:", "");
                    string autor = leitura.ReadLine().Replace("Autor:", "");
                    float preco = float.Parse(leitura.ReadLine().Replace("Preço:", ""));
                    int vagas = int.Parse(leitura.ReadLine().Replace("Vagas restantes:", ""));

                    Curso curso = new Curso(nome, preco, autor, vagas);

                    produtos.Add(curso);
                }

                else if (linha == "FÍSICO")
                {
                    string nome = leitura.ReadLine().Replace("Nome:", "");
                    float frete = float.Parse(leitura.ReadLine().Replace("Frete:", ""));
                    float preco = float.Parse(leitura.ReadLine().Replace("Preço:", ""));
                    int estoque = int.Parse(leitura.ReadLine().Replace("Estoque:", ""));

                    ProdutoFísico fisico = new ProdutoFísico(nome, preco, frete, estoque);

                    produtos.Add(fisico);
                }
            }

            leitura.Close();
        }




        static void Remover()
        {
            Listagem();
            Console.Write("Digite o ID do elemento que você quer remover: ");
            int id = int.Parse(Console.ReadLine());

            if (id >= 0 && id < produtos.Count)
            {
                produtos.RemoveAt(id);
                Salvar();
            }

        }



        static void Entrada()
        {
            Listagem();
            Console.Write("Digite o ID do elemento que você quer dar entrada: ");
            int id = int.Parse(Console.ReadLine());

            if (id >= 0 && id < produtos.Count)
            {
                produtos[id].AdicionarEntrada();
                Salvar();
            }
        }



        static void Saida()
        {
            Listagem();
            Console.Write("Digite o ID do elemento que você quer dar baixa: ");
            int id = int.Parse(Console.ReadLine());

            if (id >= 0 && id < produtos.Count)
            {
                produtos[id].AdicionarSaida();
                Salvar();
            }
        }



    }
}