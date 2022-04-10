using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP._01_OOP._02_Pilares_OOP
{
    //Ter multiplos comportamento para alguma coisa
    public class CafereitaEspressa : Eletrodomestico
    {
        public CafereitaEspressa(string nome, int voltagem) 
            : base(nome, voltagem) {
            Console.WriteLine(nome + voltagem);

        }


        public CafereitaEspressa(): base("Padrao", 220) {
            Console.WriteLine();
        }


        private static void AquecerAgua() { }
        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            AquecerAgua();
            MoerGraos();
            //....etc
        }
        public override void Ligar()
        {
            //verificar recipiente de agua
        }
        public override void Desligar()
        {
           //Resfriar aquecedor
        }

        public override void Testar()
        {
            base.Testar();
        }


    }
}
