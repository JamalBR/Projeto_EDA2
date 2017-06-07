using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEDA2.Classes
{
    public class BuscaCega : Graph
    {
        private List<NodeBusca> nodesBusca;
        public BuscaCega()
        {
            nodesBusca = new List<NodeBusca>();
        }
        #region operações no grafo
        /// <summary>
        /// Adiciona um nó ao grafo de busca.
        /// </summary>
        /// <param name="name">O nome do nó a ser adicionado.</param>
        /// <param name="info">A informação a ser armazenada no nó.</param>
        public NodeBusca AddNodeBusca(string name)
        {
            return AddNodeBusca(name, null);
        }
        /// <summary>
        /// Adiciona um nó ao grafo de busca e adiciona o tempo.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tempo"></param>
        /// <returns></returns>
        public NodeBusca AddNodeBusca(string name, double tempo)
        {
            NodeBusca nb = AddNodeBusca(name, null);
            nb.Tempo = tempo;
            return nb;
        }

        /// <summary>
        /// Adiciona um nó ao grafo de busca.
        /// </summary>
        /// <param name="name">O nome do nó a ser adicionado.</param>
        /// <param name="info">A informação a ser armazenada no nó.</param>
        public NodeBusca AddNodeBusca(string name, object info)
        {
            NodeBusca node = new NodeBusca(name, info);
            this.nodesBusca.Add(node);
            return node;
        }
        #endregion

        /// <summary>
        /// busca que verifica o maior numero de tarefas q podem ser executadas em um certo tempo
        /// </summary>
        /// <param name="tempo"></param>
        /// <param name="tarefas"></param>
        /// <returns></returns>
        public string Solucao(double tempo, Graph tarefas)
        {
            BuscaCega tree = new BuscaCega();
            Queue<NodeBusca> fila = new Queue<NodeBusca>();
            NodeBusca nd = tree.AddNodeBusca("Start",0);
            string resp = null;
            int aux = 0;
            nd.tempoTotal = 0;
            fila.Enqueue(nd);
            while (fila.Count > 0)
            {
                nd = fila.Dequeue();
                nd.tempoTotal += nd.Tempo;
                if (nd.Tarefas == null)
                {
                    if(nd.Name != "Start")
                        nd.Tarefas = nd.Name;
                }   
                else if(nd.Name!="Start")
                    nd.Tarefas += "-"+nd.Name;
                if (nd.tempoTotal == tempo)
                {
                    if(nd.Tarefas.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).Count<string>() > aux)
                        resp = nd.Tarefas;
                }
                else if(nd.tempoTotal < tempo)
                {
                    if(nd.Tarefas != null)
                        if (nd.Tarefas.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).Count<string>() > aux)
                            resp = nd.Tarefas;
                    List<Node> next = ProximoEstado(nd, tarefas);
                    foreach (Node n in next)
                    {
                        NodeBusca nb = tree.AddNodeBusca(n.Name, n.Tempo);
                        nb.tempoTotal = nd.tempoTotal;
                        nb.Tarefas = nd.Tarefas;
                        nd.AddEdge(nb, 0);
                        fila.Enqueue(nb);
                    }
                }
            }
            return resp;
        }
        /// <summary>
        /// encontra os proximos estados possiveis
        /// </summary>
        /// <param name="atual"></param>
        /// <param name="tarefas"></param>
        /// <returns></returns>
        public List<Node> ProximoEstado(NodeBusca atual, Graph tarefas)
        {
            List<Node> next = new List<Node>();
            foreach (Node n in tarefas.Nodes)
            {
                if (!n.Visited)
                {
                    if (atual.Tarefas != null)
                    {
                        if (!Existe(n.Name, atual))
                        {
                            if (n.requisito.Count == 0)
                            {
                                next.Add(n);
                            }
                            else if (TemRequisito(n, atual))
                            {
                                next.Add(n);
                            }
                        }
                    }
                    else if (n.requisito.Count == 0)
                    {
                        next.Add(n);
                    }
                }
            }
            return next;
        }
        /// <summary>
        /// verifica se os requisitos para executar a tarefa são atendidos
        /// </summary>
        /// <param name="n"></param>
        /// <param name="nb"></param>
        /// <returns></returns>
        public bool TemRequisito(Node n, NodeBusca nb)
        {
            int aux = 0;
            string[] tarefas = nb.Tarefas.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var r in n.requisito)
            {
                foreach(string s in tarefas)
                {
                    if (r == s)
                    {
                        aux++;
                        break;
                    }
                }
            }
            if(n.requisito.Count == aux)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// verifica se a tarefa ja foi executa naquele ramo da arvore
        /// </summary>
        /// <param name="name"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool Existe(string name, NodeBusca n)
        {
            string[] Ntarefa = n.Tarefas.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in Ntarefa)
            {
                if (name == s)
                {
                    return true;
                }
            }
            return false;
        }

       

    }
}
