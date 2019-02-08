using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentflix
{
    class Filme
    {
        public int cod { get; set; }
        private String titulo;
        public String Titulo{get { return titulo.TrimEnd(' '); } set { titulo = value; } }
        public int genero { get; set; }
        private String censura;
        public String Censura { get { return censura.TrimEnd(' '); } set { censura = value; } }
        private String distribuicao;
        public String Distribuicao { get { return distribuicao.TrimEnd(' '); } set { distribuicao = value; } }
        private String imagem;
        public String Imagem { get { return imagem.TrimEnd(' '); } set { imagem = value; } }
        public double preco { get; set; }
        public double valorMultaDiaria { get; set; }
        public DateTime dataLancamento { get; set; }
        public List<String> atores { get; set; }
        public void Cadastrar()
        {
            
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "INSERT INTO tbfilme (titulo, genero, censura, distribuicao," +
                    " imagem, preco, valormultadiaria, datalancamento,status) VALUES" +
                    "(@titulo, @genero, @censura, @distribuicao, @imagem," +
                    " @preco, @valormultadiaria, @datalancamento, @status)";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@titulo", this.titulo);
                cmd.Parameters.AddWithValue("@genero", this.genero);
                cmd.Parameters.AddWithValue("@censura", this.censura);
                cmd.Parameters.AddWithValue("@distribuicao", this.distribuicao);
                cmd.Parameters.AddWithValue("@imagem", this.imagem);
                cmd.Parameters.AddWithValue("@preco", this.preco);
                cmd.Parameters.AddWithValue("@valormultadiaria", this.valorMultaDiaria);
                cmd.Parameters.AddWithValue("@datalancamento", this.dataLancamento);
                cmd.Parameters.AddWithValue("@status", true);

                cmd.ExecuteNonQuery();
                int cod = getUltimoCodigo();
                foreach (String ator in this.atores)
                    CadastrarAtor(ator, cod);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
        }

        public void CadastrarAtor(String ator, int codFilme)
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();

                String sql = "INSERT INTO tbatores (ator, codfilme, status) VALUES" +
                   "(@ator, @codfilme, @status)";


                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                    System.Console.WriteLine(ator);
                    cmd.Parameters.AddWithValue("@ator", ator);
                    cmd.Parameters.AddWithValue("@codfilme", codFilme);
                    cmd.Parameters.AddWithValue("@status", true);

                    cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
        }

        public int getUltimoCodigo()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "SELECT cod FROM tbfilme ORDER BY cod DESC LIMIT 1";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                int codFilme = 0;

                NpgsqlDataReader npgsqlStatement = cmd.ExecuteReader();

                while (npgsqlStatement.Read())
                {
                    codFilme = Convert.ToInt16(npgsqlStatement["cod"]);
                }
                
                return codFilme;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
        }

        public void Editar()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "UPDATE tbfilme set titulo=@titulo, genero=@genero, censura=@censura, " +
                    " distribuicao=@distribuicao, imagem=@imagem, preco=@preco, valorMultaDiaria=@valorMultaDiaria, " +
                    "dataLancamento=@dataLancamento WHERE cod=@cod";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@titulo", this.titulo);
                cmd.Parameters.AddWithValue("@genero", this.genero);
                cmd.Parameters.AddWithValue("@censura", this.censura);
                cmd.Parameters.AddWithValue("@distribuicao", this.distribuicao);
                cmd.Parameters.AddWithValue("@imagem", this.imagem);
                cmd.Parameters.AddWithValue("@preco", this.preco);
                cmd.Parameters.AddWithValue("@valormultadiaria", this.valorMultaDiaria);
                cmd.Parameters.AddWithValue("@datalancamento", this.dataLancamento);

                cmd.Parameters.AddWithValue("@cod", this.cod);

                cmd.ExecuteNonQuery();
                EditarAtor();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
        }

        public void EditarAtor()
        {
            ExcluirAtores(this.cod);
            foreach (String ator in this.atores) 
                CadastrarAtor(ator, this.cod);
        }

        public void ExcluirAtores(int cod)
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "UPDATE tbatores set status=@status WHERE codfilme=@codfilme";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@status", false);
                cmd.Parameters.AddWithValue("@codfilme", cod);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
        }

        public List<String> GetAtores(int cod)
        {
            List<String> atores = new List<String>();
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "SELECT ator FROM tbatores WHERE status=true and codFilme=@codFilme";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@codFilme", cod);
                NpgsqlDataReader npgsqlStatement = cmd.ExecuteReader();

                while (npgsqlStatement.Read())
                {
                    atores.Add(Convert.ToString(npgsqlStatement["ator"]));
                }
                //return atores.Cast<String>().OrderBy(r => r.descricao).ToList();
                atores.Sort();
                return atores;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
        }

        public void Excluir(int cod)
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "UPDATE tbfilme set status=@status WHERE cod=@cod";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@status", false);
                cmd.Parameters.AddWithValue("@cod", cod);

                cmd.ExecuteNonQuery();
                ExcluirAtores(cod);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
        }

        public List<Filme> GetFilmes()
        {
            ArrayList filmes = new ArrayList();
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "SELECT cod, titulo, genero, censura, distribuicao, imagem, " +
                    "preco, valormultadiaria, datalancamento FROM tbfilme WHERE status=true";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);


                NpgsqlDataReader npgsqlStatement = cmd.ExecuteReader();

                while (npgsqlStatement.Read())
                {
                    Filme f = new Filme();
                    f.cod = Convert.ToInt16(npgsqlStatement["cod"]);
                    f.titulo= Convert.ToString(npgsqlStatement["titulo"]);
                    f.genero = Convert.ToInt16(npgsqlStatement["genero"]);
                    f.censura = Convert.ToString(npgsqlStatement["censura"]);
                    f.distribuicao = Convert.ToString(npgsqlStatement["distribuicao"]);
                    f.imagem = Convert.ToString(npgsqlStatement["imagem"]);
                    f.preco = Convert.ToDouble(npgsqlStatement["preco"]);
                    f.valorMultaDiaria = Convert.ToDouble(npgsqlStatement["valormultadiaria"]);
                    f.dataLancamento = Convert.ToDateTime(npgsqlStatement["datalancamento"]);
                    f.atores = this.GetAtores(f.cod);
                    filmes.Add(f);
                }
                return filmes.Cast<Filme>().OrderBy(r => r.titulo).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
        }

        public List<Filme> GetFilmes(String titulo)
        {
            ArrayList filmes = new ArrayList();
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "SELECT cod, titulo, genero, censura, distribuicao, imagem, " +
                    "preco, valormultadiaria, datalancamento FROM tbfilme WHERE status=true" +
                    " and titulo like @titulo";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@titulo", "%" + titulo + "%");

                NpgsqlDataReader npgsqlStatement = cmd.ExecuteReader();

                while (npgsqlStatement.Read())
                {
                    Filme f = new Filme();
                    f.cod = Convert.ToInt16(npgsqlStatement["cod"]);
                    f.titulo = Convert.ToString(npgsqlStatement["titulo"]);
                    f.genero = Convert.ToInt16(npgsqlStatement["genero"]);
                    f.censura = Convert.ToString(npgsqlStatement["censura"]);
                    f.distribuicao = Convert.ToString(npgsqlStatement["distribuicao"]);
                    f.imagem = Convert.ToString(npgsqlStatement["imagem"]);
                    f.preco = Convert.ToDouble(npgsqlStatement["preco"]);
                    f.valorMultaDiaria = Convert.ToDouble(npgsqlStatement["valormultadiaria"]);
                    f.dataLancamento = Convert.ToDateTime(npgsqlStatement["datalancamento"]);
                    f.atores = this.GetAtores(f.cod);
                    filmes.Add(f);
                }
                return filmes.Cast<Filme>().OrderBy(r => r.titulo).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
        }

        public Boolean verificaNomesImagens(String titulo)
        {
            foreach (Filme f in GetFilmes())
                if (f.Imagem.Equals(titulo))
                    return true;
            return false;


           /* ArrayList filmes = new ArrayList();
            NpgsqlConnection conexao = null;
            int num = 0;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "SELECT COUNT(cod) FROM tbfilme WHERE imagem like @titulo and status=true";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@titulo", titulo);

                num = Convert.ToInt16(cmd.ExecuteScalar());
                
                if(num>0)
                    return true;
                //       return filmes.Cast<Filme>().OrderBy(r => r.titulo).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
            return false;*/
        }

        public Filme GetFilme(int cod)
        {
            Filme f = new Filme();
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "SELECT cod, titulo, genero, censura, distribuicao, imagem, " +
                    "preco, valormultadiaria, datalancamento FROM tbfilme WHERE status=true" +
                    " and cod=@cod";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@cod", cod);

                NpgsqlDataReader npgsqlStatement = cmd.ExecuteReader();

                while (npgsqlStatement.Read())
                {
                    f.cod = Convert.ToInt16(npgsqlStatement["cod"]);
                    f.titulo = Convert.ToString(npgsqlStatement["titulo"]);
                    f.genero = Convert.ToInt16(npgsqlStatement["genero"]);
                    f.censura = Convert.ToString(npgsqlStatement["censura"]);
                    f.distribuicao = Convert.ToString(npgsqlStatement["distribuicao"]);
                    f.imagem = Convert.ToString(npgsqlStatement["imagem"]);
                    f.preco = Convert.ToDouble(npgsqlStatement["preco"]);
                    f.valorMultaDiaria = Convert.ToDouble(npgsqlStatement["valormultadiaria"]);
                    f.dataLancamento = Convert.ToDateTime(npgsqlStatement["datalancamento"]);
                    f.atores = this.GetAtores(f.cod);
                }
                return f;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexao != null)
                    conexao.Close();
            }
        }

    }
}


