namespace Rentflix
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFilme = new System.Windows.Forms.PictureBox();
            this.lblLocacao = new System.Windows.Forms.PictureBox();
            this.lblCliente = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFilme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.ReshowDelay = 500;
            this.toolTip1.ShowAlways = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Rentflix.Properties.Resources.MenuLocacao;
            this.pictureBox3.Location = new System.Drawing.Point(574, 135);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(214, 177);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Locação (Em breve)");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.mouseLeaveButtons);
            this.pictureBox3.MouseHover += new System.EventHandler(this.mouseHoverButtons);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Rentflix.Properties.Resources.MenuFilme;
            this.pictureBox2.Location = new System.Drawing.Point(338, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Gerenciador de filmes");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.mouseLeaveButtons);
            this.pictureBox2.MouseHover += new System.EventHandler(this.mouseHoverButtons);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Rentflix.Properties.Resources.MenuCliente;
            this.pictureBox1.Location = new System.Drawing.Point(66, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Gerenciador de clientes");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.mouseLeaveButtons);
            this.pictureBox1.MouseHover += new System.EventHandler(this.mouseHoverButtons);
            // 
            // lblFilme
            // 
            this.lblFilme.Image = global::Rentflix.Properties.Resources.Filmes;
            this.lblFilme.Location = new System.Drawing.Point(361, 303);
            this.lblFilme.Name = "lblFilme";
            this.lblFilme.Size = new System.Drawing.Size(118, 50);
            this.lblFilme.TabIndex = 11;
            this.lblFilme.TabStop = false;
            this.lblFilme.Visible = false;
            // 
            // lblLocacao
            // 
            this.lblLocacao.Image = global::Rentflix.Properties.Resources.Locacao;
            this.lblLocacao.Location = new System.Drawing.Point(611, 295);
            this.lblLocacao.Name = "lblLocacao";
            this.lblLocacao.Size = new System.Drawing.Size(148, 58);
            this.lblLocacao.TabIndex = 10;
            this.lblLocacao.TabStop = false;
            this.lblLocacao.Visible = false;
            // 
            // lblCliente
            // 
            this.lblCliente.Image = global::Rentflix.Properties.Resources.Cliente;
            this.lblCliente.Location = new System.Drawing.Point(76, 303);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(144, 50);
            this.lblCliente.TabIndex = 9;
            this.lblCliente.TabStop = false;
            this.lblCliente.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Rentflix.Properties.Resources.Rentflix;
            this.pictureBox4.Location = new System.Drawing.Point(297, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(221, 63);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 422);
            this.Controls.Add(this.lblFilme);
            this.Controls.Add(this.lblLocacao);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Gotham", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFilme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox lblCliente;
        private System.Windows.Forms.PictureBox lblLocacao;
        private System.Windows.Forms.PictureBox lblFilme;
    }
}

