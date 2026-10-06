namespace Enum___Switch__menu_
{
    internal class Program
    {

        enum opcao { Criar = 1, Deletar, Editar };

        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma das opções aaixo:");
            Console.WriteLine("1 - Criar\n2 - Deletar\n3 - Editar");

            int indice = int.Parse(Console.ReadLine());
            opcao opcaoselecionada = (opcao)indice;

            switch (opcaoselecionada)
            {
                case opcao.Criar:
                    Console.WriteLine("Você quer criar algo!");
                    break;
                case opcao.Deletar:
                    Console.WriteLine("Você quer deletar algo!");
                    break;
                case opcao.Editar:
                    Console.WriteLine("Você quer editar algo!");
                    break;
                default:
                    Console.WriteLine("Opção não encontrada!");
                    break;
            }
        }
    }
}
