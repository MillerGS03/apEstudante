namespace apEstudante
{
    partial class UcFlashcards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcFlashcards));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tpGerenciar = new System.Windows.Forms.TabPage();
            this.pnlCategorias = new System.Windows.Forms.Panel();
            this.lsbCategorias = new System.Windows.Forms.ListBox();
            this.btnRemoverCategoria = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbAdicionarCategoria = new System.Windows.Forms.GroupBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdicionarCategoria = new System.Windows.Forms.Button();
            this.pnlNovoFlashcard = new System.Windows.Forms.Panel();
            this.lblNovoEditarFlashcard = new System.Windows.Forms.Label();
            this.gbNovoFlashcard = new System.Windows.Forms.GroupBox();
            this.btnCancelarEdicao = new System.Windows.Forms.Button();
            this.pnImagem = new System.Windows.Forms.Panel();
            this.btnEscolherImagem = new System.Windows.Forms.Button();
            this.rbImagem = new System.Windows.Forms.RadioButton();
            this.rbTexto = new System.Windows.Forms.RadioButton();
            this.txtPalavraChave = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.txtDefinicao = new System.Windows.Forms.TextBox();
            this.btnAdicionarEditarFlashcard = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlListaItens = new System.Windows.Forms.Panel();
            this.btnEditarFlashcard = new System.Windows.Forms.Button();
            this.lsbFlashcards = new System.Windows.Forms.ListBox();
            this.cbxExibirCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoverFlashcard = new System.Windows.Forms.Button();
            this.pnlDivisaoHorizontal = new System.Windows.Forms.Panel();
            this.pnlDivisaoVertical = new System.Windows.Forms.Panel();
            this.ofdImgFlashcard = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tpGerenciar.SuspendLayout();
            this.pnlCategorias.SuspendLayout();
            this.gbAdicionarCategoria.SuspendLayout();
            this.pnlNovoFlashcard.SuspendLayout();
            this.gbNovoFlashcard.SuspendLayout();
            this.pnlListaItens.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Flashcards";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpGerenciar);
            this.tabControl1.Location = new System.Drawing.Point(2, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 550);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(708, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Revisar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tpGerenciar
            // 
            this.tpGerenciar.Controls.Add(this.pnlCategorias);
            this.tpGerenciar.Controls.Add(this.pnlNovoFlashcard);
            this.tpGerenciar.Controls.Add(this.pnlListaItens);
            this.tpGerenciar.Controls.Add(this.pnlDivisaoHorizontal);
            this.tpGerenciar.Controls.Add(this.pnlDivisaoVertical);
            this.tpGerenciar.Location = new System.Drawing.Point(4, 31);
            this.tpGerenciar.Name = "tpGerenciar";
            this.tpGerenciar.Padding = new System.Windows.Forms.Padding(3);
            this.tpGerenciar.Size = new System.Drawing.Size(708, 515);
            this.tpGerenciar.TabIndex = 1;
            this.tpGerenciar.Text = "Gerenciar";
            this.tpGerenciar.UseVisualStyleBackColor = true;
            this.tpGerenciar.Click += new System.EventHandler(this.tpGerenciar_Click);
            this.tpGerenciar.Resize += new System.EventHandler(this.tpGerenciar_Resize);
            // 
            // pnlCategorias
            // 
            this.pnlCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCategorias.Controls.Add(this.lsbCategorias);
            this.pnlCategorias.Controls.Add(this.btnRemoverCategoria);
            this.pnlCategorias.Controls.Add(this.label4);
            this.pnlCategorias.Controls.Add(this.gbAdicionarCategoria);
            this.pnlCategorias.Location = new System.Drawing.Point(242, 268);
            this.pnlCategorias.Name = "pnlCategorias";
            this.pnlCategorias.Size = new System.Drawing.Size(466, 247);
            this.pnlCategorias.TabIndex = 46;
            this.pnlCategorias.Click += new System.EventHandler(this.tpGerenciar_Click);
            this.pnlCategorias.Resize += new System.EventHandler(this.pnlCategorias_Resize);
            // 
            // lsbCategorias
            // 
            this.lsbCategorias.FormattingEnabled = true;
            this.lsbCategorias.ItemHeight = 22;
            this.lsbCategorias.Location = new System.Drawing.Point(7, 35);
            this.lsbCategorias.Name = "lsbCategorias";
            this.lsbCategorias.Size = new System.Drawing.Size(186, 158);
            this.lsbCategorias.TabIndex = 40;
            this.lsbCategorias.SelectedIndexChanged += new System.EventHandler(this.lsbCategorias_SelectedIndexChanged);
            // 
            // btnRemoverCategoria
            // 
            this.btnRemoverCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoverCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemoverCategoria.Enabled = false;
            this.btnRemoverCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoverCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverCategoria.ForeColor = System.Drawing.Color.White;
            this.btnRemoverCategoria.Location = new System.Drawing.Point(7, 203);
            this.btnRemoverCategoria.Name = "btnRemoverCategoria";
            this.btnRemoverCategoria.Size = new System.Drawing.Size(186, 35);
            this.btnRemoverCategoria.TabIndex = 41;
            this.btnRemoverCategoria.Text = "Remover";
            this.btnRemoverCategoria.UseVisualStyleBackColor = false;
            this.btnRemoverCategoria.Click += new System.EventHandler(this.btnRemoverCategoria_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(466, 27);
            this.label4.TabIndex = 31;
            this.label4.Text = "Categorias";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbAdicionarCategoria
            // 
            this.gbAdicionarCategoria.Controls.Add(this.txtMateria);
            this.gbAdicionarCategoria.Controls.Add(this.label5);
            this.gbAdicionarCategoria.Controls.Add(this.btnAdicionarCategoria);
            this.gbAdicionarCategoria.Location = new System.Drawing.Point(196, 51);
            this.gbAdicionarCategoria.Name = "gbAdicionarCategoria";
            this.gbAdicionarCategoria.Size = new System.Drawing.Size(265, 114);
            this.gbAdicionarCategoria.TabIndex = 33;
            this.gbAdicionarCategoria.TabStop = false;
            this.gbAdicionarCategoria.Resize += new System.EventHandler(this.gbAdicionarCategoria_Resize);
            // 
            // txtMateria
            // 
            this.txtMateria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMateria.Location = new System.Drawing.Point(71, 26);
            this.txtMateria.MaxLength = 50;
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(187, 31);
            this.txtMateria.TabIndex = 18;
            this.txtMateria.TextChanged += new System.EventHandler(this.txtMateria_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nome";
            // 
            // btnAdicionarCategoria
            // 
            this.btnAdicionarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionarCategoria.Enabled = false;
            this.btnAdicionarCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdicionarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarCategoria.Location = new System.Drawing.Point(97, 63);
            this.btnAdicionarCategoria.Name = "btnAdicionarCategoria";
            this.btnAdicionarCategoria.Size = new System.Drawing.Size(131, 40);
            this.btnAdicionarCategoria.TabIndex = 16;
            this.btnAdicionarCategoria.Text = "Adicionar";
            this.btnAdicionarCategoria.UseVisualStyleBackColor = false;
            this.btnAdicionarCategoria.Click += new System.EventHandler(this.btnAdicionarCategoria_Click);
            // 
            // pnlNovoFlashcard
            // 
            this.pnlNovoFlashcard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNovoFlashcard.Controls.Add(this.lblNovoEditarFlashcard);
            this.pnlNovoFlashcard.Controls.Add(this.gbNovoFlashcard);
            this.pnlNovoFlashcard.Location = new System.Drawing.Point(242, -1);
            this.pnlNovoFlashcard.Name = "pnlNovoFlashcard";
            this.pnlNovoFlashcard.Size = new System.Drawing.Size(466, 268);
            this.pnlNovoFlashcard.TabIndex = 45;
            this.pnlNovoFlashcard.Click += new System.EventHandler(this.tpGerenciar_Click);
            this.pnlNovoFlashcard.Resize += new System.EventHandler(this.pnlNovoFlashcard_Resize);
            // 
            // lblNovoEditarFlashcard
            // 
            this.lblNovoEditarFlashcard.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNovoEditarFlashcard.Font = new System.Drawing.Font("Century Gothic", 16.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNovoEditarFlashcard.Location = new System.Drawing.Point(0, 0);
            this.lblNovoEditarFlashcard.Name = "lblNovoEditarFlashcard";
            this.lblNovoEditarFlashcard.Size = new System.Drawing.Size(466, 27);
            this.lblNovoEditarFlashcard.TabIndex = 32;
            this.lblNovoEditarFlashcard.Text = "Novo Flashcard";
            this.lblNovoEditarFlashcard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbNovoFlashcard
            // 
            this.gbNovoFlashcard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNovoFlashcard.Controls.Add(this.btnCancelarEdicao);
            this.gbNovoFlashcard.Controls.Add(this.pnImagem);
            this.gbNovoFlashcard.Controls.Add(this.btnEscolherImagem);
            this.gbNovoFlashcard.Controls.Add(this.rbImagem);
            this.gbNovoFlashcard.Controls.Add(this.rbTexto);
            this.gbNovoFlashcard.Controls.Add(this.txtPalavraChave);
            this.gbNovoFlashcard.Controls.Add(this.cbxCategoria);
            this.gbNovoFlashcard.Controls.Add(this.txtDefinicao);
            this.gbNovoFlashcard.Controls.Add(this.btnAdicionarEditarFlashcard);
            this.gbNovoFlashcard.Controls.Add(this.label7);
            this.gbNovoFlashcard.Controls.Add(this.label8);
            this.gbNovoFlashcard.Controls.Add(this.label9);
            this.gbNovoFlashcard.Enabled = false;
            this.gbNovoFlashcard.Location = new System.Drawing.Point(3, 22);
            this.gbNovoFlashcard.Name = "gbNovoFlashcard";
            this.gbNovoFlashcard.Size = new System.Drawing.Size(459, 245);
            this.gbNovoFlashcard.TabIndex = 42;
            this.gbNovoFlashcard.TabStop = false;
            // 
            // btnCancelarEdicao
            // 
            this.btnCancelarEdicao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelarEdicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelarEdicao.Enabled = false;
            this.btnCancelarEdicao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelarEdicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEdicao.ForeColor = System.Drawing.Color.White;
            this.btnCancelarEdicao.Location = new System.Drawing.Point(204, 200);
            this.btnCancelarEdicao.Name = "btnCancelarEdicao";
            this.btnCancelarEdicao.Size = new System.Drawing.Size(152, 40);
            this.btnCancelarEdicao.TabIndex = 14;
            this.btnCancelarEdicao.Text = "Cancelar";
            this.btnCancelarEdicao.UseVisualStyleBackColor = false;
            this.btnCancelarEdicao.Visible = false;
            this.btnCancelarEdicao.Click += new System.EventHandler(this.btnCancelarEdicao_Click);
            // 
            // pnImagem
            // 
            this.pnImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnImagem.Location = new System.Drawing.Point(244, 96);
            this.pnImagem.Name = "pnImagem";
            this.pnImagem.Size = new System.Drawing.Size(100, 100);
            this.pnImagem.TabIndex = 13;
            this.pnImagem.Visible = false;
            // 
            // btnEscolherImagem
            // 
            this.btnEscolherImagem.BackColor = System.Drawing.Color.LightGray;
            this.btnEscolherImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscolherImagem.Image = ((System.Drawing.Image)(resources.GetObject("btnEscolherImagem.Image")));
            this.btnEscolherImagem.Location = new System.Drawing.Point(148, 96);
            this.btnEscolherImagem.Name = "btnEscolherImagem";
            this.btnEscolherImagem.Size = new System.Drawing.Size(56, 31);
            this.btnEscolherImagem.TabIndex = 12;
            this.btnEscolherImagem.UseVisualStyleBackColor = false;
            this.btnEscolherImagem.Visible = false;
            this.btnEscolherImagem.Click += new System.EventHandler(this.btnEscolherImagem_Click);
            // 
            // rbImagem
            // 
            this.rbImagem.AutoSize = true;
            this.rbImagem.Location = new System.Drawing.Point(15, 150);
            this.rbImagem.Name = "rbImagem";
            this.rbImagem.Size = new System.Drawing.Size(105, 26);
            this.rbImagem.TabIndex = 11;
            this.rbImagem.Text = "Imagem";
            this.rbImagem.UseVisualStyleBackColor = true;
            this.rbImagem.CheckedChanged += new System.EventHandler(this.rbImagem_CheckedChanged);
            // 
            // rbTexto
            // 
            this.rbTexto.AutoSize = true;
            this.rbTexto.Checked = true;
            this.rbTexto.Location = new System.Drawing.Point(15, 120);
            this.rbTexto.Name = "rbTexto";
            this.rbTexto.Size = new System.Drawing.Size(76, 26);
            this.rbTexto.TabIndex = 10;
            this.rbTexto.TabStop = true;
            this.rbTexto.Text = "Texto";
            this.rbTexto.UseVisualStyleBackColor = true;
            this.rbTexto.CheckedChanged += new System.EventHandler(this.rbTexto_CheckedChanged);
            // 
            // txtPalavraChave
            // 
            this.txtPalavraChave.Location = new System.Drawing.Point(148, 21);
            this.txtPalavraChave.MaxLength = 50;
            this.txtPalavraChave.Name = "txtPalavraChave";
            this.txtPalavraChave.Size = new System.Drawing.Size(303, 31);
            this.txtPalavraChave.TabIndex = 9;
            this.txtPalavraChave.TextChanged += new System.EventHandler(this.txtPalavraChave_TextChanged);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(148, 58);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(303, 30);
            this.cbxCategoria.TabIndex = 7;
            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged);
            // 
            // txtDefinicao
            // 
            this.txtDefinicao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDefinicao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefinicao.Location = new System.Drawing.Point(388, 98);
            this.txtDefinicao.MaxLength = 120;
            this.txtDefinicao.Multiline = true;
            this.txtDefinicao.Name = "txtDefinicao";
            this.txtDefinicao.Size = new System.Drawing.Size(277, 86);
            this.txtDefinicao.TabIndex = 2;
            this.txtDefinicao.TextChanged += new System.EventHandler(this.txtDefinicao_TextChanged);
            // 
            // btnAdicionarEditarFlashcard
            // 
            this.btnAdicionarEditarFlashcard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdicionarEditarFlashcard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionarEditarFlashcard.Enabled = false;
            this.btnAdicionarEditarFlashcard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdicionarEditarFlashcard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarEditarFlashcard.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarEditarFlashcard.Location = new System.Drawing.Point(148, 200);
            this.btnAdicionarEditarFlashcard.Name = "btnAdicionarEditarFlashcard";
            this.btnAdicionarEditarFlashcard.Size = new System.Drawing.Size(152, 40);
            this.btnAdicionarEditarFlashcard.TabIndex = 3;
            this.btnAdicionarEditarFlashcard.Text = "Adicionar";
            this.btnAdicionarEditarFlashcard.UseVisualStyleBackColor = false;
            this.btnAdicionarEditarFlashcard.Click += new System.EventHandler(this.btnAdicionarEditarFlashcard_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.25F);
            this.label7.Location = new System.Drawing.Point(4, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Palavra-chave";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.25F);
            this.label8.Location = new System.Drawing.Point(4, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Categoria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.25F);
            this.label9.Location = new System.Drawing.Point(4, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Definição";
            // 
            // pnlListaItens
            // 
            this.pnlListaItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListaItens.Controls.Add(this.btnEditarFlashcard);
            this.pnlListaItens.Controls.Add(this.lsbFlashcards);
            this.pnlListaItens.Controls.Add(this.cbxExibirCategoria);
            this.pnlListaItens.Controls.Add(this.lblCategoria);
            this.pnlListaItens.Controls.Add(this.label3);
            this.pnlListaItens.Controls.Add(this.btnRemoverFlashcard);
            this.pnlListaItens.Location = new System.Drawing.Point(3, 2);
            this.pnlListaItens.Name = "pnlListaItens";
            this.pnlListaItens.Size = new System.Drawing.Size(238, 509);
            this.pnlListaItens.TabIndex = 44;
            this.pnlListaItens.Click += new System.EventHandler(this.tpGerenciar_Click);
            this.pnlListaItens.Resize += new System.EventHandler(this.pnlListaItens_Resize);
            // 
            // btnEditarFlashcard
            // 
            this.btnEditarFlashcard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditarFlashcard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditarFlashcard.Enabled = false;
            this.btnEditarFlashcard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEditarFlashcard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarFlashcard.ForeColor = System.Drawing.Color.White;
            this.btnEditarFlashcard.Location = new System.Drawing.Point(9, 469);
            this.btnEditarFlashcard.Name = "btnEditarFlashcard";
            this.btnEditarFlashcard.Size = new System.Drawing.Size(110, 35);
            this.btnEditarFlashcard.TabIndex = 39;
            this.btnEditarFlashcard.Text = "Editar";
            this.btnEditarFlashcard.UseVisualStyleBackColor = false;
            this.btnEditarFlashcard.Click += new System.EventHandler(this.btnEditarFlashcard_Click);
            // 
            // lsbFlashcards
            // 
            this.lsbFlashcards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbFlashcards.FormattingEnabled = true;
            this.lsbFlashcards.ItemHeight = 22;
            this.lsbFlashcards.Location = new System.Drawing.Point(9, 100);
            this.lsbFlashcards.Name = "lsbFlashcards";
            this.lsbFlashcards.Size = new System.Drawing.Size(224, 356);
            this.lsbFlashcards.TabIndex = 34;
            this.lsbFlashcards.SelectedIndexChanged += new System.EventHandler(this.lsbFlashcards_SelectedIndexChanged);
            // 
            // cbxExibirCategoria
            // 
            this.cbxExibirCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxExibirCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExibirCategoria.FormattingEnabled = true;
            this.cbxExibirCategoria.Location = new System.Drawing.Point(9, 61);
            this.cbxExibirCategoria.Name = "cbxExibirCategoria";
            this.cbxExibirCategoria.Size = new System.Drawing.Size(224, 30);
            this.cbxExibirCategoria.TabIndex = 35;
            this.cbxExibirCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxExibirCategoria_SelectedIndexChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.Location = new System.Drawing.Point(9, 36);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(223, 22);
            this.lblCategoria.TabIndex = 36;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 27);
            this.label3.TabIndex = 37;
            this.label3.Text = "Itens";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemoverFlashcard
            // 
            this.btnRemoverFlashcard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverFlashcard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemoverFlashcard.Enabled = false;
            this.btnRemoverFlashcard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoverFlashcard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverFlashcard.ForeColor = System.Drawing.Color.White;
            this.btnRemoverFlashcard.Location = new System.Drawing.Point(122, 469);
            this.btnRemoverFlashcard.Name = "btnRemoverFlashcard";
            this.btnRemoverFlashcard.Size = new System.Drawing.Size(110, 35);
            this.btnRemoverFlashcard.TabIndex = 38;
            this.btnRemoverFlashcard.Text = "Remover";
            this.btnRemoverFlashcard.UseVisualStyleBackColor = false;
            this.btnRemoverFlashcard.Click += new System.EventHandler(this.btnRemoverFlashcard_Click);
            // 
            // pnlDivisaoHorizontal
            // 
            this.pnlDivisaoHorizontal.BackColor = System.Drawing.Color.Black;
            this.pnlDivisaoHorizontal.Location = new System.Drawing.Point(242, 267);
            this.pnlDivisaoHorizontal.Name = "pnlDivisaoHorizontal";
            this.pnlDivisaoHorizontal.Size = new System.Drawing.Size(470, 1);
            this.pnlDivisaoHorizontal.TabIndex = 43;
            // 
            // pnlDivisaoVertical
            // 
            this.pnlDivisaoVertical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivisaoVertical.BackColor = System.Drawing.Color.Black;
            this.pnlDivisaoVertical.Location = new System.Drawing.Point(241, -2);
            this.pnlDivisaoVertical.Name = "pnlDivisaoVertical";
            this.pnlDivisaoVertical.Size = new System.Drawing.Size(1, 520);
            this.pnlDivisaoVertical.TabIndex = 39;
            // 
            // ofdImgFlashcard
            // 
            this.ofdImgFlashcard.FileName = "Flashcard";
            this.ofdImgFlashcard.Filter = "Arquivos de Imagem | *.png; *.jpg; *.jpeg; *.gif";
            // 
            // UcFlashcards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UcFlashcards";
            this.Size = new System.Drawing.Size(718, 558);
            this.Load += new System.EventHandler(this.UcFlashcards_Load);
            this.Resize += new System.EventHandler(this.UcFlashcards_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tpGerenciar.ResumeLayout(false);
            this.pnlCategorias.ResumeLayout(false);
            this.gbAdicionarCategoria.ResumeLayout(false);
            this.gbAdicionarCategoria.PerformLayout();
            this.pnlNovoFlashcard.ResumeLayout(false);
            this.gbNovoFlashcard.ResumeLayout(false);
            this.gbNovoFlashcard.PerformLayout();
            this.pnlListaItens.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpGerenciar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlDivisaoHorizontal;
        private System.Windows.Forms.Label lblNovoEditarFlashcard;
        private System.Windows.Forms.GroupBox gbAdicionarCategoria;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdicionarCategoria;
        private System.Windows.Forms.Button btnRemoverCategoria;
        private System.Windows.Forms.ListBox lsbCategorias;
        private System.Windows.Forms.Panel pnlDivisaoVertical;
        private System.Windows.Forms.Button btnRemoverFlashcard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxExibirCategoria;
        private System.Windows.Forms.ListBox lsbFlashcards;
        private System.Windows.Forms.GroupBox gbNovoFlashcard;
        private System.Windows.Forms.RadioButton rbImagem;
        private System.Windows.Forms.RadioButton rbTexto;
        private System.Windows.Forms.TextBox txtPalavraChave;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.TextBox txtDefinicao;
        private System.Windows.Forms.Button btnAdicionarEditarFlashcard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEscolherImagem;
        private System.Windows.Forms.OpenFileDialog ofdImgFlashcard;
        private System.Windows.Forms.Panel pnImagem;
        private System.Windows.Forms.Panel pnlListaItens;
        private System.Windows.Forms.Panel pnlNovoFlashcard;
        private System.Windows.Forms.Panel pnlCategorias;
        private System.Windows.Forms.Button btnEditarFlashcard;
        private System.Windows.Forms.Button btnCancelarEdicao;
    }
}
