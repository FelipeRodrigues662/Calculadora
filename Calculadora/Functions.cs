using System;
using System.Runtime.Intrinsics;

namespace Calculadora
{
    class Function {

        private float valor1, valor2;

        public void Retorno() 
        {
            Console.WriteLine("Digite o Valor 1:");
            valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor 2:");
            valor2 = float.Parse(Console.ReadLine());
        }

        public void Soma()
        {
            Console.WriteLine($"{valor1}+{valor2} = {valor1+valor2}\n");
        }

        public void Subtracao()
        {
            Console.WriteLine($"{valor1}-{valor2} = {valor1 - valor2}\n");
        }

        public void Divisao()
        {
            Console.WriteLine($"{valor1}/{valor2} = {valor1 / valor2}\n");
        }

        public void Multiplicacao()
        {
            Console.WriteLine($"{valor1}X{valor2} = {valor1 * valor2}\n");
        }
    }
}