using Oracle.ManagedDataAccess.Client;
using System;

namespace Repository
{
    public class AlunoRepository
    {
        Config config = new Config();

        public bool ValidarAluno(int rm, string senha)
        {
            try
            {
                using (OracleConnection conexao = new OracleConnection(config._connectionString))
                {
                    conexao.Open();
                    string sql = $"SELECT COUNT(*) FROM TBL_ALUNOS_LOGIN WHERE NR_RM = '{rm}' AND DS_SENHA = '{senha}'";
                    OracleCommand cmd = new OracleCommand(sql, conexao);

                    object o = cmd.ExecuteScalar();

                    return int.Parse(o.ToString()) != 0;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Erro ao acessar o banco de dados Oracle: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
                return false;
            }
        }
    }
}
