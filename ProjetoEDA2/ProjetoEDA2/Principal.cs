using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Glee = Microsoft.Glee.Drawing;
using GleeUI = Microsoft.Glee.GraphViewerGdi;
using EDA = ProjetoEDA2.Classes;

namespace ProjetoEDA2
{
    /// <summary>
    /// Classe que representa o form principal da aplicação.
    /// </summary>
    public partial class Principal : Form
    {

        #region Atributos

        /// <summary>
        /// Instância do grafo a ser utilizada no formulário.
        /// </summary>
        private EDA.Graph graph;

        #endregion

        #region Construtores

        /// <summary>
        /// Cria nova instância do form principal.
        /// </summary>
        public Principal()
        {
            InitializeComponent();
            this.graph = new EDA.Graph();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Atribui aos controles o conteúdo do grafo.
        /// </summary>
        private void SetGraphControls(bool drawGraph = true)
        {
            List<EDA.Edge> edges = new List<EDA.Edge>();
            EDA.Node[] nodes = this.graph.Nodes;
            // Limpa controles..
            txtNodeName.Clear();
            txtTempoTarefa.Clear();
            cmbNodeFrom.Items.Clear();
            cmbNodeTo.Items.Clear();
            cmbNodeCalc.Items.Clear();
            lstArcs.Items.Clear();
            // Carrega nós e agrupa arcos..
            foreach (EDA.Node node in nodes)
            {
                edges.AddRange(node.Edges);
                // Adiciona nós ao combo..
                cmbNodeFrom.Items.Add(node);
                cmbNodeTo.Items.Add(node);
                cmbNodeCalc.Items.Add(node);
            }
            // Adiciona os arcos ao listbox..
            foreach (EDA.Edge edge in edges)
            {
                lstArcs.Items.Add(edge);
            }
            if (drawGraph)
            {
                DrawGraph(null);
            }
        }

        /// <summary>
        /// Desenha o grafo atual.
        /// </summary>
        private void DrawGraph(EDA.Node[] highlightedNodes)
        {
            List<EDA.Edge> edges = new List<EDA.Edge>();
            Glee.Graph drawingGraph = new Glee.Graph("Grafo - EDA2");
            // Adiciona nós ao grafo..
            foreach (EDA.Node node in this.graph.Nodes)
            {
                Glee.Node drawingNode = drawingGraph.AddNode(node.Name);
                drawingNode.Attr.Shape = Glee.Shape.Box;
                if (highlightedNodes != null && Array.IndexOf(highlightedNodes, node) >= 0)
                {
                    drawingNode.Attr.Color = Glee.Color.Red;
                }
                // Consolida os arcos..
                edges.AddRange(node.Edges);
            }
            foreach (EDA.Edge edge in edges)
            {
                Glee.Edge drawingEdge = drawingGraph.AddEdge(edge.From.Name, edge.To.Name);
                drawingEdge.Attr.Label = String.Format("{0:F4}", edge.Cost);
            }
            // Gera controle de desenho..
            GleeUI.GViewer viewer = new GleeUI.GViewer();
            viewer.NavigationVisible = false;
            viewer.OutsideAreaBrush = Brushes.White;
            viewer.RemoveToolbar();
            viewer.Graph = drawingGraph;
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlGraph.Controls.Clear();
            pnlGraph.Controls.Add(viewer);
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Clique do botão AddNode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNode_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNodeName.Text.Trim()))
            {
                this.graph.AddNode(txtNodeName.Text);
                var n = this.graph.FindNode(txtNodeName.Text);
                if (txtTempoTarefa.Modified)
                    n.Tempo = Int32.Parse(txtTempoTarefa.Text);
                else
                    n.Tempo = 0;
            }
            SetGraphControls();
        }

        /// <summary>
        /// Clique do botão remover nó.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveNode_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNodeName.Text.Trim()))
            {
                this.graph.RemoveNode(txtNodeName.Text);
            }
            SetGraphControls();
        }

        /// <summary>
        /// Clique do botão adicionar arco.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddArc_Click(object sender, EventArgs e)
        {
            if (cmbNodeTo.SelectedItem != null && cmbNodeFrom.SelectedItem != null && !String.IsNullOrEmpty(txtCost.Text.Trim()))
            { 
                string nodeTo = (cmbNodeTo.SelectedItem as EDA.Node).Name;
                string nodeFrom = (cmbNodeFrom.SelectedItem as EDA.Node).Name;
                double cost = Double.Parse(txtCost.Text);
                // Adiciona arco..
                this.graph.AddEdge(nodeFrom, nodeTo, cost);
            }
            SetGraphControls();
        }

        /// <summary>
        /// Clique do botão que limpa arcos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveArcs_Click(object sender, EventArgs e)
        {
            // Adiciona nós ao grafo..
            foreach (EDA.Node node in this.graph.Nodes)
            {
                node.Edges.Clear();
            }
            SetGraphControls();
        }

        /// <summary>
        /// Clique do botão de exibir vizinhos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowNeighbours_Click(object sender, EventArgs e)
        {
            if (cmbNodeCalc.SelectedItem != null)
            {
                string nodeFrom = (cmbNodeCalc.SelectedItem as EDA.Node).Name;
                /*EDA.Node[] neighbours = this.graph.GetNeighbours(nodeFrom);
                SetGraphControls(false);
                DrawGraph(neighbours);*/
                int tempo = this.graph.CalculaTempoGasto(nodeFrom);
                MessageBox.Show(tempo.ToString(), "Tempo Gasto", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Clique do botão de validar caminhos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowPath_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPath.Text.Trim()))
            {
                EDA.Node[] pathNodes = null;
                string[] path = txtPath.Text.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                // Verifica se o caminho existe..
                if (this.graph.IsValidPath(ref pathNodes, path))
                {
                    MessageBox.Show("O caminho é válido", "Validação de Caminho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O caminho é inválido", "Validação de Caminho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SetGraphControls(false);
                DrawGraph(pathNodes);
            }
        }

        #endregion

        private void gbOperations_Enter(object sender, EventArgs e)
        {

        }
    }
}
