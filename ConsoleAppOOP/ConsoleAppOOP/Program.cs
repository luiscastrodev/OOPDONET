using ConsoleAppOOP._01_OOP._02_Pilares_OOP;
using System;
using static ConsoleAppOOP._01_OOP._02_Pilares_OOP.Heranca;

namespace ConsoleAppOOP
{
    internal class Program
    {

        //Pilares fundamentais da OOP

        //Na orientacao a objetos devemos sempre buscar o baixo acoplamento e a alta coesao entre os objetos

        //Acoplamento-> uma dependencia direta entre um objeto e outro. Quando um objeto muda o outro muda por consequencia
        //Coesao-> Objeto executando uma unica resposabilidade livres de uma dependencia direta com um outro objeto



        static void Main(string[] args)
        {
            //Neta neta = new Neta();
            //Console.WriteLine("Senha vista da classe Herança: " + neta.senhaPai);
            //Vizinho vizinho = new Vizinho(neta);
            new AutomacaoCafe().ServirCafe();
            Console.WriteLine();
            Console.ReadLine();
        }

        public class Pai
        {

            protected String senhaPai;

            public Pai()
            {
                this.senhaPai = "papaidanadao";
            }

        }

        public class Filha : Pai
        {

            public Filha()
            {
                Console.WriteLine("Senha vista pela filha: " + senhaPai);
            }


        }

        public class Neta : Filha
        {
            public Neta()
            {
                Console.WriteLine("Senha vista pela Neta: " + senhaPai);
            }
        }

        public class Vizinho
        {
            public Vizinho(Neta neta)
            {
               // Console.WriteLine("Senha vista pelo vizinho: " + neta.senhaPai);
            }
        }

    }
}
