using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Controller
{
    public class AlunoController
    {
        public bool ValidarAluno(int rm, string senha)
        {
            AlunoRepository alunoRepository = new AlunoRepository();
            return alunoRepository.ValidarAluno(rm, senha);
        }
        public void ValidarSegurancaSenha(string senha)
        {
            string caracteresEspeciais = @"[!@#\$%\^&\*\(\)\-_=+\[\]\{\}\\|;:'"",<>\./\?]";

            if (!Regex.IsMatch(senha, caracteresEspeciais))
            {
                Console.WriteLine("ALERTA: Sua senha é considerada insegura pois não contém caracteres especiais. Recomendamos alterá-la em breve.");
            }
            else
            {
                Console.WriteLine("Senha verificada com sucesso.");
            }
        }
    }
}
