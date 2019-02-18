namespace MillerControls
{
    partial class MillerButton
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MillerButton));
            this.pnIcone = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tmrCor = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnIcone
            // 
            this.pnIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnIcone.BackgroundImage")));
            this.pnIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnIcone.Enabled = false;
            this.pnIcone.Location = new System.Drawing.Point(4, 4);
            this.pnIcone.Name = "pnIcone";
            this.pnIcone.Size = new System.Drawing.Size(46, 46);
            this.pnIcone.TabIndex = 0;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(84, 17);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(136, 22);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Título Exemplo";
            this.lbTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MillerButton_MouseDown);
            this.lbTitulo.MouseEnter += new System.EventHandler(this.BotaoMenu_MouseEnter);
            this.lbTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MillerButton_MouseUp);
            // 
            // tmrCor
            // 
            this.tmrCor.Interval = 1;
            this.tmrCor.Tick += new System.EventHandler(this.tmrCor_Tick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 2);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(2, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 2);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(275, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 54);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 54);
            this.panel1.TabIndex = 4;
            // 
            // MillerButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.pnIcone);
            this.Name = "MillerButton";
            this.Size = new System.Drawing.Size(277, 54);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MillerButton_MouseDown);
            this.MouseEnter += new System.EventHandler(this.BotaoMenu_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MillerButton_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MillerButton_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnIcone;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Timer tmrCor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
