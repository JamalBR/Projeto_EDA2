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
                //drawingEdge.Attr.Label = String.Format("{0:F4}", edge.Cost);
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
                if (!String.IsNullOrEmpty(txtPrioridadeTarefa.Text.Trim()))
                    n.priority = Int32.Parse(txtPrioridadeTarefa.Text);
                else
                    n.priority = 0;
                if (!String.IsNullOrEmpty(txtTempoTarefa.Text.Trim()))
                    n.Tempo = Double.Parse(txtTempoTarefa.Text);
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
            if (cmbNodeTo.SelectedItem != null && cmbNodeFrom.SelectedItem != null)
            { 
                string nodeTo = (cmbNodeTo.SelectedItem as EDA.Node).Name;
                string nodeFrom = (cmbNodeFrom.SelectedItem as EDA.Node).Name;
                if(nodeTo == nodeFrom)
                {
                    MessageBox.Show("Uma tarefa não pode depender dela mesma para iniciar","Erro ao adicionar dependência", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Adiciona arco e o requisito
                    this.graph.AddEdge(nodeFrom, nodeTo, 0);
                    this.graph.AddRequisito(nodeFrom, nodeTo);
                }
            }
            SetGraphControls();
        }
        /// <summary>
        /// clique do botão que remove um arco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveEdge_Click(object sender, EventArgs e)
        {
            if (cmbNodeTo.SelectedItem != null && cmbNodeFrom.SelectedItem != null)
            {
                string nodeTo = (cmbNodeTo.SelectedItem as EDA.Node).Name;
                string nodeFrom = (cmbNodeFrom.SelectedItem as EDA.Node).Name;
                //remove arco e requisito
                this.graph.RemoveEdge(nodeFrom, nodeTo);
                this.graph.RemoveRequisito(nodeFrom, nodeTo);
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
        /// Clique do botão de calcular o tempo gasto para executar todas as tarefas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTempoGasto_Click(object sender, EventArgs e)
        {
            if (cmbNodeCalc.SelectedItem != null)
            {
                string nodeFrom = (cmbNodeCalc.SelectedItem as EDA.Node).Name;
                var tempo = this.graph.CalculaTempoGasto(nodeFrom);
                MessageBox.Show(tempo.ToString(), "Tempo Gasto", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Clique do botão de calcular a soma da prioridade de todas as tarefas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ptotal_Click(object sender, EventArgs e)
        {
            if (cmbNodeCalc.SelectedItem != null)
            {
                string nodeFrom = (cmbNodeCalc.SelectedItem as EDA.Node).Name;
                var tempo = this.graph.CalculaPrioridade(nodeFrom);
                MessageBox.Show(tempo.ToString(), "Prioridade Total", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Clique do botão de Calcular tempo total de varias tarefas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTempoTotalVarios_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPath.Text.Trim()))
            {
                string[] path = txtPath.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (path != null)
                {
                    var v = this.graph.CalculaTempoGasto(path);
                    MessageBox.Show(v.ToString(), "Tempo Gasto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                SetGraphControls(false);
            }
        }
        /// <summary>
        /// clique do botão que ordena as tarefas por prioridade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrioridade_Click(object sender, EventArgs e)
        {
            lstTarefas.Items.Clear();
            List<EDA.Node> l = this.graph.OrdenaPrioridade();
            foreach (EDA.Node n in l)
            {
                lstTarefas.Items.Add(n.Name + "->" + n.priority);
            }
        }
        /// <summary>
        /// clique do botão que ordena as tarefas por tempo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTempo_Click(object sender, EventArgs e)
        {
            lstTarefas.Items.Clear();
            List<EDA.Node> l = this.graph.OrdenaTempo();
            foreach (EDA.Node n in l)
            {
                lstTarefas.Items.Add(n.Name + "->" + n.Tempo);
            }
        }
        /// <summary>
        /// clique do botão que executa a busca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExeBuscaCega_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTempoTotal.Text))
            {
                lstSequenciaTarefas.Items.Clear();
                var tempo = Double.Parse(txtTempoTotal.Text);
                EDA.BuscaCega b = new EDA.BuscaCega();
                var resp = b.Solucao(tempo, this.graph);
                lstSequenciaTarefas.Items.Add("Resposta: " + resp);
            }
            else
                MessageBox.Show("É necessario informar um tempo máximo", "Falha ao executar a busca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// clique do botão que executa a busca A*
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecAEstrela_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTempoTotal.Text))
            {
                lstSequenciaTarefas.Items.Clear();
                var tempo = Double.Parse(txtTempoTotal.Text);
                EDA.BuscaAEstrela b = new EDA.BuscaAEstrela();
                var resp = b.Solucao(tempo, this.graph);
                lstSequenciaTarefas.Items.Add("Resposta: " + resp);
            }
            else
                MessageBox.Show("É necessario informar um tempo máximo","Falha ao executar a busca",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btnPreDef1_Click(object sender, EventArgs e)
        {
            string[] nodes = { "T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "T9", "T10" };
            int aux = 0;
            foreach (string s in nodes)
            {
                aux += 1;
                this.graph.AddNode(s);
                var n = this.graph.FindNode(s);
                n.Tempo = aux;
            }
            SetGraphControls();
        }

        private void btnPreDef2_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void gbOperations_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
