using System.ComponentModel;

namespace Projeto_Calculadora
{
    internal class Program
    {

        enum Menu { Soma = 1, Subtração, Divisão, Multiplicação, Potência, Raiz, Sair };

        static void Main(string[] args)
        {
            bool sair = false;
            do
            {
                Console.WriteLine("======== CALCULADORA ========");
                Console.WriteLine("Escolha uma das opções abaixo:");
                Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Potência\n6 - Raiz\n7 - Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtração:
                        Sub();
                        break;
                    case Menu.Divisão:
                        Div();
                        break;
                    case Menu.Multiplicação:
                        Mult();
                        break;
                    case Menu.Potência:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        sair = true;
                        break;
                }

                Console.Clear();

            } while (sair == false);
        }

                static void Soma()
                {
                    Console.WriteLine("====== Soma entre numeros ======");
                    Console.WriteLine("Deseja somar quantos números? ");
                    int qntd = int.Parse(Console.ReadLine());

                    int[] numeros = new int[qntd];
                    int soma = 0;

                    for (int i = 0; i < qntd; i++)
                    {
                        Console.Write($"Digite o {i + 1} número: ");
                        numeros[i] = int.Parse(Console.ReadLine());

                        soma = soma + numeros[i];
                    }

                    Console.WriteLine($"A soma dos números é igual a {soma}");
                    Console.WriteLine("Aperte ENTER para voltar ao menu");
                    Console.ReadLine();
                }

                static void Sub()
                {

                    Console.WriteLine("====== Subtração entre numeros ======");
                    Console.WriteLine("Deseja subtrair quantos números? ");
                    int qntd = int.Parse(Console.ReadLine());

                    int[] numeros = new int[qntd];

                    for (int i = 0; i < qntd; i++)
                    {
                        Console.Write($"Digite o {i + 1} número: ");
                        numeros[i] = int.Parse(Console.ReadLine());
                    }

                    int resultado = numeros[0];

                    for (int i = 1; i < numeros.Length; i++)
                    {
                        resultado -= numeros[i];
                    }

                    Console.WriteLine($"A subtração dos números é igual a {resultado}");
                    Console.WriteLine("Aperte ENTER para voltar ao menu");
                    Console.ReadLine();
                }

                static void Div()
                {
                    Console.WriteLine("====== Divisão entre numeros ======");
                    Console.WriteLine("Deseja dividir quantos números? ");
                    int qntd = int.Parse(Console.ReadLine());

                    float[] numeros = new float[qntd];

                    for (int i = 0; i < qntd; i++)
                    {
                        Console.Write($"Digite o {i + 1} número: ");
                        numeros[i] = float.Parse(Console.ReadLine());
                    }

                    float resultado = numeros[0];

                    for (int i = 1; i < numeros.Length; i++)
                    {
                        if (numeros[i] == 0)
                        {
                            Console.WriteLine("Não é possível dividir por zero!");
                            Console.ReadLine();
                            return;
                        }

                        resultado /= numeros[i];
                    }

                    Console.WriteLine($"A divisão dos números é igual a {resultado}");
                    Console.WriteLine("Aperte ENTER para voltar ao menu");
                    Console.ReadLine();
                }

                static void Mult()
                {
                    Console.WriteLine("====== Multiplicação entre numeros ======");
                    Console.WriteLine("Deseja multiplicar quantos números? ");
                    int qntd = int.Parse(Console.ReadLine());

                    int[] numeros = new int[qntd];
                    int resultado = 1;

                    for (int i = 0; i < qntd; i++)
                    {
                        Console.Write($"Digite o {i + 1} número: ");
                        numeros[i] = int.Parse(Console.ReadLine());

                        resultado = resultado * numeros[i];
                    }

                    Console.WriteLine($"A multiplicação dos números é igual a {resultado}");
                    Console.WriteLine("Aperte ENTER para voltar ao menu");
                    Console.ReadLine();
                }

                static void Pot()
                {
                    Console.WriteLine("====== Potência de um número ======");
                    Console.Write("Digite a base: ");
                    int Base = int.Parse(Console.ReadLine());
                    Console.Write("Digite o expoente: ");
                    int expoente = int.Parse(Console.ReadLine());

                    int resultado = (int)Math.Pow(Base, expoente);
                    Console.WriteLine($"O resultado da potência desse número é igual a {resultado}");
                    Console.WriteLine("Aperte ENTER para voltar ao menu");
                    Console.ReadLine();
                }

                static void Raiz()
                {
                    Console.WriteLine("====== Raiz quadrada de um número ======");
                    Console.Write("Digite um número: ");
                    int numero = int.Parse(Console.ReadLine());

                    double resultado = Math.Sqrt(numero);
                    Console.WriteLine($"O resultado da raiz quadrada desse número é {resultado}");
                    Console.WriteLine("Aperte ENTER para voltar ao menu");
                    Console.ReadLine();
                }
    }
}

