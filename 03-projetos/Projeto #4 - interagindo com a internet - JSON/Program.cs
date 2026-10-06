using System.Net;
using Newtonsoft.Json;

namespace interagindo_com_a_internet___JSON
{
    internal class Program
    {


        static void Main(string[] args)
        {

            ReqUnica();

            Console.WriteLine("*************************************************");

            ReqTodos();
            
        }

      
        static void ReqTodos()
        {
            var requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos/");      // faz requisição e recebe resposta
            requisicao.Method = "GET";

            var resposta = requisicao.GetResponse();

            using (resposta)                                                                    // mandar coxeção à internet e receber resposta
            {
                var stream = resposta.GetResponseStream();                                      // resposta em stream (decodificar)
                StreamReader leitor = new StreamReader(stream);                                 // coloca no leitor   
                object dados = leitor.ReadToEnd();                                              // passa para a variavel

                // Console.WriteLine(dados.ToString());                                                     // converter para string e exibe  no console
                List<Tarefa> tarefas = JsonConvert.DeserializeObject<List<Tarefa>>(dados.ToString());      // transformma em dados C# para exibir depois no foreach


                foreach (Tarefa tarefa in tarefas)
                {
                    tarefa.Exibir();
                }
                stream.Close();                                                                 // fecha stream e using
                resposta.Close();
            }
        }

        // desse modo eles ficam como dados de C#, e nao apenas como string (como seria do modo que está comentado)



        static void ReqUnica()
        {

            var requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos/49");          // pega um id especifico no fim do link
            requisicao.Method = "GET";

            var resposta = requisicao.GetResponse();

            using (resposta)
            {
                var stream = resposta.GetResponseStream();
                StreamReader leitor = new StreamReader(stream);
                object dados = leitor.ReadToEnd();

                // Console.WriteLine(dados.ToString());                                        
                Tarefa tarefa = JsonConvert.DeserializeObject<Tarefa>(dados.ToString());                 // não cria uma lista, já que é apenas uma tarefa e não todas

                tarefa.Exibir();
                stream.Close();
                resposta.Close();

            }
        }


    }
}
