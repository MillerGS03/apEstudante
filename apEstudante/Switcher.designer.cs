namespace apAplicativos
{
    partial class Switcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Switcher));
            this.btnEsquerda = new System.Windows.Forms.Button();
            this.btnDireita = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnEsquerda
            // 
            this.btnEsquerda.BackColor = System.Drawing.Color.Transparent;
            this.btnEsquerda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEsquerda.BackgroundImage")));
            this.btnEsquerda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEsquerda.Enabled = false;
            this.btnEsquerda.FlatAppearance.BorderSize = 0;
            this.btnEsquerda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsquerda.Location = new System.Drawing.Point(2, 2);
            this.btnEsquerda.Margin = new System.Windows.Forms.Padding(6);
            this.btnEsquerda.Name = "btnEsquerda";
            this.btnEsquerda.Size = new System.Drawing.Size(48, 44);
            this.btnEsquerda.TabIndex = 0;
            this.btnEsquerda.UseVisualStyleBackColor = false;
            this.btnEsquerda.Click += new System.EventHandler(this.btnEsquerda_Click);
            // 
            // btnDireita
            // 
            this.btnDireita.BackColor = System.Drawing.Color.Transparent;
            this.btnDireita.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDireita.BackgroundImage")));
            this.btnDireita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDireita.Enabled = false;
            this.btnDireita.FlatAppearance.BorderSize = 0;
            this.btnDireita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDireita.Location = new System.Drawing.Point(248, 2);
            this.btnDireita.Margin = new System.Windows.Forms.Padding(6);
            this.btnDireita.Name = "btnDireita";
            this.btnDireita.Size = new System.Drawing.Size(48, 44);
            this.btnDireita.TabIndex = 1;
            this.btnDireita.UseVisualStyleBackColor = false;
            this.btnDireita.Click += new System.EventHandler(this.btnDireita_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(99, 12);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(100, 24);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Nenhum";
            this.lbTitulo.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 48);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 2);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(2, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 2);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(296, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 44);
            this.panel4.TabIndex = 6;
            // 
            // Switcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btnDireita);
            this.Controls.Add(this.btnEsquerda);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Switcher";
            this.Size = new System.Drawing.Size(298, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEsquerda;
        private System.Windows.Forms.Button btnDireita;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
