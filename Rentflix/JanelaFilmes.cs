using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentflix
{

    public partial class JanelaFilmes : Form
    {
        List<Filme> tabela = new List<Filme>();
        OpenFileDialog open = new OpenFileDialog();
        int cod = 0;
        List<Genero> generos;
        Form1 form;
        String localPasta = Application.StartupPath.ToString() + "\\ImgFilmes\\";
        public JanelaFilmes(Form1 form)
        {
            InitializeComponent();
            this.form = form;

            excluirImgs();

            btnNovoEnable();
            atualizaGeneros();
            preencheTabela();
        }

        private void excluirImgs()
        {
            DirectoryInfo dir = new DirectoryInfo(localPasta);
            Boolean exclui = true;
            foreach (FileInfo file in dir.GetFiles())
            {
                System.Console.WriteLine(file.Name);
                foreach (Filme f in new Filme().GetFilmes())
                {
                    if (file.Name.Equals(f.Imagem+".jpg"))
                    {
                        exclui = false;
                        break;
                    }
                    // aqui no caso estou guardando o nome completo do arquivo em em controle ListBox
                    // voce faz como quiser
                    //lbxResultado.Items.Add(file.FullName);
                }
                if(exclui)
                    File.Delete(localPasta + file.Name);
                exclui = true;
            }
        }

        private void preencheTabela()
        {
            cod = 0;
            dgvTabela.Rows.Clear();
            if (txtTitulo.Text.Length > 0)
                tabela = new Filme().GetFilmes(txtTitulo.Text.ToUpper());
            else
                tabela = new Filme().GetFilmes();
            foreach (Filme f in tabela)
            {
                dgvTabela.Rows.Add(f.Titulo, string.Format("{0:0,0.00}", f.preco),
                    string.Format("{0:0,0.00}", f.valorMultaDiaria),  
                    new Genero().GetGenero(f.genero).Descricao, f.Censura,
                    f.Distribuicao,f.dataLancamento);
            }
        }

        public void atualizaGeneros()
        {
            cmbGenero.Items.Clear();
            generos = new Genero().GetGeneros();
            foreach (Genero g in generos)
                cmbGenero.Items.Add(g.Descricao);

        }

        private void btnCancelaImg_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnCancelaImg_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnSalvarEnable();
        }

        private Boolean verificaCampos()
        {
            try
            {
                double teste = Convert.ToDouble(txtMulta.Text);
                teste = Convert.ToDouble(txtMulta.Text);
                if (txtTitulo.Text.Length > 0 && txtPreco.Text.Length > 0 && txtMulta.Text.Length > 0
                    && cmbCensura.SelectedIndex > -1 && cmbGenero.SelectedIndex > -1)
                    return true;
            }
            catch { return false; }
            return false;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (verificaCampos())
            {
                List<String> atores = new List<string>();
                Filme filme = new Filme();
                filme.Titulo = txtTitulo.Text.ToUpper();
                filme.Distribuicao = txtDistrubuicao.Text;
                filme.preco = Convert.ToDouble(txtPreco.Text);
                filme.valorMultaDiaria = Convert.ToDouble(txtMulta.Text);
                foreach (String ob in lstAtores.Items)
                    atores.Add(ob);
                filme.atores = atores;
                filme.dataLancamento = Convert.ToDateTime(dtDataLancamento.Text);
                filme.Censura = cmbCensura.SelectedItem.ToString();
                filme.genero = generos[cmbGenero.SelectedIndex].cod;
                int i = 1;
                String nomeImg = filme.Titulo;
                while (true)
                {
                    if (filme.verificaNomesImagens(nomeImg))
                    {
                        if (i > 1)
                        {
                            nomeImg = nomeImg.Remove(0, nomeImg.Length - 3);
                            MessageBox.Show(nomeImg);
                        }

                        nomeImg = nomeImg + "(" + (i++) + ")";
                    }
                    else
                        break;
                }

                if (pbxImagem.Image != null)
                {
                    filme.Imagem = nomeImg;
                    pbxImagem.Image.Save(localPasta + nomeImg + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else
                    filme.Imagem = "null";

                lblAddImg.Visible = false;
                if (cod > 0)
                {
                    filme.cod = cod;
                    filme.Editar();
                    MessageBox.Show("Filme editado com sucesso");
                }
                else
                { 
                    filme.Cadastrar();
                    MessageBox.Show("Filme Cadastrado com sucesso");
                }
                limpaCampos(true);
                preencheTabela();
                btnNovoEnable();
            }
            else
                MessageBox.Show("Preencha todos os campos obrigatórios corretamente");  
        }


        private void buscarImagem(object sender, EventArgs e)
        {
            open.Title = "Abrir";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbxImagem.Image = new Bitmap(open.FileName);
                lblAddImg.Visible = false;
            }
        }
        private void btnAddAtor_Click(object sender, EventArgs e)
        {
            if (txtAtores.Text.Length > 0)
            {
                lstAtores.Items.Add(txtAtores.Text);
                txtAtores.Clear();
            }
        }

        private void btnRemAtor_Click(object sender, EventArgs e)
        {

            if (lstAtores.SelectedIndex > -1)
            {
                lstAtores.Items.RemoveAt(lstAtores.SelectedIndex);
            }
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

        private void limpaCampos(Boolean titulo)
        {
            if(titulo)
                txtTitulo.Text = "";
            txtDistrubuicao.Text = "";
            txtAtores.Text = "";
            txtPreco.Text = "";
            txtMulta.Text = "";
            pbxImagem.Image = null;
            lblAddImg.Visible = true;
            cmbCensura.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
            lstAtores.Items.Clear();
            dtDataLancamento.Value = DateTime.Now;
            lblImgNaoEnc.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnSalvarEnable();
        }

        private void JanelaFilmes_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Visible= true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja excluir o filme \"" + new Filme().GetFilme(cod).Titulo + "\"?", "Exclusão", MessageBoxButtons.YesNo))
            {
                new Filme().Excluir(cod);

                limpaCampos(true);
                btnNovoEnable();
                preencheTabela();
                MessageBox.Show("Filme excluído com sucesso", "Excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void camposEnableTrue()
        {
            cmbCensura.Enabled = true;
            cmbGenero.Enabled = true;
            txtAtores.Enabled = true;
            txtDistrubuicao.Enabled = true;
            txtMulta.Enabled = true;
            txtPreco.Enabled = true;
            dtDataLancamento.Enabled = true;
            lstAtores.Enabled = true;
            btnAddAtor.Enabled = true;
            btnRemAtor.Enabled = true;
            btnCancelaImg.Enabled = true;
            lblAddImg.Enabled = true;
            pbxImagem.Enabled = true;
            btnAddAtor.Image = Properties.Resources.Add;
            btnRemAtor.Image = Properties.Resources.Cancelar;
            btnCancelaImg.Image = Properties.Resources.Cancelar;
            dgvTabela.Enabled = false;
        }

        private void camposEnableFalse()
        {
            cmbCensura.Enabled = false;
            cmbGenero.Enabled = false;
            txtAtores.Enabled = false;
            txtDistrubuicao.Enabled = false;
            txtMulta.Enabled = false;
            txtPreco.Enabled = false;
            dtDataLancamento.Enabled = false;
            lstAtores.Enabled = false;
            btnAddAtor.Enabled = false;
            btnRemAtor.Enabled = false;
            btnCancelaImg.Enabled = false;
            lblAddImg.Enabled = false;
            pbxImagem.Enabled = false;
            btnAddAtor.Image = Properties.Resources.NovoFal;
            btnRemAtor.Image = Properties.Resources.CancelarFal;
            btnCancelaImg.Image = Properties.Resources.CancelarFal;
            dgvTabela.Enabled = true;

        }

        private void dgvTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvTabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTabEnable();
            if (dgvTabela.CurrentRow.Index > -1 && dgvTabela.CurrentRow.Index < (dgvTabela.RowCount - 1))
            {
                cod = ((Filme)tabela[dgvTabela.CurrentRow.Index]).cod;
                PreencheCampos(((Filme)tabela[dgvTabela.CurrentRow.Index]));
            }
            else
            {
                cod = 0;
                limpaCampos(true);
            }
        }

        private void btnAddGenero_Click(object sender, EventArgs e)
        {
            JanelaGenero jg= new JanelaGenero(this);
            jg.ShowDialog();
        }

        private void btnCancelaImg_Click(object sender, EventArgs e)
        {
            open.FileName = null;
            pbxImagem.Image = null;
            lblAddImg.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void PreencheCampos(Filme f)
        {
            txtTitulo.Text = f.Titulo;
            txtDistrubuicao.Text = f.Distribuicao;
            txtPreco.Text = string.Format("{0:0,0.00}", f.preco);
            txtMulta.Text = string.Format("{0:0,0.00}", f.valorMultaDiaria);
            if (!f.Imagem.Equals("null"))
            {
                try
                {
                    pbxImagem.Image = new Bitmap(localPasta + f.Imagem + ".jpg");
                    lblImgNaoEnc.Visible = false;
                }
                catch  {
                    pbxImagem.Image = Properties.Resources.erro;
                    lblImgNaoEnc.Visible = true;
                }
                lblAddImg.Visible = false;
            }
            else
            {
                lblAddImg.Visible = true;
                pbxImagem.Image = null;
            }
            cmbCensura.SelectedItem = f.Censura;
            cmbGenero.SelectedItem = new Genero().GetGenero(f.genero).Descricao;
            dtDataLancamento.Value = f.dataLancamento;
            lstAtores.Items.Clear();
            foreach (String ator in f.atores)
            {
                lstAtores.Items.Add(ator);
            }
        }

        private void txtTitulo_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void txtTitulo_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgvTabela.Enabled)
            {
                btnNovoEnable();
                preencheTabela();
                limpaCampos(false);
            }
        }
    }
}
