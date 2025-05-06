using Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class FuncionarioRepository
    {
        Config config = new Config();
        public readonly string _connectionString = "User Id=rm558303;Password=fiap25;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));";

        public List<Funcionario> resgatarFuncionarios()
        {

        var funcionarios = new List<Funcionario>();
            using (OracleConnection conexao = new OracleConnection(_connectionString))
            {
                conexao.Open();
                string sql = "SELECT * FROM TBL_FUNCIONARIOS";
                using (var cmd = new OracleCommand(sql, conexao))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var funcionario = new Funcionario
                        {
                            IdFuncionario = reader.GetInt32(0),
                            NomeFuncionario = reader.GetString(1),
                            Cargo = reader.GetString(2),
                            Salario = reader.GetDecimal(3)
                        };

                        funcionarios.Add(funcionario);
                    }
                }
            }

            return funcionarios;
        }
    }
}
