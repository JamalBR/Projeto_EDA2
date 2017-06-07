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
            this.btnRemoveEdge = new System.Windows.Forms.Button();
            this.lblPrioridadeTarefa = new System.Windows.Forms.Label();
            this.txtPrioridadeTarefa = new System.Windows.Forms.TextBox();
            this.lblTempoTarefa = new System.Windows.Forms.Label();
            this.txtTempoTarefa = new System.Windows.Forms.TextBox();
            this.btnRemoveArcs = new System.Windows.Forms.Button();
            this.lstArcs = new System.Windows.Forms.ListBox();
            this.btnAddArc = new System.Windows.Forms.Button();
            this.lblEdge = new System.Windows.Forms.Label();
            this.cmbNodeFrom = new System.Windows.Forms.ComboBox();
            this.cmbNodeTo = new System.Windows.Forms.ComboBox();
            this.btnRemoveNode = new System.Windows.Forms.Button();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.txtNodeName = new System.Windows.Forms.TextBox();
            this.lblNodeName = new System.Windows.Forms.Label();
            this.gbOperations = new System.Windows.Forms.GroupBox();
            this.Ptotal = new System.Windows.Forms.Button();
            this.btnTempoTotalVarios = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnTempoGasto = new System.Windows.Forms.Button();
            this.cmbNodeCalc = new System.Windows.Forms.ComboBox();
            this.lblNoodeNeighbourhood = new System.Windows.Forms.Label();
            this.lstTarefas = new System.Windows.Forms.ListBox();
            this.btnPrioridade = new System.Windows.Forms.Button();
            this.btnTempo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSequenciaTarefas = new System.Windows.Forms.ListBox();
            this.txtTempoTotal = new System.Windows.Forms.TextBox();
            this.lblMaxTaref = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExeBuscaCega = new System.Windows.Forms.Button();
            this.btnExecAEstrela = new System.Windows.Forms.Button();
            this.btnPreDef1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPreDef2 = new System.Windows.Forms.Button();
            this.lblCriarTarefas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbGraph.SuspendLayout();
            this.gbOperations.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.gbGraph.Controls.Add(this.label4);
            this.gbGraph.Controls.Add(this.lblCriarTarefas);
            this.gbGraph.Controls.Add(this.btnPreDef2);
            this.gbGraph.Controls.Add(this.btnPreDef1);
            this.gbGraph.Controls.Add(this.btnRemoveEdge);
            this.gbGraph.Controls.Add(this.lblPrioridadeTarefa);
            this.gbGraph.Controls.Add(this.txtPrioridadeTarefa);
            this.gbGraph.Controls.Add(this.lblTempoTarefa);
            this.gbGraph.Controls.Add(this.txtTempoTarefa);
            this.gbGraph.Controls.Add(this.btnRemoveArcs);
            this.gbGraph.Controls.Add(this.lstArcs);
            this.gbGraph.Controls.Add(this.btnAddArc);
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
            // btnRemoveEdge
            // 
            this.btnRemoveEdge.Location = new System.Drawing.Point(265, 101);
            this.btnRemoveEdge.Name = "btnRemoveEdge";
            this.btnRemoveEdge.Size = new System.Drawing.Size(33, 23);
            this.btnRemoveEdge.TabIndex = 15;
            this.btnRemoveEdge.Text = "-";
            this.btnRemoveEdge.UseVisualStyleBackColor = true;
            this.btnRemoveEdge.Click += new System.EventHandler(this.btnRemoveEdge_Click);
            // 
            // lblPrioridadeTarefa
            // 
            this.lblPrioridadeTarefa.AutoSize = true;
            this.lblPrioridadeTarefa.Location = new System.Drawing.Point(172, 28);
            this.lblPrioridadeTarefa.Name = "lblPrioridadeTarefa";
            this.lblPrioridadeTarefa.Size = new System.Drawing.Size(57, 13);
            this.lblPrioridadeTarefa.TabIndex = 14;
            this.lblPrioridadeTarefa.Text = "Prioridade:";
            // 
            // txtPrioridadeTarefa
            // 
            this.txtPrioridadeTarefa.Location = new System.Drawing.Point(175, 44);
            this.txtPrioridadeTarefa.Name = "txtPrioridadeTarefa";
            this.txtPrioridadeTarefa.Size = new System.Drawing.Size(58, 20);
            this.txtPrioridadeTarefa.TabIndex = 13;
            // 
            // lblTempoTarefa
            // 
            this.lblTempoTarefa.AutoSize = true;
            this.lblTempoTarefa.Location = new System.Drawing.Point(108, 28);
            this.lblTempoTarefa.Name = "lblTempoTarefa";
            this.lblTempoTarefa.Size = new System.Drawing.Size(43, 13);
            this.lblTempoTarefa.TabIndex = 12;
            this.lblTempoTarefa.Text = "Tempo:";
            // 
            // txtTempoTarefa
            // 
            this.txtTempoTarefa.Location = new System.Drawing.Point(111, 44);
            this.txtTempoTarefa.Name = "txtTempoTarefa";
            this.txtTempoTarefa.Size = new System.Drawing.Size(58, 20);
            this.txtTempoTarefa.TabIndex = 11;
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
            this.lstArcs.Location = new System.Drawing.Point(42, 128);
            this.lstArcs.Name = "lstArcs";
            this.lstArcs.Size = new System.Drawing.Size(251, 121);
            this.lstArcs.TabIndex = 9;
            // 
            // btnAddArc
            // 
            this.btnAddArc.Location = new System.Drawing.Point(227, 101);
            this.btnAddArc.Name = "btnAddArc";
            this.btnAddArc.Size = new System.Drawing.Size(32, 23);
            this.btnAddArc.TabIndex = 8;
            this.btnAddArc.Text = "+";
            this.btnAddArc.UseVisualStyleBackColor = true;
            this.btnAddArc.Click += new System.EventHandler(this.btnAddArc_Click);
            // 
            // lblEdge
            // 
            this.lblEdge.AutoSize = true;
            this.lblEdge.Location = new System.Drawing.Point(1, 105);
            this.lblEdge.Name = "lblEdge";
            this.lblEdge.Size = new System.Drawing.Size(40, 13);
            this.lblEdge.TabIndex = 6;
            this.lblEdge.Text = "Aresta:";
            // 
            // cmbNodeFrom
            // 
            this.cmbNodeFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNodeFrom.FormattingEnabled = true;
            this.cmbNodeFrom.Location = new System.Drawing.Point(47, 101);
            this.cmbNodeFrom.Name = "cmbNodeFrom";
            this.cmbNodeFrom.Size = new System.Drawing.Size(69, 21);
            this.cmbNodeFrom.TabIndex = 5;
            // 
            // cmbNodeTo
            // 
            this.cmbNodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNodeTo.FormattingEnabled = true;
            this.cmbNodeTo.Location = new System.Drawing.Point(122, 101);
            this.cmbNodeTo.Name = "cmbNodeTo";
            this.cmbNodeTo.Size = new System.Drawing.Size(69, 21);
            this.cmbNodeTo.TabIndex = 4;
            // 
            // btnRemoveNode
            // 
            this.btnRemoveNode.Location = new System.Drawing.Point(266, 42);
            this.btnRemoveNode.Name = "btnRemoveNode";
            this.btnRemoveNode.Size = new System.Drawing.Size(32, 23);
            this.btnRemoveNode.TabIndex = 3;
            this.btnRemoveNode.Text = "-";
            this.btnRemoveNode.UseVisualStyleBackColor = true;
            this.btnRemoveNode.Click += new System.EventHandler(this.btnRemoveNode_Click);
            // 
            // btnAddNode
            // 
            this.btnAddNode.Location = new System.Drawing.Point(234, 42);
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
            this.gbOperations.Controls.Add(this.Ptotal);
            this.gbOperations.Controls.Add(this.btnTempoTotalVarios);
            this.gbOperations.Controls.Add(this.txtPath);
            this.gbOperations.Controls.Add(this.lblPath);
            this.gbOperations.Controls.Add(this.btnTempoGasto);
            this.gbOperations.Controls.Add(this.cmbNodeCalc);
            this.gbOperations.Controls.Add(this.lblNoodeNeighbourhood);
            this.gbOperations.Controls.Add(this.lstTarefas);
            this.gbOperations.Controls.Add(this.btnTempo);
            this.gbOperations.Controls.Add(this.label1);
            this.gbOperations.Controls.Add(this.btnPrioridade);
            this.gbOperations.Location = new System.Drawing.Point(12, 300);
            this.gbOperations.Name = "gbOperations";
            this.gbOperations.Size = new System.Drawing.Size(304, 266);
            this.gbOperations.TabIndex = 2;
            this.gbOperations.TabStop = false;
            this.gbOperations.Text = "Operações";
            this.gbOperations.Enter += new System.EventHandler(this.gbOperations_Enter);
            // 
            // Ptotal
            // 
            this.Ptotal.Location = new System.Drawing.Point(47, 86);
            this.Ptotal.Name = "Ptotal";
            this.Ptotal.Size = new System.Drawing.Size(72, 23);
            this.Ptotal.TabIndex = 8;
            this.Ptotal.Text = "prioridade";
            this.Ptotal.UseVisualStyleBackColor = true;
            this.Ptotal.Click += new System.EventHandler(this.Ptotal_Click);
            // 
            // btnTempoTotalVarios
            // 
            this.btnTempoTotalVarios.Location = new System.Drawing.Point(202, 86);
            this.btnTempoTotalVarios.Name = "btnTempoTotalVarios";
            this.btnTempoTotalVarios.Size = new System.Drawing.Size(96, 23);
            this.btnTempoTotalVarios.TabIndex = 15;
            this.btnTempoTotalVarios.Text = "Tempo de Varios";
            this.btnTempoTotalVarios.UseVisualStyleBackColor = true;
            this.btnTempoTotalVarios.Click += new System.EventHandler(this.btnTempoTotalVarios_Click);
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
            this.lblPath.Location = new System.Drawing.Point(1, 63);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(46, 13);
            this.lblPath.TabIndex = 13;
            this.lblPath.Text = "Tarefas:";
            // 
            // btnTempoGasto
            // 
            this.btnTempoGasto.Location = new System.Drawing.Point(122, 24);
            this.btnTempoGasto.Name = "btnTempoGasto";
            this.btnTempoGasto.Size = new System.Drawing.Size(176, 23);
            this.btnTempoGasto.TabIndex = 12;
            this.btnTempoGasto.Text = "Tempo Gasto";
            this.btnTempoGasto.UseVisualStyleBackColor = true;
            this.btnTempoGasto.Click += new System.EventHandler(this.btnTempoGasto_Click);
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
            this.lblNoodeNeighbourhood.Location = new System.Drawing.Point(1, 28);
            this.lblNoodeNeighbourhood.Name = "lblNoodeNeighbourhood";
            this.lblNoodeNeighbourhood.Size = new System.Drawing.Size(41, 13);
            this.lblNoodeNeighbourhood.TabIndex = 0;
            this.lblNoodeNeighbourhood.Text = "Tarefa:";
            // 
            // lstTarefas
            // 
            this.lstTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTarefas.FormattingEnabled = true;
            this.lstTarefas.ItemHeight = 16;
            this.lstTarefas.Location = new System.Drawing.Point(84, 151);
            this.lstTarefas.Name = "lstTarefas";
            this.lstTarefas.Size = new System.Drawing.Size(209, 100);
            this.lstTarefas.TabIndex = 3;
            // 
            // btnPrioridade
            // 
            this.btnPrioridade.Location = new System.Drawing.Point(8, 178);
            this.btnPrioridade.Name = "btnPrioridade";
            this.btnPrioridade.Size = new System.Drawing.Size(70, 23);
            this.btnPrioridade.TabIndex = 4;
            this.btnPrioridade.Text = "Prioridade";
            this.btnPrioridade.UseVisualStyleBackColor = true;
            this.btnPrioridade.Click += new System.EventHandler(this.btnPrioridade_Click);
            // 
            // btnTempo
            // 
            this.btnTempo.Location = new System.Drawing.Point(8, 217);
            this.btnTempo.Name = "btnTempo";
            this.btnTempo.Size = new System.Drawing.Size(70, 23);
            this.btnTempo.TabIndex = 6;
            this.btnTempo.Text = "Tempo";
            this.btnTempo.UseVisualStyleBackColor = true;
            this.btnTempo.Click += new System.EventHandler(this.btnTempo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ordenar por:";
            // 
            // lstSequenciaTarefas
            // 
            this.lstSequenciaTarefas.FormattingEnabled = true;
            this.lstSequenciaTarefas.Location = new System.Drawing.Point(367, 29);
            this.lstSequenciaTarefas.Name = "lstSequenciaTarefas";
            this.lstSequenciaTarefas.Size = new System.Drawing.Size(355, 95);
            this.lstSequenciaTarefas.TabIndex = 8;
            // 
            // txtTempoTotal
            // 
            this.txtTempoTotal.Location = new System.Drawing.Point(267, 47);
            this.txtTempoTotal.Name = "txtTempoTotal";
            this.txtTempoTotal.Size = new System.Drawing.Size(94, 20);
            this.txtTempoTotal.TabIndex = 9;
            // 
            // lblMaxTaref
            // 
            this.lblMaxTaref.AutoSize = true;
            this.lblMaxTaref.Location = new System.Drawing.Point(265, 28);
            this.lblMaxTaref.Name = "lblMaxTaref";
            this.lblMaxTaref.Size = new System.Drawing.Size(96, 13);
            this.lblMaxTaref.TabIndex = 10;
            this.lblMaxTaref.Text = "Máximo de tarefas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tempo máximo:";
            // 
            // btnExeBuscaCega
            // 
            this.btnExeBuscaCega.Location = new System.Drawing.Point(287, 71);
            this.btnExeBuscaCega.Name = "btnExeBuscaCega";
            this.btnExeBuscaCega.Size = new System.Drawing.Size(74, 23);
            this.btnExeBuscaCega.TabIndex = 12;
            this.btnExeBuscaCega.Text = "Busca Cega";
            this.btnExeBuscaCega.UseVisualStyleBackColor = true;
            this.btnExeBuscaCega.Click += new System.EventHandler(this.btnExeBuscaCega_Click);
            // 
            // btnExecAEstrela
            // 
            this.btnExecAEstrela.Location = new System.Drawing.Point(287, 100);
            this.btnExecAEstrela.Name = "btnExecAEstrela";
            this.btnExecAEstrela.Size = new System.Drawing.Size(74, 23);
            this.btnExecAEstrela.TabIndex = 13;
            this.btnExecAEstrela.Text = "Busca A*";
            this.btnExecAEstrela.UseVisualStyleBackColor = true;
            this.btnExecAEstrela.Click += new System.EventHandler(this.btnExecAEstrela_Click);
            // 
            // btnPreDef1
            // 
            this.btnPreDef1.Location = new System.Drawing.Point(75, 70);
            this.btnPreDef1.Name = "btnPreDef1";
            this.btnPreDef1.Size = new System.Drawing.Size(69, 22);
            this.btnPreDef1.TabIndex = 14;
            this.btnPreDef1.Text = "Tarefas 1";
            this.btnPreDef1.UseVisualStyleBackColor = true;
            this.btnPreDef1.Click += new System.EventHandler(this.btnPreDef1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sequencia de Tarefas:";
            // 
            // btnPreDef2
            // 
            this.btnPreDef2.Location = new System.Drawing.Point(150, 70);
            this.btnPreDef2.Name = "btnPreDef2";
            this.btnPreDef2.Size = new System.Drawing.Size(69, 22);
            this.btnPreDef2.TabIndex = 16;
            this.btnPreDef2.Text = "Tarefas 2";
            this.btnPreDef2.UseVisualStyleBackColor = true;
            this.btnPreDef2.Click += new System.EventHandler(this.btnPreDef2_Click);
            // 
            // lblCriarTarefas
            // 
            this.lblCriarTarefas.AutoSize = true;
            this.lblCriarTarefas.Location = new System.Drawing.Point(6, 47);
            this.lblCriarTarefas.Name = "lblCriarTarefas";
            this.lblCriarTarefas.Size = new System.Drawing.Size(31, 13);
            this.lblCriarTarefas.TabIndex = 17;
            this.lblCriarTarefas.Text = "Criar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Predefinidas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lstSequenciaTarefas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTempoTotal);
            this.groupBox1.Controls.Add(this.btnExecAEstrela);
            this.groupBox1.Controls.Add(this.lblMaxTaref);
            this.groupBox1.Controls.Add(this.btnExeBuscaCega);
            this.groupBox1.Location = new System.Drawing.Point(322, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 130);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1062, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbOperations);
            this.Controls.Add(this.gbGraph);
            this.Controls.Add(this.pnlGraph);
            this.Name = "Principal";
            this.Text = "Projeto";
            this.gbGraph.ResumeLayout(false);
            this.gbGraph.PerformLayout();
            this.gbOperations.ResumeLayout(false);
            this.gbOperations.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label lblEdge;
        private System.Windows.Forms.ComboBox cmbNodeFrom;
        private System.Windows.Forms.ComboBox cmbNodeTo;
        private System.Windows.Forms.Button btnRemoveArcs;
        private System.Windows.Forms.ListBox lstArcs;
        private System.Windows.Forms.GroupBox gbOperations;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnTempoGasto;
        private System.Windows.Forms.ComboBox cmbNodeCalc;
        private System.Windows.Forms.Label lblNoodeNeighbourhood;
        private System.Windows.Forms.Button btnTempoTotalVarios;
        private System.Windows.Forms.Label lblTempoTarefa;
        private System.Windows.Forms.TextBox txtTempoTarefa;
        private System.Windows.Forms.Label lblPrioridadeTarefa;
        private System.Windows.Forms.TextBox txtPrioridadeTarefa;
        private System.Windows.Forms.ListBox lstTarefas;
        private System.Windows.Forms.Button btnPrioridade;
        private System.Windows.Forms.Button btnTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ptotal;
        private System.Windows.Forms.ListBox lstSequenciaTarefas;
        private System.Windows.Forms.TextBox txtTempoTotal;
        private System.Windows.Forms.Label lblMaxTaref;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExeBuscaCega;
        private System.Windows.Forms.Button btnExecAEstrela;
        private System.Windows.Forms.Button btnRemoveEdge;
        private System.Windows.Forms.Button btnPreDef1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCriarTarefas;
        private System.Windows.Forms.Button btnPreDef2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

