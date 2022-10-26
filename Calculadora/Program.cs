using System;

namespace Calculadora
{
    class App
    {
        static void Main()
        {
            
            int cod;
            var func = new Function();

            do
            {
                Console.WriteLine("|------------------------|------------------------------|");
                Console.WriteLine("|        Funções         |           Código             |");
                Console.WriteLine("|------------------------|------------------------------|");
                Console.WriteLine("|          Soma          |              1               |");
                Console.WriteLine("|        Subtração       |              2               |");
                Console.WriteLine("|         Divisão        |              3               |");
                Console.WriteLine("|      Multiplicação     |              4               |");
                Console.WriteLine("|          Sair          |              5               |");
                Console.WriteLine("|------------------------|------------------------------|");

                Console.WriteLine("\nDigite o código:");
                cod = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (cod)
                {
                    case 1:
                        func.Retorno();
                        Console.Clear();
                        func.Soma();                        
                    break;

                    case 2:
                        func.Retorno();
                        Console.Clear();
                        func.Subtracao();                      
                    break;

                    case 3:
                        func.Retorno();
                        Console.Clear();
                        func.Divisao();                       
                    break;

                    case 4:
                        func.Retorno();
                        Console.Clear();
                        func.Multiplicacao();
                        break;

                    case 5:
                        Console.WriteLine("O Programa irá fechar!!!");
                    break;
                    default:
                        Console.WriteLine("Código Inválido");
                    break;
                }
            } while (cod != 5);
        }
    }
}