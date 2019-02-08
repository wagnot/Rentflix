using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentflix
{
    class Censura
    {
        public int cod { get; set; }
        public String descricao { get; set; }


        public String Descricao
        {
            get
            {
                return this.descricao.TrimEnd(' ');
            }
            set
            {
                this.descricao = value;
            }
        }
        public void cadastrar()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "INSERT INTO tbcensura (descricao, status) VALUES" +
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

        public void editar()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "UPDATE tbcensura set descricao=@descricao WHERE cod=@cod";

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

        public void excluir(int cod)
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "UPDATE tbcensura set status=@status WHERE cod=@cod";

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

        public List<Censura> getCensuras()
        {
            ArrayList censuras = new ArrayList();
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "SELECT cod, descricao FROM tbcensura WHERE status=true";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);


                NpgsqlDataReader npgsqlStatement = cmd.ExecuteReader();

                while (npgsqlStatement.Read())
                {
                    Censura g = new Censura();
                    g.cod = Convert.ToInt16(npgsqlStatement["cod"]);
                    g.Descricao = Convert.ToString(npgsqlStatement["descricao"]);
                    censuras.Add(g);
                }
                return censuras.Cast<Censura>().OrderBy(r => r.descricao).ToList();
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

        public List<Censura> getCensuras(String descricao)
        {
            ArrayList censuras = new ArrayList();
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "SELECT cod, descricao FROM tbcensura WHERE status=true " +
                    "and descricao like @descricao";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@descricao", "%" + descricao + "%");
                NpgsqlDataReader npgsqlStatement = cmd.ExecuteReader();


                while (npgsqlStatement.Read())
                {
                    Censura g = new Censura();
                    g.cod = Convert.ToInt16(npgsqlStatement["cod"]);
                    g.descricao = Convert.ToString(npgsqlStatement["descricao"]);
                    censuras.Add(g);
                }
                return censuras.Cast<Censura>().OrderBy(r => r.descricao).ToList();
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

        public Censura getCensura(int cod)
        {
            Censura g = new Censura();
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "SELECT cod, descricao FROM tbcensura WHERE status=true " +
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
