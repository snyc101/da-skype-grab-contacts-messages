namespace DAGrabSkypeMessages
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lContas = new System.Windows.Forms.Label();
            this.cContas = new System.Windows.Forms.ComboBox();
            this.bVerifica = new System.Windows.Forms.Button();
            this.sPaineis = new System.Windows.Forms.SplitContainer();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.Grid2 = new System.Windows.Forms.DataGridView();
            this.bExportar = new System.Windows.Forms.Button();
            this.pDaberto = new System.Windows.Forms.Panel();
            this.lDev = new System.Windows.Forms.Label();
            this.sCabecalho = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvimentoAbertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bFechar = new System.Windows.Forms.Button();
            this.dlgExportar = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.sPaineis)).BeginInit();
            this.sPaineis.Panel1.SuspendLayout();
            this.sPaineis.Panel2.SuspendLayout();
            this.sPaineis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).BeginInit();
            this.pDaberto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCabecalho)).BeginInit();
            this.sCabecalho.Panel1.SuspendLayout();
            this.sCabecalho.Panel2.SuspendLayout();
            this.sCabecalho.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lContas
            // 
            this.lContas.AutoSize = true;
            this.lContas.Location = new System.Drawing.Point(3, 33);
            this.lContas.Name = "lContas";
            this.lContas.Size = new System.Drawing.Size(235, 13);
            this.lContas.TabIndex = 0;
            this.lContas.Text = "Contas do Skype Disponiveis (Skype Accounts):";
            // 
            // cContas
            // 
            this.cContas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cContas.FormattingEnabled = true;
            this.cContas.Location = new System.Drawing.Point(6, 49);
            this.cContas.Name = "cContas";
            this.cContas.Size = new System.Drawing.Size(433, 21);
            this.cContas.TabIndex = 1;
            // 
            // bVerifica
            // 
            this.bVerifica.Location = new System.Drawing.Point(445, 47);
            this.bVerifica.Name = "bVerifica";
            this.bVerifica.Size = new System.Drawing.Size(149, 23);
            this.bVerifica.TabIndex = 2;
            this.bVerifica.Text = "Verificar (Verify)";
            this.bVerifica.UseVisualStyleBackColor = true;
            this.bVerifica.Click += new System.EventHandler(this.button1_Click);
            // 
            // sPaineis
            // 
            this.sPaineis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sPaineis.Location = new System.Drawing.Point(6, 105);
            this.sPaineis.Name = "sPaineis";
            // 
            // sPaineis.Panel1
            // 
            this.sPaineis.Panel1.Controls.Add(this.Grid1);
            // 
            // sPaineis.Panel2
            // 
            this.sPaineis.Panel2.Controls.Add(this.Grid2);
            this.sPaineis.Size = new System.Drawing.Size(1079, 373);
            this.sPaineis.SplitterDistance = 437;
            this.sPaineis.TabIndex = 3;
            // 
            // Grid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Grid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid1.Location = new System.Drawing.Point(0, 0);
            this.Grid1.Name = "Grid1";
            this.Grid1.ReadOnly = true;
            this.Grid1.Size = new System.Drawing.Size(437, 373);
            this.Grid1.TabIndex = 5;
            // 
            // Grid2
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Grid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid2.Location = new System.Drawing.Point(0, 0);
            this.Grid2.Name = "Grid2";
            this.Grid2.ReadOnly = true;
            this.Grid2.Size = new System.Drawing.Size(638, 373);
            this.Grid2.TabIndex = 0;
            // 
            // bExportar
            // 
            this.bExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bExportar.Location = new System.Drawing.Point(725, 482);
            this.bExportar.Name = "bExportar";
            this.bExportar.Size = new System.Drawing.Size(168, 23);
            this.bExportar.TabIndex = 4;
            this.bExportar.Text = "Exportar (Export): TXT";
            this.bExportar.UseVisualStyleBackColor = true;
            this.bExportar.Click += new System.EventHandler(this.button2_Click);
            // 
            // pDaberto
            // 
            this.pDaberto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pDaberto.Controls.Add(this.lDev);
            this.pDaberto.Location = new System.Drawing.Point(897, 33);
            this.pDaberto.Name = "pDaberto";
            this.pDaberto.Size = new System.Drawing.Size(188, 37);
            this.pDaberto.TabIndex = 6;
            // 
            // lDev
            // 
            this.lDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lDev.AutoSize = true;
            this.lDev.Location = new System.Drawing.Point(3, 16);
            this.lDev.Name = "lDev";
            this.lDev.Size = new System.Drawing.Size(182, 13);
            this.lDev.TabIndex = 6;
            this.lDev.Text = "Powered by Desenvolvimento Aberto";
            // 
            // sCabecalho
            // 
            this.sCabecalho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sCabecalho.Location = new System.Drawing.Point(6, 76);
            this.sCabecalho.Name = "sCabecalho";
            // 
            // sCabecalho.Panel1
            // 
            this.sCabecalho.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sCabecalho.Panel1.Controls.Add(this.label3);
            // 
            // sCabecalho.Panel2
            // 
            this.sCabecalho.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sCabecalho.Panel2.Controls.Add(this.label4);
            this.sCabecalho.Size = new System.Drawing.Size(1079, 26);
            this.sCabecalho.SplitterDistance = 438;
            this.sCabecalho.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contatos (Contacts)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Menssagens (Messages)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoFileToolStripMenuItem,
            this.sobreAboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1097, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "mmenu";
            // 
            // arquivoFileToolStripMenuItem
            // 
            this.arquivoFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarSaveToolStripMenuItem,
            this.sairExitToolStripMenuItem});
            this.arquivoFileToolStripMenuItem.Name = "arquivoFileToolStripMenuItem";
            this.arquivoFileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoFileToolStripMenuItem.Text = "Arquivo";
            // 
            // salvarSaveToolStripMenuItem
            // 
            this.salvarSaveToolStripMenuItem.Name = "salvarSaveToolStripMenuItem";
            this.salvarSaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salvarSaveToolStripMenuItem.Text = "Salvar (Save)";
            this.salvarSaveToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // sairExitToolStripMenuItem
            // 
            this.sairExitToolStripMenuItem.Name = "sairExitToolStripMenuItem";
            this.sairExitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.sairExitToolStripMenuItem.Text = "Sair (Exit)";
            this.sairExitToolStripMenuItem.Click += new System.EventHandler(this.sairExitToolStripMenuItem_Click);
            // 
            // sobreAboutToolStripMenuItem
            // 
            this.sobreAboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desenvolvimentoAbertoToolStripMenuItem});
            this.sobreAboutToolStripMenuItem.Name = "sobreAboutToolStripMenuItem";
            this.sobreAboutToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreAboutToolStripMenuItem.Text = "Sobre";
            // 
            // desenvolvimentoAbertoToolStripMenuItem
            // 
            this.desenvolvimentoAbertoToolStripMenuItem.Name = "desenvolvimentoAbertoToolStripMenuItem";
            this.desenvolvimentoAbertoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.desenvolvimentoAbertoToolStripMenuItem.Text = "Desenvolvimento Aberto";
            this.desenvolvimentoAbertoToolStripMenuItem.Click += new System.EventHandler(this.desenvolvimentoAbertoToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLabel1,
            this.toolLabel2,
            this.toolLabel3,
            this.toolLabel4,
            this.toolLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1097, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolLabel1
            // 
            this.toolLabel1.Name = "toolLabel1";
            this.toolLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolLabel2
            // 
            this.toolLabel2.Name = "toolLabel2";
            this.toolLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolLabel3
            // 
            this.toolLabel3.Name = "toolLabel3";
            this.toolLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolLabel4
            // 
            this.toolLabel4.Name = "toolLabel4";
            this.toolLabel4.Size = new System.Drawing.Size(118, 17);
            this.toolLabel4.Text = "toolStripStatusLabel4";
            // 
            // toolLabel5
            // 
            this.toolLabel5.Name = "toolLabel5";
            this.toolLabel5.Size = new System.Drawing.Size(118, 17);
            this.toolLabel5.Text = "toolStripStatusLabel5";
            // 
            // bFechar
            // 
            this.bFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bFechar.Location = new System.Drawing.Point(917, 482);
            this.bFechar.Name = "bFechar";
            this.bFechar.Size = new System.Drawing.Size(168, 23);
            this.bFechar.TabIndex = 12;
            this.bFechar.Text = "Fechar (Close)";
            this.bFechar.UseVisualStyleBackColor = true;
            this.bFechar.Click += new System.EventHandler(this.sairExitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 532);
            this.Controls.Add(this.bFechar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.sCabecalho);
            this.Controls.Add(this.pDaberto);
            this.Controls.Add(this.bExportar);
            this.Controls.Add(this.sPaineis);
            this.Controls.Add(this.bVerifica);
            this.Controls.Add(this.cContas);
            this.Controls.Add(this.lContas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DA - Skype Grab Messages/Contact List  - Desenvolvimento Aberto ";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.sPaineis.Panel1.ResumeLayout(false);
            this.sPaineis.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sPaineis)).EndInit();
            this.sPaineis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).EndInit();
            this.pDaberto.ResumeLayout(false);
            this.pDaberto.PerformLayout();
            this.sCabecalho.Panel1.ResumeLayout(false);
            this.sCabecalho.Panel1.PerformLayout();
            this.sCabecalho.Panel2.ResumeLayout(false);
            this.sCabecalho.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCabecalho)).EndInit();
            this.sCabecalho.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lContas;
        private System.Windows.Forms.ComboBox cContas;
        private System.Windows.Forms.Button bVerifica;
        private System.Windows.Forms.SplitContainer sPaineis;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.DataGridView Grid2;
        private System.Windows.Forms.Button bExportar;
        private System.Windows.Forms.Panel pDaberto;
        private System.Windows.Forms.Label lDev;
        private System.Windows.Forms.SplitContainer sCabecalho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreAboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenvolvimentoAbertoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolLabel5;
        private System.Windows.Forms.Button bFechar;
        private System.Windows.Forms.SaveFileDialog dlgExportar;
    }
}

