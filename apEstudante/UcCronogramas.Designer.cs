namespace apEstudante
{
    partial class UcCronogramas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcCronogramas));
            this.label1 = new System.Windows.Forms.Label();
            this.dgCronogramas = new System.Windows.Forms.DataGridView();
            this.clDomingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSegunda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTerca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuarta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuinta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSexta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoverSelecionado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxDia = new System.Windows.Forms.ComboBox();
            this.gbAdicionar = new System.Windows.Forms.GroupBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlLista = new System.Windows.Forms.Panel();
            this.switcher1 = new apAplicativos.Switcher();
            this.btnCheckUncheck = new System.Windows.Forms.Button();
            this.btnRemoverConteudo = new System.Windows.Forms.Button();
            this.dgvConteudos = new System.Windows.Forms.DataGridView();
            this.clConteudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFeito = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlControleDaLista = new System.Windows.Forms.Panel();
            this.btnRemoverMateria = new System.Windows.Forms.Button();
            this.btnAdicionarMateria2 = new System.Windows.Forms.Button();
            this.chkNegrito = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.txtMateria2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdicionarConteudo = new System.Windows.Forms.Button();
            this.imlChecked = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgCronogramas)).BeginInit();
            this.gbAdicionar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConteudos)).BeginInit();
            this.pnlControleDaLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planejamento";
            // 
            // dgCronogramas
            // 
            this.dgCronogramas.AllowUserToAddRows = false;
            this.dgCronogramas.AllowUserToDeleteRows = false;
            this.dgCronogramas.AllowUserToResizeRows = false;
            this.dgCronogramas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCronogramas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgCronogramas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCronogramas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDomingo,
            this.clSegunda,
            this.clTerca,
            this.clQuarta,
            this.clQuinta,
            this.clSexta,
            this.clSabado});
            this.dgCronogramas.Location = new System.Drawing.Point(2, 11);
            this.dgCronogramas.MultiSelect = false;
            this.dgCronogramas.Name = "dgCronogramas";
            this.dgCronogramas.RowHeadersWidth = 80;
            this.dgCronogramas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgCronogramas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgCronogramas.Size = new System.Drawing.Size(712, 244);
            this.dgCronogramas.TabIndex = 1;
            this.dgCronogramas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCronogramas_CellClick);
            this.dgCronogramas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCronogramas_CellDoubleClick);
            this.dgCronogramas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCronogramas_CellEndEdit);
            this.dgCronogramas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgCronogramas_KeyDown);
            // 
            // clDomingo
            // 
            this.clDomingo.HeaderText = "Domingo";
            this.clDomingo.MinimumWidth = 90;
            this.clDomingo.Name = "clDomingo";
            this.clDomingo.Width = 90;
            // 
            // clSegunda
            // 
            this.clSegunda.HeaderText = "Segunda";
            this.clSegunda.MinimumWidth = 90;
            this.clSegunda.Name = "clSegunda";
            this.clSegunda.Width = 90;
            // 
            // clTerca
            // 
            this.clTerca.HeaderText = "Terça";
            this.clTerca.MinimumWidth = 90;
            this.clTerca.Name = "clTerca";
            this.clTerca.Width = 90;
            // 
            // clQuarta
            // 
            this.clQuarta.HeaderText = "Quarta";
            this.clQuarta.MinimumWidth = 90;
            this.clQuarta.Name = "clQuarta";
            this.clQuarta.Width = 90;
            // 
            // clQuinta
            // 
            this.clQuinta.HeaderText = "Quinta";
            this.clQuinta.MinimumWidth = 90;
            this.clQuinta.Name = "clQuinta";
            this.clQuinta.Width = 90;
            // 
            // clSexta
            // 
            this.clSexta.HeaderText = "Sexta";
            this.clSexta.MinimumWidth = 90;
            this.clSexta.Name = "clSexta";
            this.clSexta.Width = 90;
            // 
            // clSabado
            // 
            this.clSabado.HeaderText = "Sábado";
            this.clSabado.MinimumWidth = 90;
            this.clSabado.Name = "clSabado";
            this.clSabado.Width = 90;
            // 
            // txtHorario
            // 
            this.txtHorario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHorario.Location = new System.Drawing.Point(97, 96);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(267, 31);
            this.txtHorario.TabIndex = 2;
            this.txtHorario.TextChanged += new System.EventHandler(this.txtHorario_TextChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(124, 139);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(131, 40);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Horário";
            // 
            // btnRemoverSelecionado
            // 
            this.btnRemoverSelecionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoverSelecionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemoverSelecionado.Enabled = false;
            this.btnRemoverSelecionado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoverSelecionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverSelecionado.ForeColor = System.Drawing.Color.White;
            this.btnRemoverSelecionado.Location = new System.Drawing.Point(243, 259);
            this.btnRemoverSelecionado.Name = "btnRemoverSelecionado";
            this.btnRemoverSelecionado.Size = new System.Drawing.Size(237, 35);
            this.btnRemoverSelecionado.TabIndex = 5;
            this.btnRemoverSelecionado.Text = "Remover Selecionado";
            this.btnRemoverSelecionado.UseVisualStyleBackColor = false;
            this.btnRemoverSelecionado.Click += new System.EventHandler(this.btnRemoverSelecionado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dia";
            // 
            // cbxDia
            // 
            this.cbxDia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDia.FormattingEnabled = true;
            this.cbxDia.Items.AddRange(new object[] {
            "Domingo",
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta",
            "Sábado"});
            this.cbxDia.Location = new System.Drawing.Point(97, 61);
            this.cbxDia.Name = "cbxDia";
            this.cbxDia.Size = new System.Drawing.Size(267, 30);
            this.cbxDia.TabIndex = 7;
            this.cbxDia.SelectedIndexChanged += new System.EventHandler(this.cbxDia_SelectedIndexChanged);
            // 
            // gbAdicionar
            // 
            this.gbAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbAdicionar.Controls.Add(this.txtMateria);
            this.gbAdicionar.Controls.Add(this.label4);
            this.gbAdicionar.Controls.Add(this.label3);
            this.gbAdicionar.Controls.Add(this.cbxDia);
            this.gbAdicionar.Controls.Add(this.txtHorario);
            this.gbAdicionar.Controls.Add(this.btnAdicionar);
            this.gbAdicionar.Controls.Add(this.label2);
            this.gbAdicionar.Location = new System.Drawing.Point(173, 317);
            this.gbAdicionar.Name = "gbAdicionar";
            this.gbAdicionar.Size = new System.Drawing.Size(379, 184);
            this.gbAdicionar.TabIndex = 8;
            this.gbAdicionar.TabStop = false;
            // 
            // txtMateria
            // 
            this.txtMateria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMateria.Location = new System.Drawing.Point(97, 26);
            this.txtMateria.MaxLength = 50;
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(267, 31);
            this.txtMateria.TabIndex = 9;
            this.txtMateria.TextChanged += new System.EventHandler(this.txtMateria_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Matéria";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(733, 550);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgCronogramas);
            this.tabPage1.Controls.Add(this.gbAdicionar);
            this.tabPage1.Controls.Add(this.btnRemoverSelecionado);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(725, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cronograma";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlLista);
            this.tabPage2.Controls.Add(this.pnlControleDaLista);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(725, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Matérias";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Click);
            // 
            // pnlLista
            // 
            this.pnlLista.Controls.Add(this.switcher1);
            this.pnlLista.Controls.Add(this.btnCheckUncheck);
            this.pnlLista.Controls.Add(this.btnRemoverConteudo);
            this.pnlLista.Controls.Add(this.dgvConteudos);
            this.pnlLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLista.Location = new System.Drawing.Point(3, 3);
            this.pnlLista.Name = "pnlLista";
            this.pnlLista.Size = new System.Drawing.Size(408, 509);
            this.pnlLista.TabIndex = 21;
            // 
            // switcher1
            // 
            this.switcher1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switcher1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switcher1.Location = new System.Drawing.Point(2, 1);
            this.switcher1.Margin = new System.Windows.Forms.Padding(6);
            this.switcher1.Name = "switcher1";
            this.switcher1.Size = new System.Drawing.Size(404, 48);
            this.switcher1.TabIndex = 17;
            this.switcher1.IndiceAtualMudou += new System.EventHandler<System.EventArgs>(this.switcher1_IndiceAtualMudou);
            // 
            // btnCheckUncheck
            // 
            this.btnCheckUncheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckUncheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheckUncheck.Enabled = false;
            this.btnCheckUncheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCheckUncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckUncheck.ForeColor = System.Drawing.Color.White;
            this.btnCheckUncheck.Location = new System.Drawing.Point(2, 469);
            this.btnCheckUncheck.Name = "btnCheckUncheck";
            this.btnCheckUncheck.Size = new System.Drawing.Size(194, 40);
            this.btnCheckUncheck.TabIndex = 4;
            this.btnCheckUncheck.Text = "Check";
            this.btnCheckUncheck.UseVisualStyleBackColor = false;
            this.btnCheckUncheck.Click += new System.EventHandler(this.btnCheckUncheck_Click);
            // 
            // btnRemoverConteudo
            // 
            this.btnRemoverConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemoverConteudo.Enabled = false;
            this.btnRemoverConteudo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoverConteudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverConteudo.ForeColor = System.Drawing.Color.White;
            this.btnRemoverConteudo.Location = new System.Drawing.Point(211, 469);
            this.btnRemoverConteudo.Name = "btnRemoverConteudo";
            this.btnRemoverConteudo.Size = new System.Drawing.Size(195, 40);
            this.btnRemoverConteudo.TabIndex = 5;
            this.btnRemoverConteudo.Text = "Remover";
            this.btnRemoverConteudo.UseVisualStyleBackColor = false;
            this.btnRemoverConteudo.Click += new System.EventHandler(this.btnRemoverConteudo_Click);
            // 
            // dgvConteudos
            // 
            this.dgvConteudos.AllowUserToAddRows = false;
            this.dgvConteudos.AllowUserToDeleteRows = false;
            this.dgvConteudos.AllowUserToResizeColumns = false;
            this.dgvConteudos.AllowUserToResizeRows = false;
            this.dgvConteudos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConteudos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvConteudos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConteudos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvConteudos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConteudos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clConteudo,
            this.clFeito});
            this.dgvConteudos.Location = new System.Drawing.Point(2, 59);
            this.dgvConteudos.Name = "dgvConteudos";
            this.dgvConteudos.ReadOnly = true;
            this.dgvConteudos.RowHeadersVisible = false;
            this.dgvConteudos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvConteudos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConteudos.Size = new System.Drawing.Size(404, 404);
            this.dgvConteudos.TabIndex = 18;
            this.dgvConteudos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConteudos_CellClick);
            // 
            // clConteudo
            // 
            this.clConteudo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clConteudo.HeaderText = "Conteúdo";
            this.clConteudo.Name = "clConteudo";
            this.clConteudo.ReadOnly = true;
            this.clConteudo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clFeito
            // 
            this.clFeito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clFeito.HeaderText = "✓";
            this.clFeito.Image = ((System.Drawing.Image)(resources.GetObject("clFeito.Image")));
            this.clFeito.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.clFeito.Name = "clFeito";
            this.clFeito.ReadOnly = true;
            this.clFeito.Width = 50;
            // 
            // pnlControleDaLista
            // 
            this.pnlControleDaLista.Controls.Add(this.btnRemoverMateria);
            this.pnlControleDaLista.Controls.Add(this.btnAdicionarMateria2);
            this.pnlControleDaLista.Controls.Add(this.chkNegrito);
            this.pnlControleDaLista.Controls.Add(this.label5);
            this.pnlControleDaLista.Controls.Add(this.txtConteudo);
            this.pnlControleDaLista.Controls.Add(this.txtMateria2);
            this.pnlControleDaLista.Controls.Add(this.label6);
            this.pnlControleDaLista.Controls.Add(this.btnAdicionarConteudo);
            this.pnlControleDaLista.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControleDaLista.Location = new System.Drawing.Point(411, 3);
            this.pnlControleDaLista.Name = "pnlControleDaLista";
            this.pnlControleDaLista.Size = new System.Drawing.Size(311, 509);
            this.pnlControleDaLista.TabIndex = 22;
            // 
            // btnRemoverMateria
            // 
            this.btnRemoverMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemoverMateria.Enabled = false;
            this.btnRemoverMateria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoverMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverMateria.ForeColor = System.Drawing.Color.White;
            this.btnRemoverMateria.Location = new System.Drawing.Point(13, 4);
            this.btnRemoverMateria.Name = "btnRemoverMateria";
            this.btnRemoverMateria.Size = new System.Drawing.Size(196, 40);
            this.btnRemoverMateria.TabIndex = 20;
            this.btnRemoverMateria.Text = "Remover Matéria";
            this.btnRemoverMateria.UseVisualStyleBackColor = false;
            this.btnRemoverMateria.Click += new System.EventHandler(this.btnRemoverMateria_Click);
            // 
            // btnAdicionarMateria2
            // 
            this.btnAdicionarMateria2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarMateria2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionarMateria2.Enabled = false;
            this.btnAdicionarMateria2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdicionarMateria2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarMateria2.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.btnAdicionarMateria2.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarMateria2.Location = new System.Drawing.Point(102, 173);
            this.btnAdicionarMateria2.Name = "btnAdicionarMateria2";
            this.btnAdicionarMateria2.Size = new System.Drawing.Size(201, 40);
            this.btnAdicionarMateria2.TabIndex = 10;
            this.btnAdicionarMateria2.Text = "Adicionar";
            this.btnAdicionarMateria2.UseVisualStyleBackColor = false;
            this.btnAdicionarMateria2.Click += new System.EventHandler(this.btnAdicionarMateria2_Click);
            // 
            // chkNegrito
            // 
            this.chkNegrito.AutoSize = true;
            this.chkNegrito.Enabled = false;
            this.chkNegrito.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.chkNegrito.Location = new System.Drawing.Point(109, 308);
            this.chkNegrito.Name = "chkNegrito";
            this.chkNegrito.Size = new System.Drawing.Size(93, 25);
            this.chkNegrito.TabIndex = 19;
            this.chkNegrito.Text = "Negrito";
            this.chkNegrito.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label5.Location = new System.Drawing.Point(23, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Matéria";
            // 
            // txtConteudo
            // 
            this.txtConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConteudo.Enabled = false;
            this.txtConteudo.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.txtConteudo.Location = new System.Drawing.Point(102, 276);
            this.txtConteudo.MaxLength = 34;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(201, 29);
            this.txtConteudo.TabIndex = 15;
            this.txtConteudo.TextChanged += new System.EventHandler(this.txtConteudo_TextChanged);
            // 
            // txtMateria2
            // 
            this.txtMateria2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMateria2.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.txtMateria2.Location = new System.Drawing.Point(102, 137);
            this.txtMateria2.MaxLength = 30;
            this.txtMateria2.Name = "txtMateria2";
            this.txtMateria2.Size = new System.Drawing.Size(201, 29);
            this.txtMateria2.TabIndex = 12;
            this.txtMateria2.TextChanged += new System.EventHandler(this.txtMateria2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label6.Location = new System.Drawing.Point(2, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Conteúdo";
            // 
            // btnAdicionarConteudo
            // 
            this.btnAdicionarConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionarConteudo.Enabled = false;
            this.btnAdicionarConteudo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdicionarConteudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarConteudo.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.btnAdicionarConteudo.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarConteudo.Location = new System.Drawing.Point(102, 335);
            this.btnAdicionarConteudo.Name = "btnAdicionarConteudo";
            this.btnAdicionarConteudo.Size = new System.Drawing.Size(201, 40);
            this.btnAdicionarConteudo.TabIndex = 13;
            this.btnAdicionarConteudo.Text = "Adicionar";
            this.btnAdicionarConteudo.UseVisualStyleBackColor = false;
            this.btnAdicionarConteudo.Click += new System.EventHandler(this.btnAdicionarConteudo_Click);
            // 
            // imlChecked
            // 
            this.imlChecked.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlChecked.ImageStream")));
            this.imlChecked.TransparentColor = System.Drawing.Color.Transparent;
            this.imlChecked.Images.SetKeyName(0, "checked-1.png");
            // 
            // UcCronogramas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UcCronogramas";
            this.Size = new System.Drawing.Size(718, 558);
            this.Load += new System.EventHandler(this.UcCronogramas_Load);
            this.Resize += new System.EventHandler(this.UcCronogramas_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgCronogramas)).EndInit();
            this.gbAdicionar.ResumeLayout(false);
            this.gbAdicionar.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.pnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConteudos)).EndInit();
            this.pnlControleDaLista.ResumeLayout(false);
            this.pnlControleDaLista.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCronogramas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDomingo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSegunda;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTerca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuarta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuinta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSexta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSabado;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoverSelecionado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxDia;
        private System.Windows.Forms.GroupBox gbAdicionar;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCheckUncheck;
        private System.Windows.Forms.Button btnRemoverConteudo;
        private System.Windows.Forms.TextBox txtMateria2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdicionarMateria2;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdicionarConteudo;
        private apAplicativos.Switcher switcher1;
        private System.Windows.Forms.ImageList imlChecked;
        private System.Windows.Forms.DataGridView dgvConteudos;
        private System.Windows.Forms.CheckBox chkNegrito;
        private System.Windows.Forms.Button btnRemoverMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clConteudo;
        private System.Windows.Forms.DataGridViewImageColumn clFeito;
        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.Panel pnlControleDaLista;
    }
}
