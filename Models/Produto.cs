using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Produto
    {

        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal ValorPreco { get; set; }

        public override string ToString()
        {
            return $"ID: {IdProduto} | Nome: {NomeProduto} | Válor: R${ValorPreco}";
        }
    }
}
