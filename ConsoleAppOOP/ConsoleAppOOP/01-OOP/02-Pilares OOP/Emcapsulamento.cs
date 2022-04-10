using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP._01_OOP._02_Pilares_OOP
{
    public class AutomacaoCafe
    {
        public void ServirCafe()
        {
            var expresso = new CafereitaEspressa("teste",54);
            expresso.Ligar();
            expresso.PrepararCafe();
            expresso.Desligar();
        }
    }
}
