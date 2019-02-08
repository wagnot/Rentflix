namespace Rentflix
{
    partial class JanelaGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaGenero));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(454, -30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 362);
            this.panel1.TabIndex = 67;
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::Rentflix.Properties.Resources.Novo;
            this.btnNovo.Location = new System.Drawing.Point(3, 40);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(54, 52);
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
            this.btnEditar.Location = new System.Drawing.Point(3, 99);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(54, 52);
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
            this.btnExcluir.Location = new System.Drawing.Point(3, 157);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(54, 52);
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
            this.btnSalvar.Location = new System.Drawing.Point(3, 225);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(54, 52);
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
            this.btnCancelar.Location = new System.Drawing.Point(3, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(54, 52);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // dgvTabela
            // 
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricao});
            this.dgvTabela.Location = new System.Drawing.Point(65, 152);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.ReadOnly = true;
            this.dgvTabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabela.Size = new System.Drawing.Size(345, 130);
            this.dgvTabela.TabIndex = 1;
            this.dgvTabela.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabela_CellClick);
            this.dgvTabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabela_CellContentClick);
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 302;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(153, 91);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(257, 30);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricao_KeyDown);
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            this.txtDescricao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDescricao_KeyUp);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.ReshowDelay = 500;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Rentflix.Properties.Resources.descricao;
            this.pictureBox4.Location = new System.Drawing.Point(44, 91);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(103, 27);
            this.pictureBox4.TabIndex = 81;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Rentflix.Properties.Resources.generos;
            this.pictureBox3.Location = new System.Drawing.Point(181, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 64);
            this.pictureBox3.TabIndex = 80;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Rentflix.Properties.Resources.Rentflix;
            this.pictureBox2.Location = new System.Drawing.Point(12, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rentflix.Properties.Resources.CamposObr;
            this.pictureBox1.Location = new System.Drawing.Point(65, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 19);
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // JanelaGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 314);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.dgvTabela);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JanelaGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Gêneros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JanelaGenero_FormClosing);
            this.Load += new System.EventHandler(this.JanelaGenero_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnNovo;
        private System.Windows.Forms.PictureBox btnEditar;
        private System.Windows.Forms.PictureBox btnExcluir;
        private System.Windows.Forms.PictureBox btnSalvar;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}