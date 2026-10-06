namespace Primeiro_em_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
         // coloca o nome da classe que voce quer usar

            Filme filme1 = new Filme();     // objeto
            filme1.nome = "V&F";         // consigo acessar pois é public
            filme1.Executar();           // consigo acessar pois é public


            Filme filme2 = new Filme();     // objeto
            filme2.nome = "spiderman";
            filme2.Executar();


            // exercicios do pdf abstração
            Produto_ecommerce_celular celular1 = new Produto_ecommerce_celular();
            celular1.marca = "apple";
            celular1.InformarMarca();

        }
    }
}