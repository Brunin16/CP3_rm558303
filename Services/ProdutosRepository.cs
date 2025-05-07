using Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class ProdutosRepository
    {
        Config config = new Config();

        public List<Produto> resgatarProdutos()
        {
            var produtos = new List<Produto>();

            try
            {
                using (OracleConnection conexao = new OracleConnection(config._connectionString))
                {
                    conexao.Open();
                    string sql = "SELECT * FROM TBL_PRODUTOS";

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
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Erro Oracle ao buscar produtos: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado ao buscar produtos: {ex.Message}");
            }

            return produtos;
        }
    }
}
