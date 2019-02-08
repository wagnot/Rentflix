namespace Rentflix
{
    partial class JanelaCensura
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
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
            this.panel1.TabIndex = 74;
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::Rentflix.Properties.Resources.Novo;
            this.btnNovo.Location = new System.Drawing.Point(3, 34);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(54, 52);
            this.btnNovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNovo.TabIndex = 4;
            this.btnNovo.TabStop = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            this.btnNovo.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnNovo.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::Rentflix.Properties.Resources.EditarFal;
            this.btnEditar.Location = new System.Drawing.Point(3, 93);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(54, 52);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditar.TabIndex = 3;
            this.btnEditar.TabStop = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            this.btnEditar.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnEditar.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::Rentflix.Properties.Resources.ExcluirFal;
            this.btnExcluir.Location = new System.Drawing.Point(3, 151);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(54, 52);
            this.btnExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            this.btnExcluir.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnExcluir.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = global::Rentflix.Properties.Resources.SalvarFal;
            this.btnSalvar.Location = new System.Drawing.Point(3, 219);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(54, 52);
            this.btnSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            this.btnSalvar.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnSalvar.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::Rentflix.Properties.Resources.CancelarFal;
            this.btnCancelar.Location = new System.Drawing.Point(3, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(54, 52);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
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
            this.dgvTabela.TabIndex = 73;
            this.dgvTabela.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabela_CellClick);
            this.dgvTabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabela_CellContentClick_1);
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 302;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 35.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(171, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 56);
            this.label2.TabIndex = 76;
            this.label2.Text = "Censura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 75;
            this.label1.Text = "RENTFLIX";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(152, 91);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(258, 30);
            this.txtDescricao.TabIndex = 72;
            this.txtDescricao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDescricao_KeyUp_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(60, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 77;
            this.label3.Text = "Descrição:";
            // 
            // JanelaCensura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTabela);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Name = "JanelaCensura";
            this.Text = "JanelaCensura";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JanelaCensura_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
    }
}