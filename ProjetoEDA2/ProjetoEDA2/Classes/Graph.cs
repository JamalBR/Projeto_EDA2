using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEDA2.Classes
{
    /// <summary>
    /// Classe que representa um grafo.
    /// </summary>
    public class Graph
    {

        #region Atributos

        /// <summary>
        /// Lista de nós que compõe o grafo.
        /// </summary>
        private List<Node> nodes;

        #endregion

        #region Propridades

        /// <summary>
        /// Mostra todos os nós do grafo.
        /// </summary>
        public Node[] Nodes
        {
            get { return this.nodes.ToArray(); }
        }

        #endregion

        #region Construtores

        /// <summary>
        /// Cria nova instância do grafo.
        /// </summary>
        public Graph()
        {
            this.nodes = new List<Node>();
        }

        #endregion

        #region Métodos

        #region OperaçõesGrafo

        public Node FindNode(string name)
        {
            return this.Find(name);
        }
        /// <summary>
        /// Encontra o nó através do seu nome.
        /// </summary>
        /// <param name="name">O nome do nó.</param>
        /// <returns>O nó encontrado ou nulo caso não encontre nada.</returns>
        private Node Find(string name)
        {
            foreach (Node n in nodes)
            {
                if (n.Name == name)
                {
                    return n;
                }
            }
            return null;
        }

        /// <summary>
        /// Adiciona um nó ao grafo.
        /// </summary>
        /// <param name="name">O nome do nó a ser adicionado.</param>
        /// <param name="info">A informação a ser armazenada no nó.</param>
        public void AddNode(string name)
        {
            AddNode(name, null);
        }

        /// <summary>
        /// Adiciona um nó ao grafo.
        /// </summary>
        /// <param name="name">O nome do nó a ser adicionado.</param>
        /// <param name="info">A informação a ser armazenada no nó.</param>
        public void AddNode(string name, object info)
        {
            Node node = new Node(name, info);
            nodes.Add(node);
        }

        /// <summary>
        /// Remove um nó do grafo.
        /// </summary>
        /// <param name="name">O nome do nó a ser removido.</param>
        public void RemoveNode(string name)
        {
            Node nr = Find(name);//encontra o nó a ser removido
            List<Edge> ed = new List<Edge>();//lista pra guardar os edges q vao ser removidos.
            //percorre tds os nós pra encontrar os edges que se ligam ao nó a ser removido e salva eles na lista ed.
            foreach (Node n in nodes)
            {
                foreach (Edge e in n.Edges)
                {

                    if (e.From == nr)
                    {
                        ed.Add(e);
                    }
                    if (e.To == nr)
                    {
                        ed.Add(e);
                    }
                }
            }
            //remove os edges dos nós necessarios.
            foreach (Node n in nodes)
            {
                foreach (Edge e in ed)
                {
                    n.Edges.Remove(e);
                }
            }
            nodes.Remove(nr);
        }

        /// <summary>
        /// Adiciona o arco entre dois nós associando determinado custo.
        /// </summary>
        /// <param name="from">O nó de origem.</param>
        /// <param name="to">O nó de destino.</param>
        /// <param name="cost">O cust associado.</param>
        public void AddEdge(string from, string to, double cost)
        {
            Node nF, nT;
            nF = Find(from);
            nT = Find(to);
            //Edge edge = new Edge(nF, nT, cost);
            nF.AddEdge(nT, cost);
        }

        /// <summary>
        /// Obtem todos os nós vizinhos de determinado nó.
        /// </summary>
        /// <param name="node">O nó origem.</param>
        /// <returns></returns>
        public Node[] GetNeighbours(string from)
        {
            Node n = Find(from);
            List<Node> vizinho = new List<Node>();
            foreach (Edge e in n.Edges)
            {
                vizinho.Add(e.To);
            }
            if (vizinho != null)
                return vizinho.ToArray();
            return null;
        }
        /// <summary>
        /// Calcula o tempo gasto para executar as tarefas a partir da tarefa inicial
        /// </summary>
        /// <param name="from">Tarefa inicial.</param>
        /// <returns></returns>
        public int CalculaTempoGasto(string from)
        {
            Node n = Find(from);
            int tempo = 0;
            Queue<Node> fila = new Queue<Node>();
            fila.Enqueue(n);
            n.Visited = true;
            while (fila.Count > 0)
            {
                foreach (Edge e in n.Edges)
                {
                    if (e.To != null)
                    {
                        if (e.To.Visited != true)
                        {

                            fila.Enqueue(e.To);
                            tempo += e.To.Tempo;
                            e.To.Visited = true;
                        }
                    }
                }
                n = fila.Dequeue();
            }
            ClearVisited();
            return tempo;
        }

        public void ClearVisited()
        {
            foreach(Node n in this.nodes)
            {
                if (n.Visited)
                {
                    n.Visited = false;
                }
            }
        }
        /// <summary>
        /// Valida um caminho, retornando a lista de nós pelos quais ele passou.
        /// </summary>
        /// <param name="nodes">A lista de nós por onde passou.</param>
        /// <param name="path">O nome de cada nó na ordem que devem ser encontrados.</param>
        /// <returns></returns>
        public bool IsValidPath(ref Node[] nodes, params string[] path)
        {
            bool contrl = false;
            Node n;
            for (int i = 0; i < path.Length - 1; i++)
            {
                n = Find(path[i]);
                contrl = false;
                foreach (Edge e in n.Edges)
                {
                    if (e.To.Name == path[i + 1])
                    {
                        contrl = true;
                    }
                }
                if (contrl == false)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Busca e Caminhos

        /// <summary>
        /// Executa o caminho em profundidade buscando o nó alvo.
        /// </summary>
        /// <param name="startNode">O nó inicio.</param>
        /// <returns>A lista de nós visitada.</returns>
        public List<Node> DepthFirstSearch(string startNode)
        {
            Stack<Node> pilha = new Stack<Node>();
            Node n = Find(startNode);
            List<Node> l = new List<Node>();
            pilha.Push(n);
            while (pilha.Count > 0)
            {
                foreach (Edge e in n.Edges)
                {
                    if (e.To.Visited != true)
                    {
                        pilha.Push(e.To);
                        e.To.Visited = true;
                    }
                }
                l.Add(n);
                n = pilha.Pop();
            }
            return l;
        }

        /// <summary>
        /// Executa o caminho em largura buscando o nó alvo.
        /// </summary>
        /// <param name="startNode">O nó inicio.</param>
        /// <returns>A lista de nós visitada.</returns>
        public List<Node> BreadthFirstSearch(string startNode)
        {
            Queue<Node> fila = new Queue<Node>();
            Node n = Find(startNode);
            List<Node> l = new List<Node>();
            fila.Enqueue(n);
            n.Visited = true;
            while (fila.Count > 0)
            {
                foreach (Edge e in n.Edges)
                {
                    if (e.To.Visited != true)
                    {
                        fila.Enqueue(e.To);
                        e.To.Visited = true;
                    }
                }
                l.Add(n);
                n = fila.Dequeue();
            }
            return l;
        }

        /// <summary>
        /// Executa o algoritmo de caminho mínimo (Djkistra) buscando o nó alvo.
        /// </summary>
        /// <param name="startNode">O nó inicio.</param>
        /// <param name="targetNode">O nó alvo.</param>
        /// <returns>A lista de nós visitada.</returns>
        public List<Node> ShortestPath(string startNode, string targetNode)
        {
            //algoritmo de Djkistra
            Graph solution = new Graph();
            Stack<Node> p = new Stack<Node>();
            this.Find(startNode).Visited = true;
            bool finished = false;

            solution.AddNode(startNode, 0);
            while (solution.Find(targetNode) == null && !finished)
            {
                double min = double.MaxValue, edgeCost = 0;//cria o min e atribui o maior valor de um double
                String from = null;
                String to = null;

                foreach (Node ns in solution.Nodes)
                {
                    Node no = this.Find(ns.Name);

                    foreach (Edge e in no.Edges)
                    {
                        if (!e.To.Visited)
                        {
                            double cost = e.Cost + Convert.ToDouble(ns.Info);
                            if (cost < min)
                            {
                                min = cost;
                                edgeCost = e.Cost;
                                from = e.From.Name;
                                to = e.To.Name;
                            }
                        }
                    }
                }
                if (from != null)
                {
                    solution.AddNode(to, min);
                    solution.AddEdge(to, from, edgeCost);
                    this.Find(to).Visited = true;
                }
                else
                {
                    finished = true;
                }
            }
            Node target = solution.Find(targetNode);
            if (target == null)
            {
                return null;
            }
            p.Push(target);
            while (target.Edges.Count > 0)
            {
                target = target.Edges[0].To;
                p.Push(target);
            }
            p.Push(target);

            return new List<Node>(p.ToArray());
        }
        #endregion
        #endregion

    }
}
