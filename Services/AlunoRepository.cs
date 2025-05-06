using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AlunoRepository
    {
        Config config = new Config();
        public bool ValidarAluno(int rm, string senha)
        {
            using (OracleConnection conexao = new OracleConnection(config._connectionString))
            {
                conexao.Open();
                string sql = $"SELECT COUNT(*) FROM TBL_ALUNOS_LOGIN WHERE NR_RM = '{rm}' AND DS_SENHA = '{senha}'";
                OracleCommand cmd = new OracleCommand(sql, conexao);

                object o = cmd.ExecuteScalar();

                if (int.Parse(o.ToString()) != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
