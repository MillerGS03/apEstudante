namespace MillerControls
{
    partial class MillerFormBorderStyle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MillerFormBorderStyle));
            this.tmrWindowState = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnIcone = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pnMinimizar = new System.Windows.Forms.Panel();
            this.pnFechar = new System.Windows.Forms.Panel();
            this.pnTopo = new System.Windows.Forms.Panel();
            this.pnTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrWindowState
            // 
            this.tmrWindowState.Interval = 1;
            this.tmrWindowState.Tick += new System.EventHandler(this.tmrWindowState_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 36);
            this.panel3.TabIndex = 44;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTopo_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTopo_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTopo_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(401, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 36);
            this.panel2.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 2);
            this.panel1.TabIndex = 42;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTopo_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTopo_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTopo_MouseUp);
            // 
            // pnIcone
            // 
            this.pnIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnIcone.BackgroundImage")));
            this.pnIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnIcone.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnIcone.Location = new System.Drawing.Point(2, 4);
            this.pnIcone.Name = "pnIcone";
            this.pnIcone.Size = new System.Drawing.Size(33, 33);
            this.pnIcone.TabIndex = 41;
            this.pnIcone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTopo_MouseDown);
            this.pnIcone.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTopo_MouseMove);
            this.pnIcone.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTopo_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(403, 2);
            this.panel4.TabIndex = 8;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTopo_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTopo_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTopo_MouseUp);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(40, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(61, 24);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Form";
            this.lbTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTopo_MouseDown);
            this.lbTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTopo_MouseMove);
            this.lbTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTopo_MouseUp);
            // 
            // pnMinimizar
            // 
            this.pnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMinimizar.BackgroundImage")));
            this.pnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnMinimizar.Location = new System.Drawing.Point(333, 4);
            this.pnMinimizar.Name = "pnMinimizar";
            this.pnMinimizar.Size = new System.Drawing.Size(32, 32);
            this.pnMinimizar.TabIndex = 1;
            this.pnMinimizar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnMinimizar_MouseClick);
            // 
            // pnFechar
            // 
            this.pnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnFechar.BackgroundImage")));
            this.pnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnFechar.Location = new System.Drawing.Point(368, 4);
            this.pnFechar.Name = "pnFechar";
            this.pnFechar.Size = new System.Drawing.Size(32, 32);
            this.pnFechar.TabIndex = 0;
            this.pnFechar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnFechar_MouseClick);
            // 
            // pnTopo
            // 
            this.pnTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnTopo.Controls.Add(this.panel3);
            this.pnTopo.Controls.Add(this.panel2);
            this.pnTopo.Controls.Add(this.panel1);
            this.pnTopo.Controls.Add(this.pnIcone);
            this.pnTopo.Controls.Add(this.panel4);
            this.pnTopo.Controls.Add(this.lbTitulo);
            this.pnTopo.Controls.Add(this.pnMinimizar);
            this.pnTopo.Controls.Add(this.pnFechar);
            this.pnTopo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTopo.Location = new System.Drawing.Point(0, 0);
            this.pnTopo.MinimumSize = new System.Drawing.Size(0, 40);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Size = new System.Drawing.Size(403, 40);
            this.pnTopo.TabIndex = 10;
            this.pnTopo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTopo_MouseDown);
            this.pnTopo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTopo_MouseMove);
            this.pnTopo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTopo_MouseUp);
            // 
            // MillerFormBorderStyle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.pnTopo);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximumSize = new System.Drawing.Size(2000, 40);
            this.MinimumSize = new System.Drawing.Size(0, 40);
            this.Name = "MillerFormBorderStyle";
            this.Size = new System.Drawing.Size(403, 40);
            this.Load += new System.EventHandler(this.MillerFormBorderStyle_Load);
            this.BackColorChanged += new System.EventHandler(this.MillerFormBorderStyle_BackColorChanged);
            this.ForeColorChanged += new System.EventHandler(this.MillerFormBorderStyle_ForeColorChanged);
            this.pnTopo.ResumeLayout(false);
            this.pnTopo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrWindowState;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnIcone;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel pnMinimizar;
        private System.Windows.Forms.Panel pnFechar;
        private System.Windows.Forms.Panel pnTopo;
    }
}
