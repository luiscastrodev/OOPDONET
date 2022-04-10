using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP._01_OOP.ClasseVsObjeto
{
    //Definicao de Classe
    public class Casa
    {
        public int TamanhoM2 { get; set; }

        public int Andares { get; set; }

        public decimal Valor { get; set; }

        public int NumeroVagas { get; set; }

    }

    public class Objeto
    {
        public Objeto()
        {
            //classe sendo instanciada e sendo alocada na memoria.
            //Definicao de Objeto , eh alocada na memoria ali tem um objeto do tipo x
            var casa = new Casa
            {
                TamanhoM2 = 100,
                Andares = 2,
                Valor = 10000,
                NumeroVagas = 3
            };
        }
    }
}
