using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    internal class ToDo
    { 
        List<string> Tarefas = new List<string>()
            {
                "Tomar banho",
                "Escovar os dentes"
            };
        public List<string> AdicionarTarefa(string novo)
        {   
            Tarefas.Add(novo);
            Console.WriteLine($"Novo item é: {novo}");
            return Tarefas;
        }
        public List<string> RemoverTarefa(string removerItem)
        {
            Tarefas.Remove(removerItem);
            return Tarefas;
        }
        public List<string> AtualizarTarefa(int indice, string novaTarefa)
        {
            Tarefas[indice] = novaTarefa;
            return Tarefas;
        }
        public void ListarTarefa()
        {
            Tarefas.ToList().ForEach(Console.WriteLine);
        }


    }

}

