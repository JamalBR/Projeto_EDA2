using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEDA2.Classes
{
    /// <summary>
    /// Fila de prioridade para usar na busca A*.
    /// </summary>
    class PriorityQueue : LinkedList<NodeBusca>
    {
        /// <summary>
        /// Remove um nó da fila.
        /// </summary>
        /// <returns></returns>
        public NodeBusca Dequeue()
        {
            NodeBusca n = this.First.Value;
            this.RemoveFirst();
            return n;
        }

        /// <summary>
        /// Adiciona um nó na fila.
        /// </summary>
        /// <param name="n"></param>
        public void Enqueue(NodeBusca item)
        {
            LinkedListNode<NodeBusca> node = this.First;
            while (node != null)
            {
                if (item.eval < node.Value.eval)
                {
                    this.AddBefore(node, item);
                    break;
                }
                node = node.Next;
            }
            if (node == null)
            {
                this.AddLast(item);
            }
        }
    }
}
