using System.Runtime.Serialization.Formatters.Binary;

namespace manipulação_de_arquivos_binários
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream escrita = new FileStream("testeBinario.", FileMode.OpenOrCreate); 
            BinaryFormatter escrever = new BinaryFormatter();   

            escrever.Serialize(escrita, "deu certo");
            escrita.Close();

            // BinaryFormatter foi desativado do .NET
        }
    }
}
