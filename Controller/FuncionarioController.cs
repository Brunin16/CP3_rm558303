using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class FuncionarioController
    {
        public void listarFuncionarios()
        {
            FuncionarioRepository funcionarioRepository = new FuncionarioRepository();
            int qnt = 0;
            Decimal total = 0;
            Decimal maior = 0;
            string fmaior = "";
            foreach (var func in funcionarioRepository.resgatarFuncionarios())
            {
                if (maior < func.Salario)
                {
                    fmaior = func.NomeFuncionario;
                    maior = func.Salario;  
                }
                qnt++;
                total += func.Salario;
                Console.WriteLine(func.ToString());
            }
                Console.WriteLine($"O preco total de todos somados é {total}, a quantide é {qnt}, e o maior salario é {maior} e pertence a {fmaior}");

        }
    }
}
