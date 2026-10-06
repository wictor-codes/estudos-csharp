namespace herança
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.nome = "wictor";
            a.email = "wictor.com";
            a.senha = 123;
            a.turno = "matutino";
            a.Logar();
            a.Exibir();

            Console.WriteLine("=============");

            Zelador z = new Zelador();
            z.nome = "zé";
            z.email = "ze.com";
            z.senha = 321;
            z.Exibir();
            
        }
    }

}
