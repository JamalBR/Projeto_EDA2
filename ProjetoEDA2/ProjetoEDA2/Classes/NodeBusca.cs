using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEDA2.Classes
{
    public class NodeBusca : Node
    {
        #region Atributos
        /*/// <summary>
        /// Maquinas que podem executar as tarefas
        /// </summary>
        public Maquina[] maquinas { get; set; }*/
        /// <summary>
        /// Tempo gasto para executar as tarefas
        /// </summary>
        public double tempoTotal { get; set; }

        /// <summary>
        /// nome das tarefas já executadas
        /// </summary>
        public string Tarefas { get; set; }
        #endregion
        public NodeBusca(string name, object info)
        {
            this.Name = name;
            this.Info = info;
        }
    }
}
