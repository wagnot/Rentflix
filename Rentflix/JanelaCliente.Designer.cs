namespace Rentflix
{
    partial class JanelaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaCliente));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.dtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.lstTelefones = new System.Windows.Forms.ListBox();
            this.cmdEstado = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.btnRem = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInfoCpf = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.lblApenas18 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInfoCpf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblApenas18)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(139, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(412, 30);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(139, 273);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(183, 30);
            this.txtBairro.TabIndex = 8;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(410, 273);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(183, 30);
            this.txtCidade.TabIndex = 9;
            // 
            // txtCpf
            // 
            this.txtCpf.Enabled = false;
            this.txtCpf.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(139, 126);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(125, 30);
            this.txtCpf.TabIndex = 1;
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
            this.txtCpf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCpf_KeyUp);
            // 
            // dtDataNascimento
            // 
            this.dtDataNascimento.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataNascimento.Location = new System.Drawing.Point(327, 176);
            this.dtDataNascimento.Name = "dtDataNascimento";
            this.dtDataNascimento.Size = new System.Drawing.Size(114, 30);
            this.dtDataNascimento.TabIndex = 4;
            this.dtDataNascimento.Value = new System.DateTime(2018, 11, 13, 20, 10, 46, 0);
            this.dtDataNascimento.ValueChanged += new System.EventHandler(this.dtDataNascimento_ValueChanged);
            this.dtDataNascimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtDataNascimento_KeyDown);
            this.dtDataNascimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtDataNascimento_KeyPress);
            this.dtDataNascimento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtDataNascimento_KeyUp);
            this.dtDataNascimento.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtDataNascimento_MouseDown);
            this.dtDataNascimento.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dtDataNascimento_MouseUp);
            // 
            // txtRg
            // 
            this.txtRg.Enabled = false;
            this.txtRg.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(327, 126);
            this.txtRg.Mask = "00,000,000-&";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(114, 30);
            this.txtRg.TabIndex = 2;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.Enabled = false;
            this.cmbSexo.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masc.",
            "Fem."});
            this.cmbSexo.Location = new System.Drawing.Point(139, 176);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(56, 31);
            this.cmbSexo.TabIndex = 3;
            // 
            // txtCep
            // 
            this.txtCep.Enabled = false;
            this.txtCep.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(503, 177);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(90, 30);
            this.txtCep.TabIndex = 5;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouro.Location = new System.Drawing.Point(139, 225);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(302, 30);
            this.txtLogradouro.TabIndex = 6;
            // 
            // dgvTabela
            // 
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.telefone,
            this.rg,
            this.cpf,
            this.logradouro,
            this.bairro,
            this.cidade,
            this.estado,
            this.cep,
            this.sexo});
            this.dgvTabela.Location = new System.Drawing.Point(40, 332);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.ReadOnly = true;
            this.dgvTabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabela.Size = new System.Drawing.Size(759, 159);
            this.dgvTabela.TabIndex = 31;
            this.dgvTabela.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabela_CellClick);
            this.dgvTabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabela_CellContentClick);
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // telefone
            // 
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // rg
            // 
            this.rg.HeaderText = "RG";
            this.rg.Name = "rg";
            this.rg.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // logradouro
            // 
            this.logradouro.HeaderText = "Logradouro";
            this.logradouro.Name = "logradouro";
            this.logradouro.ReadOnly = true;
            // 
            // bairro
            // 
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            // 
            // cidade
            // 
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // cep
            // 
            this.cep.HeaderText = "CEP";
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.btnNovo);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Location = new System.Drawing.Point(822, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(69, 511);
            this.panel2.TabIndex = 34;
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
            this.btnNovo.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnNovo.MouseHover += new System.EventHandler(this.btn_MouseHover);
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
            this.btnEditar.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnEditar.MouseHover += new System.EventHandler(this.btn_MouseHover);
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
            this.btnExcluir.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnExcluir.MouseHover += new System.EventHandler(this.btn_MouseHover);
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
            this.btnSalvar.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnSalvar.MouseHover += new System.EventHandler(this.btn_MouseHover);
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
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // lstTelefones
            // 
            this.lstTelefones.Enabled = false;
            this.lstTelefones.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold);
            this.lstTelefones.FormattingEnabled = true;
            this.lstTelefones.ItemHeight = 23;
            this.lstTelefones.Location = new System.Drawing.Point(614, 161);
            this.lstTelefones.Name = "lstTelefones";
            this.lstTelefones.Size = new System.Drawing.Size(146, 142);
            this.lstTelefones.TabIndex = 35;
            // 
            // cmdEstado
            // 
            this.cmdEstado.DropDownHeight = 70;
            this.cmdEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdEstado.Enabled = false;
            this.cmdEstado.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmdEstado.FormattingEnabled = true;
            this.cmdEstado.IntegralHeight = false;
            this.cmdEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmdEstado.Location = new System.Drawing.Point(532, 224);
            this.cmdEstado.Name = "cmdEstado";
            this.cmdEstado.Size = new System.Drawing.Size(61, 31);
            this.cmdEstado.TabIndex = 7;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(614, 122);
            this.txtTelefone.Mask = "(00)0000-00009";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(146, 30);
            this.txtTelefone.TabIndex = 10;
            this.txtTelefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefone_KeyDown);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.ReshowDelay = 500;
            this.toolTip1.ShowAlways = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Image = global::Rentflix.Properties.Resources.Add;
            this.btnAdd.Location = new System.Drawing.Point(766, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 36);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 64;
            this.btnAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAdd, "Adicionar telefone");
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnRem
            // 
            this.btnRem.Enabled = false;
            this.btnRem.Image = global::Rentflix.Properties.Resources.Cancelar;
            this.btnRem.Location = new System.Drawing.Point(766, 267);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(33, 36);
            this.btnRem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRem.TabIndex = 63;
            this.btnRem.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRem, "Remover telefone");
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            this.btnRem.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnRem.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Rentflix.Properties.Resources.Rentflix;
            this.pictureBox13.Location = new System.Drawing.Point(12, 7);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(103, 33);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 98;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Rentflix.Properties.Resources.Telefone;
            this.pictureBox11.Location = new System.Drawing.Point(597, 89);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(105, 27);
            this.pictureBox11.TabIndex = 96;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Rentflix.Properties.Resources.estado;
            this.pictureBox10.Location = new System.Drawing.Point(451, 225);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(79, 27);
            this.pictureBox10.TabIndex = 95;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Rentflix.Properties.Resources.Nome;
            this.pictureBox2.Location = new System.Drawing.Point(76, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 27);
            this.pictureBox2.TabIndex = 87;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rentflix.Properties.Resources.Cliente;
            this.pictureBox1.Location = new System.Drawing.Point(338, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 47);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // lblInfoCpf
            // 
            this.lblInfoCpf.Location = new System.Drawing.Point(266, 127);
            this.lblInfoCpf.Name = "lblInfoCpf";
            this.lblInfoCpf.Size = new System.Drawing.Size(25, 28);
            this.lblInfoCpf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lblInfoCpf.TabIndex = 83;
            this.lblInfoCpf.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Rentflix.Properties.Resources.CPF;
            this.pictureBox8.Location = new System.Drawing.Point(84, 128);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(64, 27);
            this.pictureBox8.TabIndex = 93;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Rentflix.Properties.Resources.rg;
            this.pictureBox7.Location = new System.Drawing.Point(297, 128);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 27);
            this.pictureBox7.TabIndex = 92;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Rentflix.Properties.Resources.sexo;
            this.pictureBox6.Location = new System.Drawing.Point(84, 180);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 27);
            this.pictureBox6.TabIndex = 91;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Rentflix.Properties.Resources.dataNascimento;
            this.pictureBox5.Location = new System.Drawing.Point(201, 178);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(131, 27);
            this.pictureBox5.TabIndex = 90;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Rentflix.Properties.Resources.cep;
            this.pictureBox4.Location = new System.Drawing.Point(466, 178);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 27);
            this.pictureBox4.TabIndex = 89;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Rentflix.Properties.Resources.logradouro;
            this.pictureBox3.Location = new System.Drawing.Point(27, 227);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(121, 27);
            this.pictureBox3.TabIndex = 88;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Rentflix.Properties.Resources.bairro;
            this.pictureBox9.Location = new System.Drawing.Point(65, 274);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(83, 27);
            this.pictureBox9.TabIndex = 94;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::Rentflix.Properties.Resources.cidade;
            this.pictureBox12.Location = new System.Drawing.Point(338, 275);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(79, 27);
            this.pictureBox12.TabIndex = 97;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::Rentflix.Properties.Resources.CamposObr;
            this.pictureBox14.Location = new System.Drawing.Point(40, 309);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(155, 27);
            this.pictureBox14.TabIndex = 99;
            this.pictureBox14.TabStop = false;
            // 
            // lblApenas18
            // 
            this.lblApenas18.Image = global::Rentflix.Properties.Resources.apenas18;
            this.lblApenas18.Location = new System.Drawing.Point(327, 207);
            this.lblApenas18.Name = "lblApenas18";
            this.lblApenas18.Size = new System.Drawing.Size(118, 27);
            this.lblApenas18.TabIndex = 100;
            this.lblApenas18.TabStop = false;
            this.lblApenas18.Visible = false;
            // 
            // JanelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 503);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblInfoCpf);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.cmdEstado);
            this.Controls.Add(this.lstTelefones);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvTabela);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.dtDataNascimento);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.lblApenas18);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JanelaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JanelaCliente_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInfoCpf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblApenas18)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.DateTimePicker dtDataNascimento;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnEditar;
        private System.Windows.Forms.PictureBox btnExcluir;
        private System.Windows.Forms.PictureBox btnSalvar;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.ListBox lstTelefones;
        private System.Windows.Forms.ComboBox cmdEstado;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.PictureBox btnRem;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.PictureBox btnNovo;
        private System.Windows.Forms.PictureBox lblInfoCpf;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
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
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox lblApenas18;
    }
}