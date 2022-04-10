using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP._01_OOP._02_Pilares_OOP
{
    public class Pessoa
    {

        //Estado propriedades dessa classe, ela possui um estado , tem um estado definido
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }


        //Transforma data de nascimento em idade , comportamento transformando informacoes e devolvendo outro
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;


            return idade;
        }
    }
}
