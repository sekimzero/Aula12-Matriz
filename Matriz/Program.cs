using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz

{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            ToDo listaDeTarefas = new ToDo();

            listaDeTarefas.ListarTarefa();
            Console.WriteLine("Adicione um item:");
            string novoItem = Console.ReadLine();
            listaDeTarefas.AdicionarTarefa(novoItem);
            listaDeTarefas.ListarTarefa();

            Console.WriteLine("Remova um item:");
            string removaItem = Console.ReadLine();
            listaDeTarefas.RemoverTarefa(removaItem);

            Console.WriteLine("Qual o indice?:");
            int novoIndice = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o novo item?:");
            string novoValor = Console.ReadLine();
            listaDeTarefas.AtualizarTarefa(novoIndice, novoValor);

          
        }
    }
}



