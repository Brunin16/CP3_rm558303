using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ProdutosController
    {
        public void listarProdutos()
        {
            ProdutosRepository produtosRepository = new ProdutosRepository();
            int qnt = 0;
            Decimal total = 0;
            foreach (var produto in produtosRepository.resgatarProdutos())
            {
                qnt += 1;
                total += produto.ValorPreco;
                Console.WriteLine(produto.ToString());
            }
            Console.WriteLine($"A media dos produtos é {total/ qnt} e o preco total dos produtos é {total} e a quantidade é {qnt}");
        }
    }
}
