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
    public partial class JanelaCliente : Form
    {
        Form1 form;
        int cod = 0;
        List<Cliente> tabela = new List<Cliente>();
        public JanelaCliente(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            btnNovoEnable();
            preencheTabela();
            limpaCampos(true);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (verificaCampos())
            {
                Cliente cliente = new Cliente();
                List<String> telefones = new List<string>();
                cliente.nome = txtNome.Text.ToUpper();
                cliente.cpf = txtCpf.Text;
                cliente.rg = txtRg.Text;
                cliente.sexo = cmbSexo.SelectedItem + "";
                cliente.cep = txtCep.Text;
                cliente.logradouro = txtLogradouro.Text.ToUpper();
                cliente.bairro = txtBairro.Text.ToUpper();
                cliente.cidade = txtCidade.Text.ToUpper();
                cliente.estado = cmdEstado.SelectedItem + "";
                cliente.dataNascimento = Convert.ToDateTime(dtDataNascimento.Text);

                foreach (String ob in lstTelefones.Items)
                    telefones.Add(ob);
                cliente.telefones = telefones;
                if (cod > 0)
                {
                    cliente.cod = cod;
                    cliente.Editar();
                    MessageBox.Show("Cliente editado com sucesso");
                }
                else
                {
                    cliente.Cadastrar();
                    MessageBox.Show("Cliente cadastrado com sucesso");
                }
                limpaCampos(true);
                preencheTabela();
                btnNovoEnable();
            }
            else
                MessageBox.Show("Preencha todos os campos obrigatórios corretamente");
        }

        private Boolean verificaCampos()
        {
            String cpf = txtCpf.Text.Replace(" ", "").Replace("_", "").Replace("-", "").Replace(".", "");
            return ((verificaCPF(cpf.ToCharArray(0, cpf.Length)) &&
                txtNome.Text.Length > 0 && txtLogradouro.Text.Length > 0
                    && cmdEstado.SelectedIndex > -1 && txtBairro.Text.Length > 0 &&
                     txtCidade.Text.Length > 0 && lstTelefones.Items.Count > 0 &&
                     lblApenas18.Visible==false));

        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;

        }

        private void JanelaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Visible = true;
        }

        private void camposEnableTrue()
        {
            txtCpf.Enabled = true;
            txtRg.Enabled = true;
            cmbSexo.Enabled = true;
            dtDataNascimento.Enabled = true;
            txtLogradouro.Enabled = true;
            txtCep.Enabled = true;
            txtCidade.Enabled = true;
            cmdEstado.Enabled = true;
            txtBairro.Enabled = true;
            lstTelefones.Enabled = true;
            txtTelefone.Enabled = true;
            btnAdd.Enabled = true;
            btnRem.Enabled = true;
            btnAdd.Image = Properties.Resources.Add;
            btnRem.Image = Properties.Resources.Cancelar;
            dgvTabela.Enabled = false;
        }

        private void camposEnableFalse()
        {
            txtCpf.Enabled = false;
            txtRg.Enabled = false;
            cmbSexo.Enabled = false;
            dtDataNascimento.Enabled = false;
            txtLogradouro.Enabled = false;
            txtCep.Enabled = false;
            txtCidade.Enabled = false;
            cmdEstado.Enabled = false;
            txtBairro.Enabled = false;
            lstTelefones.Enabled = false;
            txtTelefone.Enabled = false;
            btnAdd.Enabled = false;
            btnRem.Enabled = false;
            btnAdd.Image = Properties.Resources.NovoFal;
            btnRem.Image = Properties.Resources.CancelarFal;
            dgvTabela.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnSalvarEnable();
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
            camposEnableTrue();
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
            camposEnableFalse();
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
            System.Console.WriteLine(cod);
            if (DialogResult.Yes == MessageBox.Show("Deseja excluir o cliente \"" +
                new Cliente().GetCliente(cod).nome + "\"?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                new Cliente().Excluir(cod);

                limpaCampos(true);
                btnNovoEnable();
                preencheTabela();
                MessageBox.Show("Cliente excluído com sucesso", "Excluir", 
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void preencheTabela()
        {
            cod = 0;
            dgvTabela.Rows.Clear();
            if (txtNome.Text.Length > 0)
                tabela = new Cliente().GetClientes(txtNome.Text.ToUpper());
            else
                tabela = new Cliente().GetClientes();
            foreach (Cliente c in tabela)
            {
                dgvTabela.Rows.Add(c.nome,c.telefones[0], c.rg, c.cpf, c.logradouro,
                    c.bairro, c.cidade, c.estado, c.cep, c.sexo);
            }

        }

        private void limpaCampos(Boolean nome)
        {
            if (nome)
                txtNome.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            txtTelefone.Text = "";
            txtCep.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtLogradouro.Text = "";
            cmdEstado.SelectedIndex = -1;
            cmbSexo.SelectedIndex = -1;
            lstTelefones.Items.Clear();
            dtDataNascimento.Value = Convert.ToDateTime("01/01/1980");
            lblApenas18.Visible = false;
            lblInfoCpf.Image = null;
            toolTip1.SetToolTip(lblInfoCpf, "");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (verificaCancel())
            {
                btnNovoEnable();
                limpaCampos(true);
            }
        }

        private bool verificaCancel()
        {
            if (btnSalvar.Enabled == true)
            {
                if (DialogResult.No == MessageBox.Show("Todos os dados inseridos serão pertidos, deseja continuar?"
                    , "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    return false;

            }
            return true;
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgvTabela.Enabled)
            {
                btnNovoEnable();
                preencheTabela();
                limpaCampos(false);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addTel();
        }

        private void addTel()
        {
            if (verificaTelRepetido())
            {
                if (txtTelefone.Text.Replace(" ", "").Replace("_", "").Replace("(", "").
                    Replace(")", "").Replace("-", "").Length > 9)
                {
                    lstTelefones.Items.Add(txtTelefone.Text);
                    txtTelefone.Text = "";
                    txtTelefone.Focus();
                }
            }
            else
                MessageBox.Show("Telefone já inserido");
        }
        private bool verificaTelRepetido()
        {
            foreach(string tel in lstTelefones.Items)
                if(tel.Equals(txtTelefone.Text))
                    return false;
            return true;
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            if (lstTelefones.SelectedIndex > -1)
            {
                lstTelefones.Items.RemoveAt(lstTelefones.SelectedIndex);
            }
        }

        private void dgvTabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTabEnable();
            if (dgvTabela.CurrentRow.Index > -1 && dgvTabela.CurrentRow.Index < (dgvTabela.RowCount - 1))
            {
                cod = ((Cliente)tabela[dgvTabela.CurrentRow.Index]).cod;

                PreencheCampos(((Cliente)tabela[dgvTabela.CurrentRow.Index]));
            }
            else
            {
                cod = 0;
                limpaCampos(true);
            }
        }

        private void PreencheCampos(Cliente c)
        {
            txtNome.Text = c.nome;
            txtCpf.Text = c.cpf;
            txtRg.Text = c.rg;
            txtLogradouro.Text = c.logradouro;
            txtBairro.Text = c.bairro;
            txtCidade.Text = c.cidade;
            txtCep.Text = c.cep;

            cmbSexo.SelectedItem = c.sexo;
            cmdEstado.SelectedItem = c.estado;
            dtDataNascimento.Value = c.dataNascimento;
            lstTelefones.Items.Clear();
            foreach (String tel in c.telefones)
            {
                lstTelefones.Items.Add(tel);
            }
        }

        private void dgvTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCpf_KeyUp(object sender, KeyEventArgs e)
        {
            cpfDigitado();
        }
            
        private void cpfDigitado()
        {
            String cpf = txtCpf.Text.Replace(" ", "").Replace("_", "").Replace("-", "").Replace(".", "");

            if (cpf.Length != 0)
            {
                if ((cpf.Length == 11) && !cpfTroll(cpf) && (verificaCPF(cpf.ToCharArray(0, cpf.Length))))
                {
                    lblInfoCpf.Image = Properties.Resources.Okay;
                    toolTip1.SetToolTip(lblInfoCpf, "CPF válido");
                }
                else
                {
                    lblInfoCpf.Image = Properties.Resources.Cancelar;
                    toolTip1.SetToolTip(lblInfoCpf, "CPF inválido");
                }
            }
            else
            {
                lblInfoCpf.Image = null;
                toolTip1.SetToolTip(lblInfoCpf, "");
            }
        }
        private Boolean verificaCPF(char[] cpf)
        {
                int x1 = 0, x2 = 0;
                for (int i = 0; i < cpf.Length - 1; i++)
                {
                    if (i < cpf.Length - 2)
                        x1 += (10 - i) * Convert.ToInt16(cpf[i] + "");
                    x2 += (11 - i) * Convert.ToInt16(cpf[i] + "");
                }
                x1 = (x1 * 10) % 11;
                if (x1 > 9)
                    x1 = 0;
                x2 = (x2 * 10) % 11;
                if (x2 > 9)
                    x2 = 0;
                return ((x1 + "").Equals(cpf[cpf.Length - 2] + "") &&
                    (x2 + "").Equals(cpf[cpf.Length - 1] + ""));
        }

        private bool cpfTroll(String cpf)
        {
            return ((cpf.Equals("00000000000")) || (cpf.Equals("11111111111")) || (cpf.Equals("22222222222"))
                 || (cpf.Equals("33333333333")) || (cpf.Equals("44444444444")) || (cpf.Equals("55555555555"))
                 || (cpf.Equals("66666666666")) || (cpf.Equals("77777777777")) || (cpf.Equals("88888888888"))
                 || (cpf.Equals("99999999999")));
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            cpfDigitado();
        }

        private void dtDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            inseriIdade();
        }

        private void dtDataNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            inseriIdade();
        }

        private void dtDataNascimento_KeyUp(object sender, KeyEventArgs e)
        {
            inseriIdade();
        }

        private void dtDataNascimento_MouseDown(object sender, MouseEventArgs e)
        {
            inseriIdade();

        }

        private void dtDataNascimento_MouseUp(object sender, MouseEventArgs e)
        {
            inseriIdade();
        }

        private void inseriIdade()
        {
            if((DateTime.Now.Year - dtDataNascimento.Value.Year) < 18)
                lblApenas18.Visible = true;
            else
                lblApenas18.Visible = false;
                
        }

        private void dtDataNascimento_ValueChanged(object sender, EventArgs e)
        {
            inseriIdade();
        }

        private void txtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addTel();
        }
    }
}
