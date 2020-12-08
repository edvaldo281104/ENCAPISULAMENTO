using System;
using ESCAPSULAMENTO.classes;

namespace ESCAPSULAMENTO
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();

            m.Parcelas = 12;
            m.Bandeira = "visa";
            
            Console.WriteLine(m.Bandeira);
        }
    }
}
