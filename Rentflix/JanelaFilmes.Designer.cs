namespace Rentflix
{
    partial class JanelaFilmes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaFilmes));
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.censura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distribuicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLanc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCensura = new System.Windows.Forms.ComboBox();
            this.dtDataLancamento = new System.Windows.Forms.DateTimePicker();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDistrubuicao = new System.Windows.Forms.TextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstAtores = new System.Windows.Forms.ListBox();
            this.txtAtores = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblImgNaoEnc = new System.Windows.Forms.PictureBox();
            this.lblAddImg = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.btnAddGenero = new System.Windows.Forms.PictureBox();
            this.btnAddAtor = new System.Windows.Forms.PictureBox();
            this.btnRemAtor = new System.Windows.Forms.PictureBox();
            this.btnNovo = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.btnCancelaImg = new System.Windows.Forms.PictureBox();
            this.pbxImagem = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblImgNaoEnc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAddImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAtor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemAtor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelaImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabela
            // 
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulo,
            this.preco,
            this.multa,
            this.genero,
            this.censura,
            this.distribuicao,
            this.dataLanc});
            this.dgvTabela.Location = new System.Drawing.Point(40, 332);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.ReadOnly = true;
            this.dgvTabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabela.Size = new System.Drawing.Size(738, 159);
            this.dgvTabela.TabIndex = 59;
            this.dgvTabela.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabela_CellClick);
            this.dgvTabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabela_CellContentClick);
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.Width = 180;
            // 
            // preco
            // 
            this.preco.HeaderText = "Preço(R$)";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            this.preco.Width = 75;
            // 
            // multa
            // 
            this.multa.HeaderText = "Multa(Diária)";
            this.multa.Name = "multa";
            this.multa.ReadOnly = true;
            this.multa.Width = 75;
            // 
            // genero
            // 
            this.genero.HeaderText = "Gênero";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            this.genero.Width = 105;
            // 
            // censura
            // 
            this.censura.HeaderText = "Censura";
            this.censura.Name = "censura";
            this.censura.ReadOnly = true;
            this.censura.Width = 60;
            // 
            // distribuicao
            // 
            this.distribuicao.HeaderText = "Distribuição";
            this.distribuicao.Name = "distribuicao";
            this.distribuicao.ReadOnly = true;
            // 
            // dataLanc
            // 
            this.dataLanc.HeaderText = "Data de Lanc.";
            this.dataLanc.Name = "dataLanc";
            this.dataLanc.ReadOnly = true;
            // 
            // cmbCensura
            // 
            this.cmbCensura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCensura.Enabled = false;
            this.cmbCensura.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbCensura.FormattingEnabled = true;
            this.cmbCensura.Items.AddRange(new object[] {
            "Livre",
            "10+",
            "12+",
            "14+",
            "16+",
            "18+"});
            this.cmbCensura.Location = new System.Drawing.Point(131, 157);
            this.cmbCensura.Name = "cmbCensura";
            this.cmbCensura.Size = new System.Drawing.Size(101, 31);
            this.cmbCensura.TabIndex = 3;
            // 
            // dtDataLancamento
            // 
            this.dtDataLancamento.Enabled = false;
            this.dtDataLancamento.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataLancamento.Location = new System.Drawing.Point(430, 114);
            this.dtDataLancamento.Name = "dtDataLancamento";
            this.dtDataLancamento.Size = new System.Drawing.Size(116, 30);
            this.dtDataLancamento.TabIndex = 2;
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(131, 243);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(126, 30);
            this.txtPreco.TabIndex = 5;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(133, 73);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(416, 30);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTitulo_KeyUp);
            this.txtTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtTitulo_MouseUp);
            // 
            // txtDistrubuicao
            // 
            this.txtDistrubuicao.Enabled = false;
            this.txtDistrubuicao.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistrubuicao.Location = new System.Drawing.Point(131, 199);
            this.txtDistrubuicao.Name = "txtDistrubuicao";
            this.txtDistrubuicao.Size = new System.Drawing.Size(126, 30);
            this.txtDistrubuicao.TabIndex = 4;
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.Enabled = false;
            this.cmbGenero.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbGenero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbGenero.Location = new System.Drawing.Point(132, 114);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(100, 31);
            this.cmbGenero.TabIndex = 1;
            // 
            // txtMulta
            // 
            this.txtMulta.Enabled = false;
            this.txtMulta.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMulta.Location = new System.Drawing.Point(130, 285);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(126, 30);
            this.txtMulta.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(822, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 511);
            this.panel1.TabIndex = 66;
            // 
            // lstAtores
            // 
            this.lstAtores.Enabled = false;
            this.lstAtores.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold);
            this.lstAtores.FormattingEnabled = true;
            this.lstAtores.ItemHeight = 23;
            this.lstAtores.Location = new System.Drawing.Point(263, 219);
            this.lstAtores.Name = "lstAtores";
            this.lstAtores.Size = new System.Drawing.Size(245, 96);
            this.lstAtores.TabIndex = 68;
            // 
            // txtAtores
            // 
            this.txtAtores.Enabled = false;
            this.txtAtores.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtores.Location = new System.Drawing.Point(263, 182);
            this.txtAtores.Name = "txtAtores";
            this.txtAtores.Size = new System.Drawing.Size(245, 30);
            this.txtAtores.TabIndex = 7;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.ReshowDelay = 500;
            this.toolTip1.ShowAlways = true;
            // 
            // lblImgNaoEnc
            // 
            this.lblImgNaoEnc.Image = global::Rentflix.Properties.Resources.imgNaoEnc;
            this.lblImgNaoEnc.Location = new System.Drawing.Point(594, 252);
            this.lblImgNaoEnc.Name = "lblImgNaoEnc";
            this.lblImgNaoEnc.Size = new System.Drawing.Size(100, 51);
            this.lblImgNaoEnc.TabIndex = 112;
            this.lblImgNaoEnc.TabStop = false;
            this.lblImgNaoEnc.Visible = false;
            // 
            // lblAddImg
            // 
            this.lblAddImg.Image = global::Rentflix.Properties.Resources.addImg;
            this.lblAddImg.Location = new System.Drawing.Point(572, 216);
            this.lblAddImg.Name = "lblAddImg";
            this.lblAddImg.Size = new System.Drawing.Size(142, 25);
            this.lblAddImg.TabIndex = 111;
            this.lblAddImg.TabStop = false;
            this.lblAddImg.Click += new System.EventHandler(this.buscarImagem);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Rentflix.Properties.Resources.Img;
            this.pictureBox11.Location = new System.Drawing.Point(559, 115);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(61, 25);
            this.pictureBox11.TabIndex = 110;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Rentflix.Properties.Resources.dataLancamento;
            this.pictureBox10.Location = new System.Drawing.Point(265, 115);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(162, 25);
            this.pictureBox10.TabIndex = 109;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Rentflix.Properties.Resources.titulo;
            this.pictureBox3.Location = new System.Drawing.Point(61, 75);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 25);
            this.pictureBox3.TabIndex = 102;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rentflix.Properties.Resources.Filmes;
            this.pictureBox1.Location = new System.Drawing.Point(368, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 50);
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Rentflix.Properties.Resources.Rentflix;
            this.pictureBox13.Location = new System.Drawing.Point(14, 7);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(103, 33);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 99;
            this.pictureBox13.TabStop = false;
            // 
            // btnAddGenero
            // 
            this.btnAddGenero.Image = global::Rentflix.Properties.Resources.Add;
            this.btnAddGenero.Location = new System.Drawing.Point(234, 116);
            this.btnAddGenero.Name = "btnAddGenero";
            this.btnAddGenero.Size = new System.Drawing.Size(25, 28);
            this.btnAddGenero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddGenero.TabIndex = 73;
            this.btnAddGenero.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAddGenero, "Cadastrar gênero");
            this.btnAddGenero.Click += new System.EventHandler(this.btnAddGenero_Click);
            this.btnAddGenero.MouseLeave += new System.EventHandler(this.btnCancelaImg_MouseLeave);
            this.btnAddGenero.MouseHover += new System.EventHandler(this.btnCancelaImg_MouseHover);
            // 
            // btnAddAtor
            // 
            this.btnAddAtor.Enabled = false;
            this.btnAddAtor.Image = global::Rentflix.Properties.Resources.NovoFal;
            this.btnAddAtor.Location = new System.Drawing.Point(514, 180);
            this.btnAddAtor.Name = "btnAddAtor";
            this.btnAddAtor.Size = new System.Drawing.Size(33, 36);
            this.btnAddAtor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddAtor.TabIndex = 71;
            this.btnAddAtor.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAddAtor, "Adicionar ator");
            this.btnAddAtor.Click += new System.EventHandler(this.btnAddAtor_Click);
            this.btnAddAtor.MouseLeave += new System.EventHandler(this.btnCancelaImg_MouseLeave);
            this.btnAddAtor.MouseHover += new System.EventHandler(this.btnCancelaImg_MouseHover);
            // 
            // btnRemAtor
            // 
            this.btnRemAtor.Enabled = false;
            this.btnRemAtor.Image = global::Rentflix.Properties.Resources.CancelarFal;
            this.btnRemAtor.Location = new System.Drawing.Point(516, 279);
            this.btnRemAtor.Name = "btnRemAtor";
            this.btnRemAtor.Size = new System.Drawing.Size(33, 36);
            this.btnRemAtor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRemAtor.TabIndex = 70;
            this.btnRemAtor.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRemAtor, "Remover ator");
            this.btnRemAtor.Click += new System.EventHandler(this.btnRemAtor_Click);
            this.btnRemAtor.MouseLeave += new System.EventHandler(this.btnCancelaImg_MouseLeave);
            this.btnRemAtor.MouseHover += new System.EventHandler(this.btnCancelaImg_MouseHover);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::Rentflix.Properties.Resources.Novo;
            this.btnNovo.Location = new System.Drawing.Point(3, 53);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(63, 67);
            this.btnNovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNovo.TabIndex = 4;
            this.btnNovo.TabStop = false;
            this.toolTip1.SetToolTip(this.btnNovo, "Novo");
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            this.btnNovo.MouseLeave += new System.EventHandler(this.btnCancelaImg_MouseLeave);
            this.btnNovo.MouseHover += new System.EventHandler(this.btnCancelaImg_MouseHover);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::Rentflix.Properties.Resources.EditarFal;
            this.btnEditar.Location = new System.Drawing.Point(3, 130);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(63, 67);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditar.TabIndex = 3;
            this.btnEditar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.MouseLeave += new System.EventHandler(this.btnCancelaImg_MouseLeave);
            this.btnEditar.MouseHover += new System.EventHandler(this.btnCancelaImg_MouseHover);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::Rentflix.Properties.Resources.ExcluirFal;
            this.btnExcluir.Location = new System.Drawing.Point(3, 208);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(63, 67);
            this.btnExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.TabStop = false;
            this.toolTip1.SetToolTip(this.btnExcluir, "Excluir");
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            this.btnExcluir.MouseLeave += new System.EventHandler(this.btnCancelaImg_MouseLeave);
            this.btnExcluir.MouseHover += new System.EventHandler(this.btnCancelaImg_MouseHover);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = global::Rentflix.Properties.Resources.SalvarFal;
            this.btnSalvar.Location = new System.Drawing.Point(3, 306);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(63, 67);
            this.btnSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.MouseLeave += new System.EventHandler(this.btnCancelaImg_MouseLeave);
            this.btnSalvar.MouseHover += new System.EventHandler(this.btnCancelaImg_MouseHover);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::Rentflix.Properties.Resources.CancelarFal;
            this.btnCancelar.Location = new System.Drawing.Point(3, 386);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(63, 67);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelaImg_MouseLeave);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btnCancelaImg_MouseHover);
            // 
            // btnCancelaImg
            // 
            this.btnCancelaImg.Enabled = false;
            this.btnCancelaImg.Image = global::Rentflix.Properties.Resources.CancelarFal;
            this.btnCancelaImg.Location = new System.Drawing.Point(735, 272);
            this.btnCancelaImg.Name = "btnCancelaImg";
            this.btnCancelaImg.Size = new System.Drawing.Size(43, 43);
            this.btnCancelaImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelaImg.TabIndex = 62;
            this.btnCancelaImg.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCancelaImg, "Remover imagem");
            this.btnCancelaImg.Click += new System.EventHandler(this.btnCancelaImg_Click);
            this.btnCancelaImg.MouseLeave += new System.EventHandler(this.btnCancelaImg_MouseLeave);
            this.btnCancelaImg.MouseHover += new System.EventHandler(this.btnCancelaImg_MouseHover);
            // 
            // pbxImagem
            // 
            this.pbxImagem.BackColor = System.Drawing.Color.Transparent;
            this.pbxImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImagem.Enabled = false;
            this.pbxImagem.Location = new System.Drawing.Point(559, 145);
            this.pbxImagem.Name = "pbxImagem";
            this.pbxImagem.Size = new System.Drawing.Size(170, 170);
            this.pbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagem.TabIndex = 61;
            this.pbxImagem.TabStop = false;
            this.pbxImagem.Click += new System.EventHandler(this.buscarImagem);
            this.pbxImagem.MouseLeave += new System.EventHandler(this.btnCancelaImg_MouseLeave);
            this.pbxImagem.MouseHover += new System.EventHandler(this.btnCancelaImg_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Rentflix.Properties.Resources.CamposObr;
            this.pictureBox2.Location = new System.Drawing.Point(40, 314);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 21);
            this.pictureBox2.TabIndex = 101;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Rentflix.Properties.Resources.generoFilme;
            this.pictureBox4.Location = new System.Drawing.Point(57, 117);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(78, 25);
            this.pictureBox4.TabIndex = 103;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Rentflix.Properties.Resources.censura;
            this.pictureBox5.Location = new System.Drawing.Point(40, 161);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(97, 25);
            this.pictureBox5.TabIndex = 104;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Rentflix.Properties.Resources.dist;
            this.pictureBox6.Location = new System.Drawing.Point(18, 199);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(124, 25);
            this.pictureBox6.TabIndex = 105;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Rentflix.Properties.Resources.preco;
            this.pictureBox7.Location = new System.Drawing.Point(57, 246);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(77, 25);
            this.pictureBox7.TabIndex = 106;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Rentflix.Properties.Resources.multa;
            this.pictureBox8.Location = new System.Drawing.Point(0, 288);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(142, 25);
            this.pictureBox8.TabIndex = 107;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Rentflix.Properties.Resources.atores;
            this.pictureBox9.Location = new System.Drawing.Point(263, 161);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(76, 25);
            this.pictureBox9.TabIndex = 108;
            this.pictureBox9.TabStop = false;
            // 
            // JanelaFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 503);
            this.Controls.Add(this.lblImgNaoEnc);
            this.Controls.Add(this.lblAddImg);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.btnAddGenero);
            this.Controls.Add(this.btnAddAtor);
            this.Controls.Add(this.btnRemAtor);
            this.Controls.Add(this.txtAtores);
            this.Controls.Add(this.lstAtores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.btnCancelaImg);
            this.Controls.Add(this.txtDistrubuicao);
            this.Controls.Add(this.dgvTabela);
            this.Controls.Add(this.cmbCensura);
            this.Controls.Add(this.dtDataLancamento);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.pbxImagem);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JanelaFilmes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Funcionários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JanelaFilmes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblImgNaoEnc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAddImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAtor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemAtor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelaImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.ComboBox cmbCensura;
        private System.Windows.Forms.DateTimePicker dtDataLancamento;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDistrubuicao;
        private System.Windows.Forms.PictureBox pbxImagem;
        private System.Windows.Forms.PictureBox btnCancelaImg;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtMulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnNovo;
        private System.Windows.Forms.PictureBox btnEditar;
        private System.Windows.Forms.PictureBox btnExcluir;
        private System.Windows.Forms.PictureBox btnSalvar;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.ListBox lstAtores;
        private System.Windows.Forms.TextBox txtAtores;
        private System.Windows.Forms.PictureBox btnAddAtor;
        private System.Windows.Forms.PictureBox btnRemAtor;
        private System.Windows.Forms.PictureBox btnAddGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn multa;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn censura;
        private System.Windows.Forms.DataGridViewTextBoxColumn distribuicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLanc;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox lblAddImg;
        private System.Windows.Forms.PictureBox lblImgNaoEnc;
    }
}