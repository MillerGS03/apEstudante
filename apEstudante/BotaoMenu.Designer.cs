namespace apEstudante
{
    partial class BotaoMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotaoMenu));
            this.pnIcone = new apEstudante.PainelDoubleBuffered();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tmrCor = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnIcone
            // 
            this.pnIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnIcone.BackgroundImage")));
            this.pnIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnIcone.Enabled = false;
            this.pnIcone.Location = new System.Drawing.Point(5, 3);
            this.pnIcone.Name = "pnIcone";
            this.pnIcone.Size = new System.Drawing.Size(44, 44);
            this.pnIcone.TabIndex = 0;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(82, 16);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(136, 22);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Título Exemplo";
            this.lbTitulo.MouseEnter += new System.EventHandler(this.BotaoMenu_MouseEnter);
            // 
            // tmrCor
            // 
            this.tmrCor.Interval = 1;
            this.tmrCor.Tick += new System.EventHandler(this.tmrCor_Tick);
            // 
            // BotaoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.pnIcone);
            this.Name = "BotaoMenu";
            this.Size = new System.Drawing.Size(280, 50);
            this.MouseEnter += new System.EventHandler(this.BotaoMenu_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PainelDoubleBuffered pnIcone;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Timer tmrCor;
    }
}
