namespace apEstudante
{
    partial class CaixaFlashcards
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.lblFrequencia = new System.Windows.Forms.Label();
            this.lblProximaSessao = new System.Windows.Forms.Label();
            this.dgvFlashcards = new System.Windows.Forms.DataGridView();
            this.clnPalavraChave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.painelDoubleBuffered3 = new apEstudante.PainelDoubleBuffered();
            this.painelDoubleBuffered4 = new apEstudante.PainelDoubleBuffered();
            this.painelDoubleBuffered2 = new apEstudante.PainelDoubleBuffered();
            this.painelDoubleBuffered1 = new apEstudante.PainelDoubleBuffered();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlashcards)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaixa
            // 
            this.lblCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCaixa.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixa.Location = new System.Drawing.Point(2, 2);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(259, 25);
            this.lblCaixa.TabIndex = 2;
            this.lblCaixa.Text = "Caixa 1";
            this.lblCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFrequencia
            // 
            this.lblFrequencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrequencia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequencia.Location = new System.Drawing.Point(2, 50);
            this.lblFrequencia.Name = "lblFrequencia";
            this.lblFrequencia.Size = new System.Drawing.Size(259, 25);
            this.lblFrequencia.TabIndex = 3;
            this.lblFrequencia.Text = "Frequência: todo dia";
            this.lblFrequencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProximaSessao
            // 
            this.lblProximaSessao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProximaSessao.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProximaSessao.Location = new System.Drawing.Point(2, 27);
            this.lblProximaSessao.Name = "lblProximaSessao";
            this.lblProximaSessao.Size = new System.Drawing.Size(259, 25);
            this.lblProximaSessao.TabIndex = 5;
            this.lblProximaSessao.Text = "Cards para hoje: 0";
            this.lblProximaSessao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvFlashcards
            // 
            this.dgvFlashcards.AllowUserToAddRows = false;
            this.dgvFlashcards.AllowUserToDeleteRows = false;
            this.dgvFlashcards.AllowUserToResizeColumns = false;
            this.dgvFlashcards.AllowUserToResizeRows = false;
            this.dgvFlashcards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFlashcards.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlashcards.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFlashcards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlashcards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnPalavraChave,
            this.clnCategoria});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlashcards.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFlashcards.Location = new System.Drawing.Point(12, 78);
            this.dgvFlashcards.Name = "dgvFlashcards";
            this.dgvFlashcards.ReadOnly = true;
            this.dgvFlashcards.RowHeadersVisible = false;
            this.dgvFlashcards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFlashcards.Size = new System.Drawing.Size(240, 358);
            this.dgvFlashcards.TabIndex = 6;
            // 
            // clnPalavraChave
            // 
            this.clnPalavraChave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnPalavraChave.HeaderText = "Palavra-Chave";
            this.clnPalavraChave.Name = "clnPalavraChave";
            this.clnPalavraChave.ReadOnly = true;
            this.clnPalavraChave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnCategoria
            // 
            this.clnCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnCategoria.HeaderText = "Categoria";
            this.clnCategoria.Name = "clnCategoria";
            this.clnCategoria.ReadOnly = true;
            this.clnCategoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // painelDoubleBuffered3
            // 
            this.painelDoubleBuffered3.BackColor = System.Drawing.Color.Black;
            this.painelDoubleBuffered3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.painelDoubleBuffered3.Location = new System.Drawing.Point(2, 446);
            this.painelDoubleBuffered3.Name = "painelDoubleBuffered3";
            this.painelDoubleBuffered3.Size = new System.Drawing.Size(259, 2);
            this.painelDoubleBuffered3.TabIndex = 1;
            // 
            // painelDoubleBuffered4
            // 
            this.painelDoubleBuffered4.BackColor = System.Drawing.Color.Black;
            this.painelDoubleBuffered4.Dock = System.Windows.Forms.DockStyle.Right;
            this.painelDoubleBuffered4.Location = new System.Drawing.Point(261, 2);
            this.painelDoubleBuffered4.Name = "painelDoubleBuffered4";
            this.painelDoubleBuffered4.Size = new System.Drawing.Size(2, 446);
            this.painelDoubleBuffered4.TabIndex = 1;
            // 
            // painelDoubleBuffered2
            // 
            this.painelDoubleBuffered2.BackColor = System.Drawing.Color.Black;
            this.painelDoubleBuffered2.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelDoubleBuffered2.Location = new System.Drawing.Point(2, 0);
            this.painelDoubleBuffered2.Name = "painelDoubleBuffered2";
            this.painelDoubleBuffered2.Size = new System.Drawing.Size(261, 2);
            this.painelDoubleBuffered2.TabIndex = 1;
            // 
            // painelDoubleBuffered1
            // 
            this.painelDoubleBuffered1.BackColor = System.Drawing.Color.Black;
            this.painelDoubleBuffered1.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelDoubleBuffered1.Location = new System.Drawing.Point(0, 0);
            this.painelDoubleBuffered1.Name = "painelDoubleBuffered1";
            this.painelDoubleBuffered1.Size = new System.Drawing.Size(2, 448);
            this.painelDoubleBuffered1.TabIndex = 0;
            // 
            // CaixaFlashcards
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dgvFlashcards);
            this.Controls.Add(this.lblProximaSessao);
            this.Controls.Add(this.lblFrequencia);
            this.Controls.Add(this.lblCaixa);
            this.Controls.Add(this.painelDoubleBuffered3);
            this.Controls.Add(this.painelDoubleBuffered4);
            this.Controls.Add(this.painelDoubleBuffered2);
            this.Controls.Add(this.painelDoubleBuffered1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CaixaFlashcards";
            this.Size = new System.Drawing.Size(263, 448);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlashcards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PainelDoubleBuffered painelDoubleBuffered1;
        private PainelDoubleBuffered painelDoubleBuffered2;
        private PainelDoubleBuffered painelDoubleBuffered3;
        private PainelDoubleBuffered painelDoubleBuffered4;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.Label lblFrequencia;
        private System.Windows.Forms.Label lblProximaSessao;
        private System.Windows.Forms.DataGridView dgvFlashcards;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPalavraChave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCategoria;
    }
}