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
        /// <summary>
        /// Encontra o nó no grafo
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
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
            nF.AddEdge(nT, cost);
        }

        /// <summary>
        /// Remove o arco entre dois nós
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
       public void RemoveEdge(string from, string to)
        {
            Node nF, nT;
            nF = Find(from);
            nT = Find(to);
            nF.RemoveEdge(nT);
        }

        /// <summary>
        /// Calcula o tempo gasto para executar as tarefas a partir da tarefa inicial
        /// </summary>
        /// <param name="from">Tarefa inicial.</param>
        /// <returns></returns>
        public double CalculaTempoGasto(string from)
        {
            double tempo = 0;
            List<Node> paseio = BreadthFirstSearch(from);
            foreach(Node n in paseio)
            {
                tempo += n.Tempo;
            }
            ClearVisited();
            return tempo;
        }

        /// <summary>
        /// Calcula a prioridade total
        /// </summary>
        /// <param name="from">Tarefa inicial.</param>
        /// <returns></returns>
        public double CalculaPrioridade(string from)
        {
            double prioridade = 0;
            List<Node> paseio = BreadthFirstSearch(from);
            foreach (Node n in paseio)
            {
                prioridade += n.priority;
            }
            ClearVisited();
            return prioridade;
        }

        /// <summary>
        /// Ordena todos os nós pela prioridade em ordem decrescente
        /// </summary>
        /// <returns></returns>
        public List<Node> OrdenaPrioridade()
        {
            List<Node> ordem = this.nodes.OrderByDescending(o => o.priority).ToList();
            return ordem;
        }

        /// <summary>
        /// Ordena os nós pelo tempo em ordem decrescente
        /// </summary>
        /// <returns></returns>
        public List<Node> OrdenaTempo()
        {
            List<Node> ordem = this.nodes.OrderByDescending(o => o.Tempo).ToList();
            return ordem;
        }

        /// <summary>
        /// Calculo o tempo gasto de varias tarefas ou uma.
        /// </summary>
        /// <param name="from"></param>
        /// <returns></returns>
        public double CalculaTempoGasto(string[] from)
        {
            double tempo = 0;
            foreach (String s in from) {
                List<Node> paseio = BreadthFirstSearch(s);
                foreach (Node n in paseio)
                {
                    tempo += n.Tempo;
                }
                ClearVisited();
            }
            
            return tempo;
        }
        /// <summary>
        /// Limpa os nós que foram visitados
        /// </summary>
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
        /// Adiciona o requisito para execução de uma tarefa(nó)
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public void AddRequisito(string from, string to)
        {
            Node n = Find(to);
            n.requisito.Add(from);
        }
        /// <summary>
        /// Remove o requisito de execução da tarefa
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public void RemoveRequisito(string from, string to)
        {
            Node n = Find(to);
            n.requisito.Remove(from);
        }
        #endregion

        #region Caminhos

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
                n = fila.Dequeue();
                foreach (Edge e in n.Edges)
                {
                    if (e.To.Visited != true)
                    {
                        fila.Enqueue(e.To);
                        e.To.Visited = true;
                    }
                }
                l.Add(n);
            }
            return l;
        }
        #endregion
        #endregion

    }
}
