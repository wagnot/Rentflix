using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentflix
{
    class Cliente
    {
        public int cod { get; set; }
        public String  nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public String sexo { get; set; }
        public string rg { get; set; }
        public String cpf { get; set; }
        public List<String> telefones { get; set; }
        public String logradouro { get; set; }
        public String bairro { get; set; }
        public String cidade { get; set; }
        public String estado { get; set; }
        public String cep { get; set; }

        public void Cadastrar()
       {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "INSERT INTO tbcliente (nome, data_nascimento, sexo, rg, cpf, " +
                    " logradouro, bairro, cidade, estado, cep, status) VALUES" +
                    "(@nome, @dataNascimento, @sexo, @rg, @cpf, " +
                    " @logradouro, @bairro, @cidade, @estado, @cep, @status)";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@nome", this.nome);
                cmd.Parameters.AddWithValue("@dataNascimento", this.dataNascimento);
                cmd.Parameters.AddWithValue("@sexo", this.sexo);
                cmd.Parameters.AddWithValue("@rg", this.rg);
                cmd.Parameters.AddWithValue("@cpf", this.cpf);
                cmd.Parameters.AddWithValue("@logradouro", this.logradouro);
                cmd.Parameters.AddWithValue("@bairro", this.bairro);
                cmd.Parameters.AddWithValue("@cidade", this.cidade);
                cmd.Parameters.AddWithValue("@estado", this.estado);
                cmd.Parameters.AddWithValue("@cep", this.cep);
                cmd.Parameters.AddWithValue("@status", true);

                cmd.ExecuteNonQuery();

                int cod = getUltimoCodigo();
                foreach(String tel in telefones)
                {
                    CadastrarTel(cod, tel);
                }

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
                string sql = "SELECT cod FROM tbcliente ORDER BY cod DESC LIMIT 1";

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

        public void CadastrarTel(int cod, String telefone)
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "INSERT INTO tbtelefone (codcliente, telefone, status) VALUES" +
                    "(@codcliente, @telefone, @status)";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@codcliente", cod);
                cmd.Parameters.AddWithValue("@telefone", telefone);
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
                string sql = "UPDATE tbcliente set nome=@nome, data_nascimento=@dataNascimento," +
                    " sexo=@sexo, rg=@rg, cpf=@cpf, logradouro=@logradouro," +
                    " bairro=@bairro, cidade=@cidade, estado=@estado, cep=@cep WHERE cod=@cod";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@nome", this.nome);
                cmd.Parameters.AddWithValue("@dataNascimento", this.dataNascimento);
                cmd.Parameters.AddWithValue("@sexo", this.sexo);
                cmd.Parameters.AddWithValue("@rg", this.rg);
                cmd.Parameters.AddWithValue("@cpf", this.cpf);
                cmd.Parameters.AddWithValue("@logradouro", this.logradouro);
                cmd.Parameters.AddWithValue("@bairro", this.bairro);
                cmd.Parameters.AddWithValue("@cidade", this.cidade);
                cmd.Parameters.AddWithValue("@estado", this.estado);
                cmd.Parameters.AddWithValue("@cep", this.cep);

                cmd.Parameters.AddWithValue("@cod", this.cod);

                cmd.ExecuteNonQuery();
                EditarTel(this.cod);
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

        private void EditarTel(int cod)
        {
            ExcluirTel(cod);
            foreach (String tel in telefones)
            {
                CadastrarTel(cod, tel);
            }
        }

        public void ExcluirTel(int cod)
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "UPDATE tbtelefone set status=@status WHERE codcliente=@codcliente";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@status", false);
                cmd.Parameters.AddWithValue("@codcliente", cod);

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
                string sql = "UPDATE tbcliente set status=@status WHERE cod=@cod";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@status", false);
                cmd.Parameters.AddWithValue("@cod", cod);

                cmd.ExecuteNonQuery();

                ExcluirTel(cod);
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

        public List<String> GetTelefones(int cod)
        {
            List<String> telefones = new List<String>();
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "SELECT telefone FROM tbtelefone WHERE codcliente=@codcliente and status=@status";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@codcliente", cod);
                cmd.Parameters.AddWithValue("@status", true);

                NpgsqlDataReader npgsqlStatement = cmd.ExecuteReader();

                while (npgsqlStatement.Read())
                {
                    telefones.Add(Convert.ToString(npgsqlStatement["telefone"]));
                }
                return telefones;
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

        public List<Cliente> GetClientes()
        {
            ArrayList clientes = new ArrayList();
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "SELECT cod, nome, data_nascimento, sexo, rg, cpf, " +
                    "logradouro, bairro, cidade, estado, cep FROM tbcliente WHERE status=true";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                
                NpgsqlDataReader npgsqlStatement = cmd.ExecuteReader();

                while (npgsqlStatement.Read())
                {
                    Cliente g = new Cliente
                    {
                       cod = Convert.ToInt16(npgsqlStatement["cod"]),
                        nome = Convert.ToString(npgsqlStatement["nome"]),
                        cpf = Convert.ToString(npgsqlStatement["cpf"]),
                        rg = Convert.ToString(npgsqlStatement["rg"]),
                        sexo = Convert.ToString(npgsqlStatement["sexo"]),
                        dataNascimento = Convert.ToDateTime(npgsqlStatement["data_nascimento"]),
                        logradouro = Convert.ToString(npgsqlStatement["logradouro"]),
                        bairro = Convert.ToString(npgsqlStatement["bairro"]),
                        cidade = Convert.ToString(npgsqlStatement["cidade"]),
                        estado = Convert.ToString(npgsqlStatement["estado"]),
                        cep = Convert.ToString(npgsqlStatement["cep"]),
                        
                    };

                    g.telefones = GetTelefones(g.cod);
                    clientes.Add(g);
                }
                return clientes.Cast<Cliente>().OrderBy(r => r.nome).ToList();
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

        public List<Cliente> GetClientes(String nome)
        {
            ArrayList clientes = new ArrayList();
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "SELECT cod, nome, data_nascimento, sexo, rg, cpf, " +
                    "logradouro, bairro, cidade, estado, cep FROM tbcliente WHERE status=true " +
                    "and nome like @nome";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                NpgsqlDataReader npgsqlStatement = cmd.ExecuteReader();


                while (npgsqlStatement.Read())
                {
                    Cliente c = new Cliente
                    {
                        cod = Convert.ToInt16(npgsqlStatement["cod"]),
                        nome = Convert.ToString(npgsqlStatement["nome"]),
                        cpf = Convert.ToString(npgsqlStatement["cpf"]),
                        rg = Convert.ToString(npgsqlStatement["rg"]),
                        sexo = Convert.ToString(npgsqlStatement["sexo"]),
                        dataNascimento = Convert.ToDateTime(npgsqlStatement["data_nascimento"]),
                        logradouro = Convert.ToString(npgsqlStatement["logradouro"]),
                        bairro = Convert.ToString(npgsqlStatement["bairro"]),
                        cidade = Convert.ToString(npgsqlStatement["cidade"]),
                        estado = Convert.ToString(npgsqlStatement["estado"]),
                        cep = Convert.ToString(npgsqlStatement["cep"])
                    };

                    c.telefones = GetTelefones(c.cod);
                    clientes.Add(c);
                }
                return clientes.Cast<Cliente>().OrderBy(r => r.nome).ToList();
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

        public Cliente GetCliente(int cod)
        {
            Cliente c = new Cliente();
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = "SELECT cod, nome, data_nascimento, sexo, rg, cpf, " +
                    "logradouro, bairro, cidade, estado, cep FROM tbcliente WHERE status=true " +
                    "and cod=@cod";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@cod", cod);
                NpgsqlDataReader npgsqlStatement = cmd.ExecuteReader();
                while (npgsqlStatement.Read())
                {
                    c.cod = Convert.ToInt16(npgsqlStatement["cod"]);
                    c.nome = Convert.ToString(npgsqlStatement["nome"]);
                    c.cpf = Convert.ToString(npgsqlStatement["cpf"]);
                    c.rg = Convert.ToString(npgsqlStatement["rg"]);
                    c.sexo = Convert.ToString(npgsqlStatement["sexo"]);
                    c.dataNascimento = Convert.ToDateTime(npgsqlStatement["data_nascimento"]);
                    c.logradouro = Convert.ToString(npgsqlStatement["logradouro"]);
                    c.bairro = Convert.ToString(npgsqlStatement["bairro"]);
                    c.cidade = Convert.ToString(npgsqlStatement["cidade"]);
                    c.estado = Convert.ToString(npgsqlStatement["estado"]);
                    c.cep = Convert.ToString(npgsqlStatement["cep"]);
                }
                c.telefones = GetTelefones(cod);
                return c;
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
