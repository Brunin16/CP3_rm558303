using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string NomeFuncionario { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

        public override string ToString()
        {
            return $"ID: {IdFuncionario} | Nome: {NomeFuncionario} | Cargo: {Cargo} | Salário: R${Salario}";
        }

    }
}
