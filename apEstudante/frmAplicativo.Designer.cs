namespace apEstudante
{
    partial class frmAplicativo
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAplicativo));
            this.ucPomodoro1 = new apEstudante.UcPomodoro();
            this.ucResumos1 = new apEstudante.UcResumos();
            this.ucFlashcards1 = new apEstudante.UcFlashcards();
            this.ucCronogramas1 = new apEstudante.UcCronogramas();
            this.pnMenu = new apEstudante.PainelDoubleBuffered();
            this.btnPomodoro = new apEstudante.BotaoMenu();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFlashcards = new apEstudante.BotaoMenu();
            this.btnResumos = new apEstudante.BotaoMenu();
            this.btnCronogramas = new apEstudante.BotaoMenu();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPomodoro1
            // 
            this.ucPomodoro1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPomodoro1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPomodoro1.Location = new System.Drawing.Point(280, 0);
            this.ucPomodoro1.Name = "ucPomodoro1";
            this.ucPomodoro1.QtosCiclosFeitos = 0;
            this.ucPomodoro1.Size = new System.Drawing.Size(720, 600);
            this.ucPomodoro1.TabIndex = 12;
            this.ucPomodoro1.Visible = false;
            // 
            // ucResumos1
            // 
            this.ucResumos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucResumos1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucResumos1.Location = new System.Drawing.Point(280, 0);
            this.ucResumos1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ucResumos1.Name = "ucResumos1";
            this.ucResumos1.Size = new System.Drawing.Size(720, 600);
            this.ucResumos1.TabIndex = 11;
            this.ucResumos1.Visible = false;
            // 
            // ucFlashcards1
            // 
            this.ucFlashcards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFlashcards1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucFlashcards1.Location = new System.Drawing.Point(280, 0);
            this.ucFlashcards1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ucFlashcards1.Name = "ucFlashcards1";
            this.ucFlashcards1.Size = new System.Drawing.Size(720, 600);
            this.ucFlashcards1.TabIndex = 10;
            this.ucFlashcards1.Visible = false;
            // 
            // ucCronogramas1
            // 
            this.ucCronogramas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCronogramas1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCronogramas1.Location = new System.Drawing.Point(280, 0);
            this.ucCronogramas1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ucCronogramas1.Name = "ucCronogramas1";
            this.ucCronogramas1.Size = new System.Drawing.Size(720, 600);
            this.ucCronogramas1.TabIndex = 8;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnMenu.Controls.Add(this.btnPomodoro);
            this.pnMenu.Controls.Add(this.label2);
            this.pnMenu.Controls.Add(this.btnFlashcards);
            this.pnMenu.Controls.Add(this.btnResumos);
            this.pnMenu.Controls.Add(this.btnCronogramas);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(280, 600);
            this.pnMenu.TabIndex = 5;
            // 
            // btnPomodoro
            // 
            this.btnPomodoro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPomodoro.CorPadrao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPomodoro.CorSelecionada = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPomodoro.ForeColor = System.Drawing.Color.White;
            this.btnPomodoro.Icone = ((System.Drawing.Image)(resources.GetObject("btnPomodoro.Icone")));
            this.btnPomodoro.Location = new System.Drawing.Point(0, 212);
            this.btnPomodoro.Name = "btnPomodoro";
            this.btnPomodoro.Size = new System.Drawing.Size(280, 50);
            this.btnPomodoro.TabIndex = 6;
            this.btnPomodoro.TelaASerMostrada = this.ucPomodoro1;
            this.btnPomodoro.Titulo = "Pomodoro";
            this.btnPomodoro.MouseEnter += new System.EventHandler(this.btnCronogramas_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Menu";
            // 
            // btnFlashcards
            // 
            this.btnFlashcards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFlashcards.CorPadrao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFlashcards.CorSelecionada = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFlashcards.ForeColor = System.Drawing.Color.White;
            this.btnFlashcards.Icone = ((System.Drawing.Image)(resources.GetObject("btnFlashcards.Icone")));
            this.btnFlashcards.Location = new System.Drawing.Point(0, 162);
            this.btnFlashcards.Name = "btnFlashcards";
            this.btnFlashcards.Size = new System.Drawing.Size(280, 50);
            this.btnFlashcards.TabIndex = 4;
            this.btnFlashcards.TelaASerMostrada = this.ucFlashcards1;
            this.btnFlashcards.Titulo = "Flashcards";
            this.btnFlashcards.MouseEnter += new System.EventHandler(this.btnCronogramas_MouseEnter);
            // 
            // btnResumos
            // 
            this.btnResumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResumos.CorPadrao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResumos.CorSelecionada = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnResumos.ForeColor = System.Drawing.Color.White;
            this.btnResumos.Icone = ((System.Drawing.Image)(resources.GetObject("btnResumos.Icone")));
            this.btnResumos.Location = new System.Drawing.Point(0, 112);
            this.btnResumos.Name = "btnResumos";
            this.btnResumos.Size = new System.Drawing.Size(280, 50);
            this.btnResumos.TabIndex = 3;
            this.btnResumos.TelaASerMostrada = this.ucResumos1;
            this.btnResumos.Titulo = "Resumos";
            this.btnResumos.MouseEnter += new System.EventHandler(this.btnCronogramas_MouseEnter);
            // 
            // btnCronogramas
            // 
            this.btnCronogramas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCronogramas.CorPadrao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCronogramas.CorSelecionada = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCronogramas.ForeColor = System.Drawing.Color.White;
            this.btnCronogramas.Icone = ((System.Drawing.Image)(resources.GetObject("btnCronogramas.Icone")));
            this.btnCronogramas.Location = new System.Drawing.Point(0, 62);
            this.btnCronogramas.Name = "btnCronogramas";
            this.btnCronogramas.Size = new System.Drawing.Size(280, 50);
            this.btnCronogramas.TabIndex = 2;
            this.btnCronogramas.TelaASerMostrada = this.ucCronogramas1;
            this.btnCronogramas.Titulo = "Planejamento";
            this.btnCronogramas.MouseEnter += new System.EventHandler(this.btnCronogramas_MouseEnter);
            // 
            // frmAplicativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.ucPomodoro1);
            this.Controls.Add(this.ucResumos1);
            this.Controls.Add(this.ucFlashcards1);
            this.Controls.Add(this.ucCronogramas1);
            this.Controls.Add(this.pnMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1016, 638);
            this.Name = "frmAplicativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organização de Estudos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAplicativo_FormClosing);
            this.Load += new System.EventHandler(this.frmAplicativo_Load);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PainelDoubleBuffered pnMenu;
        private BotaoMenu btnCronogramas;
        private BotaoMenu btnFlashcards;
        private BotaoMenu btnResumos;
        private System.Windows.Forms.Label label2;
        private UcCronogramas ucCronogramas1;
        private UcFlashcards ucFlashcards1;
        private UcResumos ucResumos1;
        private BotaoMenu btnPomodoro;
        private UcPomodoro ucPomodoro1;
    }
}

