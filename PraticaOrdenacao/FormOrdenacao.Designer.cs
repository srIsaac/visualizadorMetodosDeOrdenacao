namespace PraticaOrdenacao
{
    partial class FormOrdenacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heapSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolhaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblDecrescente = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cbxvet = new System.Windows.Forms.ComboBox();
            this.seleçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inserçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shellSortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.heapSortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeSortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 54);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(500, 300);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoToolStripMenuItem,
            this.estatísticasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritmoToolStripMenuItem
            // 
            this.algoritmoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolhaToolStripMenuItem,
            this.seleçãoToolStripMenuItem,
            this.inserçãoToolStripMenuItem,
            this.shellSortToolStripMenuItem,
            this.quickSortToolStripMenuItem,
            this.heapSortToolStripMenuItem,
            this.mergeSortToolStripMenuItem});
            this.algoritmoToolStripMenuItem.Name = "algoritmoToolStripMenuItem";
            this.algoritmoToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.algoritmoToolStripMenuItem.Text = "Algoritmo";
            // 
            // bolhaToolStripMenuItem
            // 
            this.bolhaToolStripMenuItem.Name = "bolhaToolStripMenuItem";
            this.bolhaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.bolhaToolStripMenuItem.Text = "Bolha";
            this.bolhaToolStripMenuItem.Click += new System.EventHandler(this.bolhaToolStripMenuItem_Click);
            // 
            // seleçãoToolStripMenuItem
            // 
            this.seleçãoToolStripMenuItem.Name = "seleçãoToolStripMenuItem";
            this.seleçãoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.seleçãoToolStripMenuItem.Text = "Seleção";
            this.seleçãoToolStripMenuItem.Click += new System.EventHandler(this.seleçãoToolStripMenuItem_Click);
            // 
            // inserçãoToolStripMenuItem
            // 
            this.inserçãoToolStripMenuItem.Name = "inserçãoToolStripMenuItem";
            this.inserçãoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.inserçãoToolStripMenuItem.Text = "Inserção";
            this.inserçãoToolStripMenuItem.Click += new System.EventHandler(this.inserçãoToolStripMenuItem_Click);
            // 
            // shellSortToolStripMenuItem
            // 
            this.shellSortToolStripMenuItem.Name = "shellSortToolStripMenuItem";
            this.shellSortToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.shellSortToolStripMenuItem.Text = "ShellSort";
            this.shellSortToolStripMenuItem.Click += new System.EventHandler(this.shellSortToolStripMenuItem_Click);
            // 
            // quickSortToolStripMenuItem
            // 
            this.quickSortToolStripMenuItem.Name = "quickSortToolStripMenuItem";
            this.quickSortToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.quickSortToolStripMenuItem.Text = "QuickSort";
            this.quickSortToolStripMenuItem.Click += new System.EventHandler(this.quickSortToolStripMenuItem_Click);
            // 
            // heapSortToolStripMenuItem
            // 
            this.heapSortToolStripMenuItem.Name = "heapSortToolStripMenuItem";
            this.heapSortToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.heapSortToolStripMenuItem.Text = "HeapSort";
            this.heapSortToolStripMenuItem.Click += new System.EventHandler(this.heapSortToolStripMenuItem_Click);
            // 
            // mergeSortToolStripMenuItem
            // 
            this.mergeSortToolStripMenuItem.Name = "mergeSortToolStripMenuItem";
            this.mergeSortToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.mergeSortToolStripMenuItem.Text = "MergeSort";
            this.mergeSortToolStripMenuItem.Click += new System.EventHandler(this.mergeSortToolStripMenuItem_Click);
            // 
            // estatísticasToolStripMenuItem
            // 
            this.estatísticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolhaToolStripMenuItem1,
            this.seleçãoToolStripMenuItem1,
            this.inserçãoToolStripMenuItem1,
            this.shellSortToolStripMenuItem1,
            this.quickSortToolStripMenuItem1,
            this.heapSortToolStripMenuItem1,
            this.mergeSortToolStripMenuItem1});
            this.estatísticasToolStripMenuItem.Name = "estatísticasToolStripMenuItem";
            this.estatísticasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.estatísticasToolStripMenuItem.Text = "Estatísticas";
            // 
            // bolhaToolStripMenuItem1
            // 
            this.bolhaToolStripMenuItem1.Name = "bolhaToolStripMenuItem1";
            this.bolhaToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.bolhaToolStripMenuItem1.Text = "Bolha";
            this.bolhaToolStripMenuItem1.Click += new System.EventHandler(this.bolhaToolStripMenuItem1_Click_1);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // bgw
            // 
            this.bgw.WorkerSupportsCancellation = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(123, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "Crescente";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lblDecrescente
            // 
            this.lblDecrescente.AutoSize = true;
            this.lblDecrescente.Location = new System.Drawing.Point(262, 27);
            this.lblDecrescente.Name = "lblDecrescente";
            this.lblDecrescente.Size = new System.Drawing.Size(86, 17);
            this.lblDecrescente.TabIndex = 3;
            this.lblDecrescente.Text = "Decrescente";
            this.lblDecrescente.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Aleatorio";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // cbxvet
            // 
            this.cbxvet.FormattingEnabled = true;
            this.cbxvet.Items.AddRange(new object[] {
            "500",
            "250",
            "300",
            "100"});
            this.cbxvet.Location = new System.Drawing.Point(394, 27);
            this.cbxvet.Name = "cbxvet";
            this.cbxvet.Size = new System.Drawing.Size(121, 21);
            this.cbxvet.TabIndex = 5;
            // 
            // seleçãoToolStripMenuItem1
            // 
            this.seleçãoToolStripMenuItem1.Name = "seleçãoToolStripMenuItem1";
            this.seleçãoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.seleçãoToolStripMenuItem1.Text = "Seleção";
            this.seleçãoToolStripMenuItem1.Click += new System.EventHandler(this.seleçãoToolStripMenuItem1_Click);
            // 
            // inserçãoToolStripMenuItem1
            // 
            this.inserçãoToolStripMenuItem1.Name = "inserçãoToolStripMenuItem1";
            this.inserçãoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.inserçãoToolStripMenuItem1.Text = "Inserção";
            // 
            // shellSortToolStripMenuItem1
            // 
            this.shellSortToolStripMenuItem1.Name = "shellSortToolStripMenuItem1";
            this.shellSortToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.shellSortToolStripMenuItem1.Text = "ShellSort";
            // 
            // quickSortToolStripMenuItem1
            // 
            this.quickSortToolStripMenuItem1.Name = "quickSortToolStripMenuItem1";
            this.quickSortToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.quickSortToolStripMenuItem1.Text = "QuickSort";
            // 
            // heapSortToolStripMenuItem1
            // 
            this.heapSortToolStripMenuItem1.Name = "heapSortToolStripMenuItem1";
            this.heapSortToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.heapSortToolStripMenuItem1.Text = "HeapSort";
            // 
            // mergeSortToolStripMenuItem1
            // 
            this.mergeSortToolStripMenuItem1.Name = "mergeSortToolStripMenuItem1";
            this.mergeSortToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.mergeSortToolStripMenuItem1.Text = "MergeSort";
            // 
            // FormOrdenacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 372);
            this.Controls.Add(this.cbxvet);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.lblDecrescente);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormOrdenacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prática 5 - Métodos de Ordenação 2018/1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bolhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticasToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.ToolStripMenuItem bolhaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seleçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heapSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeSortToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton lblDecrescente;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox cbxvet;
        private System.Windows.Forms.ToolStripMenuItem seleçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inserçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shellSortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quickSortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem heapSortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mergeSortToolStripMenuItem1;
    }
}

