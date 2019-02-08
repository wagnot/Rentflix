using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentflix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            JanelaCliente jc = new JanelaCliente(this);
            jc.Show();
            this.Visible = false;
        }

        private void mouseHoverButtons(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            if (sender == pictureBox1)
            {
                lblCliente.Visible = true;
            }
            if (sender == pictureBox2)
            {
                lblFilme.Visible = true;

            }
            if (sender == pictureBox3)
            {
                lblLocacao.Visible = true;

            }
        }

        private void mouseLeaveButtons(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            if (sender == pictureBox1)
            {
                lblCliente.Visible = false;
            }
            if (sender == pictureBox2)
            {
                lblFilme.Visible = false;

            }
            if (sender == pictureBox3)
            {
                lblLocacao.Visible = false;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            JanelaFilmes jf = new JanelaFilmes(this);
            jf.Show();
            this.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Função indisponível", "Em breve",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
