namespace ProjetoEDA2
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.gbGraph = new System.Windows.Forms.GroupBox();
            this.btnRemoveArcs = new System.Windows.Forms.Button();
            this.lstArcs = new System.Windows.Forms.ListBox();
            this.btnAddArc = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblEdge = new System.Windows.Forms.Label();
            this.cmbNodeFrom = new System.Windows.Forms.ComboBox();
            this.cmbNodeTo = new System.Windows.Forms.ComboBox();
            this.btnRemoveNode = new System.Windows.Forms.Button();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.txtNodeName = new System.Windows.Forms.TextBox();
            this.lblNodeName = new System.Windows.Forms.Label();
            this.gbOperations = new System.Windows.Forms.GroupBox();
            this.btnShowPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnShowNeighbours = new System.Windows.Forms.Button();
            this.cmbNodeCalc = new System.Windows.Forms.ComboBox();
            this.lblNoodeNeighbourhood = new System.Windows.Forms.Label();
            this.txtTempoTarefa = new System.Windows.Forms.TextBox();
            this.lblTempoTarefa = new System.Windows.Forms.Label();
            this.gbGraph.SuspendLayout();
            this.gbOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGraph
            // 
            this.pnlGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraph.Location = new System.Drawing.Point(322, 12);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(728, 418);
            this.pnlGraph.TabIndex = 0;
            // 
            // gbGraph
            // 
            this.gbGraph.Controls.Add(this.lblTempoTarefa);
            this.gbGraph.Controls.Add(this.txtTempoTarefa);
            this.gbGraph.Controls.Add(this.btnRemoveArcs);
            this.gbGraph.Controls.Add(this.lstArcs);
            this.gbGraph.Controls.Add(this.btnAddArc);
            this.gbGraph.Controls.Add(this.txtCost);
            this.gbGraph.Controls.Add(this.lblEdge);
            this.gbGraph.Controls.Add(this.cmbNodeFrom);
            this.gbGraph.Controls.Add(this.cmbNodeTo);
            this.gbGraph.Controls.Add(this.btnRemoveNode);
            this.gbGraph.Controls.Add(this.btnAddNode);
            this.gbGraph.Controls.Add(this.txtNodeName);
            this.gbGraph.Controls.Add(this.lblNodeName);
            this.gbGraph.Location = new System.Drawing.Point(12, 6);
            this.gbGraph.Name = "gbGraph";
            this.gbGraph.Size = new System.Drawing.Size(304, 288);
            this.gbGraph.TabIndex = 1;
            this.gbGraph.TabStop = false;
            this.gbGraph.Text = "Tarefas";
            // 
            // btnRemoveArcs
            // 
            this.btnRemoveArcs.Location = new System.Drawing.Point(202, 259);
            this.btnRemoveArcs.Name = "btnRemoveArcs";
            this.btnRemoveArcs.Size = new System.Drawing.Size(96, 23);
            this.btnRemoveArcs.TabIndex = 10;
            this.btnRemoveArcs.Text = "Limpar Arcos";
            this.btnRemoveArcs.UseVisualStyleBackColor = true;
            this.btnRemoveArcs.Click += new System.EventHandler(this.btnRemoveArcs_Click);
            // 
            // lstArcs
            // 
            this.lstArcs.FormattingEnabled = true;
            this.lstArcs.Location = new System.Drawing.Point(47, 132);
            this.lstArcs.Name = "lstArcs";
            this.lstArcs.Size = new System.Drawing.Size(251, 121);
            this.lstArcs.TabIndex = 9;
            // 
            // btnAddArc
            // 
            this.btnAddArc.Location = new System.Drawing.Point(266, 103);
            this.btnAddArc.Name = "btnAddArc";
            this.btnAddArc.Size = new System.Drawing.Size(32, 23);
            this.btnAddArc.TabIndex = 8;
            this.btnAddArc.Text = "+";
            this.btnAddArc.UseVisualStyleBackColor = true;
            this.btnAddArc.Click += new System.EventHandler(this.btnAddArc_Click);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(202, 106);
            this.txtCost.MaxLength = 5;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(58, 20);
            this.txtCost.TabIndex = 7;
            // 
            // lblEdge
            // 
            this.lblEdge.AutoSize = true;
            this.lblEdge.Location = new System.Drawing.Point(1, 109);
            this.lblEdge.Name = "lblEdge";
            this.lblEdge.Size = new System.Drawing.Size(40, 13);
            this.lblEdge.TabIndex = 6;
            this.lblEdge.Text = "Aresta:";
            // 
            // cmbNodeFrom
            // 
            this.cmbNodeFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNodeFrom.FormattingEnabled = true;
            this.cmbNodeFrom.Location = new System.Drawing.Point(47, 105);
            this.cmbNodeFrom.Name = "cmbNodeFrom";
            this.cmbNodeFrom.Size = new System.Drawing.Size(69, 21);
            this.cmbNodeFrom.TabIndex = 5;
            // 
            // cmbNodeTo
            // 
            this.cmbNodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNodeTo.FormattingEnabled = true;
            this.cmbNodeTo.Location = new System.Drawing.Point(122, 105);
            this.cmbNodeTo.Name = "cmbNodeTo";
            this.cmbNodeTo.Size = new System.Drawing.Size(69, 21);
            this.cmbNodeTo.TabIndex = 4;
            // 
            // btnRemoveNode
            // 
            this.btnRemoveNode.Location = new System.Drawing.Point(228, 41);
            this.btnRemoveNode.Name = "btnRemoveNode";
            this.btnRemoveNode.Size = new System.Drawing.Size(32, 23);
            this.btnRemoveNode.TabIndex = 3;
            this.btnRemoveNode.Text = "-";
            this.btnRemoveNode.UseVisualStyleBackColor = true;
            this.btnRemoveNode.Click += new System.EventHandler(this.btnRemoveNode_Click);
            // 
            // btnAddNode
            // 
            this.btnAddNode.Location = new System.Drawing.Point(190, 41);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(32, 23);
            this.btnAddNode.TabIndex = 2;
            this.btnAddNode.Text = "+";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // txtNodeName
            // 
            this.txtNodeName.Location = new System.Drawing.Point(47, 44);
            this.txtNodeName.MaxLength = 8;
            this.txtNodeName.Name = "txtNodeName";
            this.txtNodeName.Size = new System.Drawing.Size(58, 20);
            this.txtNodeName.TabIndex = 1;
            // 
            // lblNodeName
            // 
            this.lblNodeName.AutoSize = true;
            this.lblNodeName.Location = new System.Drawing.Point(44, 28);
            this.lblNodeName.Name = "lblNodeName";
            this.lblNodeName.Size = new System.Drawing.Size(41, 13);
            this.lblNodeName.TabIndex = 0;
            this.lblNodeName.Text = "Tarefa:";
            // 
            // gbOperations
            // 
            this.gbOperations.Controls.Add(this.btnShowPath);
            this.gbOperations.Controls.Add(this.txtPath);
            this.gbOperations.Controls.Add(this.lblPath);
            this.gbOperations.Controls.Add(this.btnShowNeighbours);
            this.gbOperations.Controls.Add(this.cmbNodeCalc);
            this.gbOperations.Controls.Add(this.lblNoodeNeighbourhood);
            this.gbOperations.Location = new System.Drawing.Point(12, 300);
            this.gbOperations.Name = "gbOperations";
            this.gbOperations.Size = new System.Drawing.Size(304, 130);
            this.gbOperations.TabIndex = 2;
            this.gbOperations.TabStop = false;
            this.gbOperations.Text = "Operações";
            this.gbOperations.Enter += new System.EventHandler(this.gbOperations_Enter);
            // 
            // btnShowPath
            // 
            this.btnShowPath.Location = new System.Drawing.Point(202, 86);
            this.btnShowPath.Name = "btnShowPath";
            this.btnShowPath.Size = new System.Drawing.Size(96, 23);
            this.btnShowPath.TabIndex = 15;
            this.btnShowPath.Text = "Validar Caminho";
            this.btnShowPath.UseVisualStyleBackColor = true;
            this.btnShowPath.Click += new System.EventHandler(this.btnShowPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(47, 60);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(251, 20);
            this.txtPath.TabIndex = 14;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 63);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 13);
            this.lblPath.TabIndex = 13;
            this.lblPath.Text = "Nós:";
            // 
            // btnShowNeighbours
            // 
            this.btnShowNeighbours.Location = new System.Drawing.Point(122, 24);
            this.btnShowNeighbours.Name = "btnShowNeighbours";
            this.btnShowNeighbours.Size = new System.Drawing.Size(176, 23);
            this.btnShowNeighbours.TabIndex = 12;
            this.btnShowNeighbours.Text = "Tempo Gasto";
            this.btnShowNeighbours.UseVisualStyleBackColor = true;
            this.btnShowNeighbours.Click += new System.EventHandler(this.btnShowNeighbours_Click);
            // 
            // cmbNodeCalc
            // 
            this.cmbNodeCalc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNodeCalc.FormattingEnabled = true;
            this.cmbNodeCalc.Location = new System.Drawing.Point(47, 25);
            this.cmbNodeCalc.Name = "cmbNodeCalc";
            this.cmbNodeCalc.Size = new System.Drawing.Size(69, 21);
            this.cmbNodeCalc.TabIndex = 11;
            // 
            // lblNoodeNeighbourhood
            // 
            this.lblNoodeNeighbourhood.AutoSize = true;
            this.lblNoodeNeighbourhood.Location = new System.Drawing.Point(6, 28);
            this.lblNoodeNeighbourhood.Name = "lblNoodeNeighbourhood";
            this.lblNoodeNeighbourhood.Size = new System.Drawing.Size(41, 13);
            this.lblNoodeNeighbourhood.TabIndex = 0;
            this.lblNoodeNeighbourhood.Text = "Tarefa:";
            // 
            // txtTempoTarefa
            // 
            this.txtTempoTarefa.Location = new System.Drawing.Point(122, 44);
            this.txtTempoTarefa.Name = "txtTempoTarefa";
            this.txtTempoTarefa.Size = new System.Drawing.Size(58, 20);
            this.txtTempoTarefa.TabIndex = 11;
            // 
            // lblTempoTarefa
            // 
            this.lblTempoTarefa.AutoSize = true;
            this.lblTempoTarefa.Location = new System.Drawing.Point(119, 28);
            this.lblTempoTarefa.Name = "lblTempoTarefa";
            this.lblTempoTarefa.Size = new System.Drawing.Size(43, 13);
            this.lblTempoTarefa.TabIndex = 12;
            this.lblTempoTarefa.Text = "Tempo:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 578);
            this.Controls.Add(this.gbOperations);
            this.Controls.Add(this.gbGraph);
            this.Controls.Add(this.pnlGraph);
            this.Name = "Principal";
            this.Text = "Projeto";
            this.gbGraph.ResumeLayout(false);
            this.gbGraph.PerformLayout();
            this.gbOperations.ResumeLayout(false);
            this.gbOperations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.GroupBox gbGraph;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.TextBox txtNodeName;
        private System.Windows.Forms.Label lblNodeName;
        private System.Windows.Forms.Button btnRemoveNode;
        private System.Windows.Forms.Button btnAddArc;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblEdge;
        private System.Windows.Forms.ComboBox cmbNodeFrom;
        private System.Windows.Forms.ComboBox cmbNodeTo;
        private System.Windows.Forms.Button btnRemoveArcs;
        private System.Windows.Forms.ListBox lstArcs;
        private System.Windows.Forms.GroupBox gbOperations;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnShowNeighbours;
        private System.Windows.Forms.ComboBox cmbNodeCalc;
        private System.Windows.Forms.Label lblNoodeNeighbourhood;
        private System.Windows.Forms.Button btnShowPath;
        private System.Windows.Forms.Label lblTempoTarefa;
        private System.Windows.Forms.TextBox txtTempoTarefa;
    }
}

