using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP._01_OOP._02_Pilares_OOP
{
    //Criar conceitos genericos que podem ser abstraidos por outras classes
    public abstract class Eletrodomestico//nao pode ser herdade somente instanciada
    {
        private readonly string _nome;
        private readonly int _voltagem;

        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        //nao eh obrigatorio implementar o comportamento. porem a classe que extends sim 
        public abstract void Ligar();
        public abstract void Desligar();
    }
}
