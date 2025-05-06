using Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProdutosRepository
    {
        Config config = new Config();
        public List<Produto> resgatarProdutos()
        {
            var produtos = new List<Produto>();
            using (OracleConnection conexao = new OracleConnection(config._connectionString))
            {
                conexao.Open();
                string sql = $"SELECT * FROM TBL_PRODUTOS";
                using (var cmd = new OracleCommand(sql, conexao))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var produto = new Produto
                        {
                            IdProduto = reader.GetInt32(0),
                            NomeProduto = reader.GetString(1),
                            ValorPreco = reader.GetDecimal(2)
                        };

                        produtos.Add(produto);
                    }
                }
            }

            return produtos;
        }
        }
}
