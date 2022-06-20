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


            listaDeTarefas.ListarTarefa();
            Console.WriteLine("Adicione um item:");
            string novoItem = Console.ReadLine();
            listaDeTarefas.AdicionarTarefa(novoItem);
            listaDeTarefas.ListarTarefa();

            Console.WriteLine("Remova um item:");
            string removaItem = Console.ReadLine();
            listaDeTarefas.RemoverTarefa(removaItem);
            listaDeTarefas.ListarTarefa();

            Console.WriteLine("Qual a posição da tarefa que você deseja modificar?");
            int novoIndice = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o novo item?:");
            string novoValor = Console.ReadLine();
            listaDeTarefas.AtualizarTarefa(novoIndice, novoValor);
            listaDeTarefas.ListarTarefa();


        }
    }
}



