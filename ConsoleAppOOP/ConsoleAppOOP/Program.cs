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
            Funcionario funcionario = new Funcionario();

            funcionario.CalcularIdade();

            Console.WriteLine("Hello World!");
        }     
    }
}
