using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEDA2.Classes
{
    class BuscaAEstrela : BuscaCega
    {
        public BuscaAEstrela()
        {
            
        }

        /// <summary>
        /// busca que verifica o maior numero de tarefas q podem ser executadas em um certo tempo
        /// </summary>
        /// <param name="tempo"></param>
        /// <param name="tarefas"></param>
        /// <returns></returns>
        public string Solucao(double tempo, Graph tarefas)
        {
            BuscaCega tree = new BuscaCega();


            PriorityQueue fila = new PriorityQueue();
            NodeBusca nd = tree.AddNodeBusca("Start", 0);
            string resp = null;
            int aux = 0;
            Node nt;
            nd.tempoTotal = 0;
            fila.Enqueue(nd);
            while (fila.Count > 0)
            {
                nd = fila.Dequeue();
                if (nd.Name != "Start")
                {
                    nt = tarefas.FindNode(nd.Name);
                    nt.Visited = true;
                }
                nd.tempoTotal += nd.Tempo;
                if (nd.Tarefas != null && nd.Tarefas.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).Count<string>() == tarefas.Nodes.Count())
                    return resp;
                if (nd.Tarefas == null)
                {
                    if (nd.Name != "Start")
                        nd.Tarefas = nd.Name;
                }
                else if (nd.Name != "Start")
                    nd.Tarefas += "-" + nd.Name;
               if (nd.tempoTotal == tempo)
                {
                    if (nd.Tarefas.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).Count<string>() > aux)
                       resp = nd.Tarefas;
                }
                else if (nd.tempoTotal < tempo)
                {
                    if (nd.Tarefas != null)
                        if (nd.Tarefas.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).Count<string>() > aux)
                            resp = nd.Tarefas;
                    List<Node> next = ProximoEstado(nd, tarefas);
                    foreach (Node n in next)
                    {
                        
                        NodeBusca nb = tree.AddNodeBusca(n.Name, n.Tempo);
                        nb.tempoTotal = nd.tempoTotal;
                        nb.Tarefas = nd.Tarefas;
                        nd.AddEdge(nb, 0);
                        nb.eval = euristica(n);
                        fila.Enqueue(nb);
                    }
                }
            }
            tarefas.ClearVisited();
            return resp;
        }


        public double euristica(Node n)
        {
            if (n.priority != 0)
                return n.Tempo / n.priority;
            else
                return n.Tempo;
        }


    }
}
