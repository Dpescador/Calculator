﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação você deseja realizar?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtrasão");
            Console.WriteLine("3 - Divisao");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("Tecle 0 para ajuda");
            Console.WriteLine("--------------------");

            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());
            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                case 0: Ajuda(); break;
                default: Menu(); break;
            }
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Primeiro valor:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Ajuda()
        {
            Console.Clear();
            Console.WriteLine("Ajuda:");
            Console.WriteLine("Tecle 1 para operação de soma.");
            Console.WriteLine("Tecle 2 para operação de subtrasão.");
            Console.WriteLine("Tecle 3 para operação de divisao.");
            Console.WriteLine("Tecle 4 para oepração de multiplicação.");
            Console.WriteLine("Tecle 5 para sair da calculadora.");
            Console.WriteLine("Precione qualquer tecla pra retornar ao menu.");
            Console.ReadKey();
            Menu();
        }
    }
}