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
    public partial class JanelaCensura : Form
    {
        int cod = 0;
        List<Censura> tabela = new List<Censura>();
        JanelaFilmes jf;
        public JanelaCensura(JanelaFilmes jf)
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
                tabela = new Censura().getCensuras(txtDescricao.Text.ToUpper());
            else
                tabela = new Censura().getCensuras();

            //MessageBox.Show(tabela.Count + "");
            foreach (Censura g in tabela)
            {
                dgvTabela.Rows.Add(g.Descricao);
            }

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

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            btnSalvarEnable();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja excluir a censura \"" + new Censura().getCensura(cod).Descricao + "\"?", "Excluir", MessageBoxButtons.YesNo))
            {
                new Censura().excluir(cod);
                MessageBox.Show("Gênero excluido com sucesso");
                btnNovoEnable();
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (txtDescricao.Text.Length > 0)
            {
                Censura c = new Censura();
                c.Descricao = txtDescricao.Text.ToUpper();
                if (cod > 0)
                {
                    c.cod = cod;
                    c.editar();
                    MessageBox.Show("Censura editada com sucesso");
                }
                else
                {
                    c.cadastrar();
                    MessageBox.Show("Censura cadastrada com sucesso");
                }
                txtDescricao.Text = "";
                btnNovoEnable();
            }
            else
            {
                MessageBox.Show("Preencha o campo");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
            btnNovoEnable();
        }

        private void JanelaCensura_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void txtDescricao_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (dgvTabela.Enabled)
            {
                btnNovoEnable();
                preencheTabela();
            }
        }

        private void dgvTabela_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {           
        }

        private void dgvTabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTabEnable();
            if (dgvTabela.CurrentRow.Index > -1 && dgvTabela.CurrentRow.Index < (dgvTabela.RowCount - 1))
            {
                cod = ((Censura)tabela[dgvTabela.CurrentRow.Index]).cod;
                txtDescricao.Text = ((Censura)tabela[dgvTabela.CurrentRow.Index]).Descricao;
            }
            else
            {
                cod = 0;
                txtDescricao.Text = "";
            }
        }
    }
}

