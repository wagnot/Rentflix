using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentflix
{
    public partial class JanelaGenero : Form
    {
        int cod = 0;
        List<Genero> tabela = new List<Genero>();
        JanelaFilmes jf;

        public JanelaGenero(JanelaFilmes jf)
        {
            InitializeComponent();
            this.jf = jf;

            preencheTabela();
        }

        private void preencheTabela()
        {
            cod = 0;
            dgvTabela.Rows.Clear();
            if (txtDescricao.Text.Length > 0) 
                tabela = new Genero().GetGeneros(txtDescricao.Text.ToUpper());
            else
                tabela = new Genero().GetGeneros();

            //MessageBox.Show(tabela.Count + "");
            foreach (Genero g in tabela)
            {
                dgvTabela.Rows.Add(g.Descricao);
            }

        }

        private void JanelaGenero_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnSalvarEnable();
        }

       
        private void btn_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text.Length > 0)
            {
                Genero g = new Genero();
                g.Descricao = txtDescricao.Text.ToUpper();
                if (cod > 0)
                {
                    g.cod = cod;
                    g.Editar();
                    MessageBox.Show("Gênero editado com sucesso");
                }
                else
                {                    
                    g.Cadastrar();
                    MessageBox.Show("Gênero cadastrado com sucesso");
                }
                txtDescricao.Text = "";
                btnNovoEnable();
            }
            else
            {
                MessageBox.Show("Preencha o campo");
            }
        }

        private void btnSalvarEnable()
        {
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Image = Properties.Resources.NovoFal;
            btnEditar.Image = Properties.Resources.EditarFal;
            btnExcluir.Image = Properties.Resources.ExcluirFal;
            btnSalvar.Image = Properties.Resources.Salvar;
            btnCancelar.Image = Properties.Resources.Cancelar;
            dgvTabela.Enabled = false;

        }

        private void btnNovoEnable()
        {
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Image = Properties.Resources.Novo;
            btnEditar.Image = Properties.Resources.EditarFal;
            btnExcluir.Image = Properties.Resources.ExcluirFal;
            btnSalvar.Image = Properties.Resources.SalvarFal;
            btnCancelar.Image = Properties.Resources.CancelarFal;
            dgvTabela.Enabled = true;
           

            preencheTabela();
        }

        private void btnTabEnable()
        {
            btnNovo.Enabled = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = true;
            btnNovo.Image = Properties.Resources.NovoFal;
            btnEditar.Image = Properties.Resources.Editar;
            btnExcluir.Image = Properties.Resources.Excluir;
            btnSalvar.Image = Properties.Resources.SalvarFal;
            btnCancelar.Image = Properties.Resources.Cancelar;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnSalvarEnable();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Deseja excluir o gênero \"" + new Genero().GetGenero(cod).Descricao + "\"?", "Exclusão", MessageBoxButtons.YesNo)){
                new Genero().Excluir(cod);
                MessageBox.Show("Gênero excluído com sucesso", "Excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovoEnable();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
            btnNovoEnable();
        }

        private void dgvTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvTabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTabEnable();
            if (dgvTabela.CurrentRow.Index > -1 && dgvTabela.CurrentRow.Index<(dgvTabela.RowCount-1))
            {
                cod = ((Genero)tabela[dgvTabela.CurrentRow.Index]).cod;
                txtDescricao.Text = ((Genero)tabela[dgvTabela.CurrentRow.Index]).Descricao;
            }
            else
            {
                cod = 0;
                txtDescricao.Text = "";
            }

        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
           // preencheTabela();
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
         //   preencheTabela();
        }

        private void txtDescricao_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgvTabela.Enabled)
            {
                btnNovoEnable();
                preencheTabela();
            }
        }

        private void JanelaGenero_FormClosing(object sender, FormClosingEventArgs e)
        {
            jf.atualizaGeneros();
        }
    }
}
