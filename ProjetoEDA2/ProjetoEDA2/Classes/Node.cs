using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEDA2.Classes
{
    /// <summary>
    /// Classe que representa um nó dentro de um grafo.
    /// </summary>
    public class Node
    {

        #region Propriedades
        /// <summary>
        /// euristica
        /// </summary>
        public double eval { get; set; }
        /// <summary>
        /// O nome do nó dentro do grafo.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// A informação adicional armazenada no nó.
        /// </summary>
        public object Info { get; set; }
        /// <summary>
        /// A lista de arcos associada ao nó.
        /// </summary>
        public List<Edge> Edges { get; private set; }
        /// <summary>
        /// Indica se o nó foi visitado.
        /// </summary>
        public bool Visited { get; set; }
        /// <summary>
        /// A prioridade de execução da tarefa
        /// </summary>
        public int priority { get; set; }
        /// <summary>
        /// Tempo para a tarefa ser executada
        /// </summary>
        public double Tempo { get; set; }

        public List<String> requisito { get; set; }

        #endregion

        #region Construtores

        /// <summary>
        /// Cria um novo nó.
        /// </summary>
        public Node()
        {
            this.Edges = new List<Edge>();
            this.requisito = new List<string>();
        }

        /// <summary>
        /// Cria um novo nó.
        /// </summary>
        /// <param name="name">O nome do nó.</param>
        /// <param name="info">A informação armazenada no nó.</param>
        public Node(string name, object info) : this()
        {
            this.Name = name;
            this.Info = info;
        }

        public Node(string name, object info, int priority) : this()
        {
            this.Name = name;
            this.Info = info;
            this.priority = priority;

        }
        #endregion

        #region Métodos

        /// <summary>
        /// Adiciona um arco com nó origem igual ao nó atual, e destino e custo de acordo com os parâmetros.
        /// </summary>
        /// <param name="to">O nó destino.</param>
        public void AddEdge(Node to)
        {
            AddEdge(to, 0);
        }

        /// <summary>
        /// Adiciona um arco com nó origem igual ao nó atual, e destino e custo de acordo com os parâmetros.
        /// </summary>
        /// <param name="to">O nó destino.</param>
        /// <param name="cost">O custo associado ao arco.</param>
        public void AddEdge(Node to, double cost)
        {
            Edge edge = new Edge(this, to, cost);
            Edges.Add(edge);
        }
        /// <summary>
        /// Remove o arco com origem igual ao nó atual 
        /// </summary>
        /// <param name="to"></param>
        public void RemoveEdge(Node to)
        {
            Edge edge = new Edge(this, to, 0);
            foreach(Edge e in Edges)
            {
                if(e.ToString() == edge.ToString())
                {
                    Edges.Remove(e);
                    break;
                }
            }
        }

        #endregion

        #region Métodos Sobrescritos

        /// <summary>
        /// Apresenta a visualização do objeto em formato texto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (this.Info != null)
            {
                return String.Format("{0}({1})", this.Name, this.Info);
            }
            return this.Name;
        }

        #endregion

    }
}
