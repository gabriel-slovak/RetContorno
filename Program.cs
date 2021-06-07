using System;

namespace RetContorno
{
    class Program
    {
        static void Main(string[] args)
        {
            int largura, altura;
            int valor1 = 1, valor2 = 1;
            bool larguraValido, alturaValido;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---Retângulo Contorno---\n");
            Console.ResetColor();


            Console.Write("Insira o Valor de Largura..: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            larguraValido = int.TryParse(Console.ReadLine(), out largura);
            Console.ResetColor();

            if (!larguraValido)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você digitou um valor invalido!");
                Console.ResetColor();
                Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(-1);
            }
            if (largura < 1 || largura > 10)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInsira números entre 1 a 10!\n");
                Console.ResetColor();
                Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(-1);
            }

            Console.Write("Insira o Valor de Altura...: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            alturaValido = int.TryParse(Console.ReadLine(), out altura);
            Console.ResetColor();
            if (!alturaValido)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nVocê digitou um valor invalido!\n");
                Console.ResetColor();
                Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(-1);
            }

            if (altura < 1 || altura > 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInsira números entre 1 a 10!\n");
                Console.ResetColor();
                Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(-1);
            }
            Console.WriteLine();

            while (valor1 <= altura)
            {
                while (valor2 <= largura)
                {
                    if (valor2 == 1 || valor2 == largura || valor1 == 1 || valor1 == altura)
                    {
                        Console.Write("+ ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    valor2++;
                }
                valor2 = 1;
                Console.WriteLine();
                valor1++;
                
            }
        }
    }
}