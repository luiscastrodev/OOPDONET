using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP._01_OOP._02_Pilares_OOP
{
    public class Heranca
    {
        public class Funcionario : Pessoa
        {
            public DateTime DataAdmissao { get; set; }

            public string Registro { get; set; }
        }

        public class Processo
        {
            public void Execucao()
            {
                var funcionario = new Funcionario()
                {
                    Nome = "Joao da Silva",
                    DataNascimento = Convert.ToDateTime("1990/01/01"),
                    DataAdmissao = DateTime.Now,
                    Registro = "21542"
                };
            }
        }
    }
}
