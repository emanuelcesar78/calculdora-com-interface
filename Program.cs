using System;

namespace cauculadora
{
    public interface ICalculo 
    {
        void Calculo(int numero,int numero2);

    }
    class Soma : ICalculo 
    {
        public void Calculo(int numero,int numero2) 
        {
            Console.WriteLine($"soma : {numero} + {numero2} = "+ (numero + numero2));
        }
    }
    class Diminuir : ICalculo 
    {
        public void Calculo(int numero,int numero2) 
        {
            Console.WriteLine($"diminuição: {numero} + {numero2} = "+( numero - numero2));
        }
    }
    class Divisão : ICalculo 
    {
        public void Calculo(int numero, int numero2)
        {
            Console.WriteLine($"Divisão: {numero} + {numero2} = "+ (numero/ numero2));
        }
    }

    class resultado 
    {
        static void Main(string[] args) 
        {
            int numero, numero2;

            Console.WriteLine("digite um numero :");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite um numero :");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Soma soma = new Soma();
            Diminuir diminuir = new Diminuir(); 
            Divisão divisão = new Divisão();

            soma.Calculo(numero, numero2);

            diminuir.Calculo(numero, numero2);

            divisão.Calculo(numero, numero2);




        }
    }
}