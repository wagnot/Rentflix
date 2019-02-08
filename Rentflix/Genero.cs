using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentflix
{
    class Genero
    {
        public int cod { get; set; }
        private String descricao;
        public String Descricao
        {
            get
            {
                return this.descricao.TrimEnd(' ');
            }
            set {
                this.descricao = value;
            }
        }
        public void Cadastrar()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "INSERT INTO tbgenero (descricao, status) VALUES" +
                    "(@descricao, @status)";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@descricao", this.descricao);
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

        public void Editar()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "UPDATE tbgenero set descricao=@descricao WHERE cod=@cod";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@descricao", this.descricao);
                cmd.Parameters.AddWithValue("@cod", this.cod);

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

        public void Excluir(int cod)
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "UPDATE tbgenero set status=@status WHERE cod=@cod";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@status", false);
                cmd.Parameters.AddWithValue("@cod", cod);

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

        public List<Genero> GetGeneros()
        {
            ArrayList generos = new ArrayList();
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "SELECT cod, descricao FROM tbgenero WHERE status=true";
               
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);


                NpgsqlDataReader npgsqlStatement = cmd.ExecuteReader();

                while (npgsqlStatement.Read())
                {
                    Genero g = new Genero();
                    g.cod = Convert.ToInt16(npgsqlStatement["cod"]);
                    g.descricao = Convert.ToString(npgsqlStatement["descricao"]);
                    generos.Add(g);
                }
                return generos.Cast<Genero>().OrderBy(r => r.descricao).ToList();
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
        
        public List<Genero> GetGeneros(String descricao)
        {
            ArrayList generos = new ArrayList();
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "SELECT cod, descricao FROM tbgenero WHERE status=true " +
                    "and descricao like @descricao";
                
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@descricao", "%"+descricao+ "%");
                NpgsqlDataReader npgsqlStatement = cmd.ExecuteReader();


                while (npgsqlStatement.Read())
                {
                    Genero g = new Genero
                    {
                        cod = Convert.ToInt16(npgsqlStatement["cod"]),
                        descricao = Convert.ToString(npgsqlStatement["descricao"])
                    };
                    generos.Add(g);
                }
                return generos.Cast<Genero>().OrderBy(r => r.descricao).ToList();
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

        public Genero GetGenero(int cod)
        {
            Genero g = new Genero();
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "SELECT cod, descricao FROM tbgenero WHERE status=true " +
                    "and cod=@cod";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@cod", cod);
                NpgsqlDataReader npgsqlStatement = cmd.ExecuteReader();

                while (npgsqlStatement.Read())
                {
                    g.cod = Convert.ToInt16(npgsqlStatement["cod"]);
                    g.descricao = Convert.ToString(npgsqlStatement["descricao"]);
                }
                return g;
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
