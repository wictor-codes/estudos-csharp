using System.Security.Cryptography.X509Certificates;

namespace static_e_não_static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TesteNaoStatic.Teste();                       // não roda, pois não tem static na função (precisa de um objeto)

            TesteNaoStatic queroVer = new TesteNaoStatic(); // cria objeto
            queroVer.Teste1();                              // agora consigo, por meio do objeto


            TesteComStatic.Teste2();                        // agora funcionou sem objeto, pois tem static no método
            TesteComStatic queroVer2 = new TesteComStatic();
            //queroVer2.Teste2();                           // não funciona com objeto


            Console.WriteLine(TesteNaoStatic.nome10);       // classe não static pode ter var static ou não, classe static só pode ter var static - deu certo
            Console.WriteLine(TesteComStatic.nome);         // relação var static com classe static - deu certo
            
        }
    }

    class TesteNaoStatic
    {
        static public string nome10 = "wictorC";
        public void Teste1()
        {
           Console.WriteLine("Teste sem static no método!");
        }
    }


    class TesteComStatic
    {
       static public string nome = "wictor";
       static public void Teste2()
       {
         Console.WriteLine("Teste com static no método!");
       }
    }
}
