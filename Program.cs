using System;
using AulaPOOCelular.Classes;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {

            Celular celular1 = new Celular(); 

            Console.WriteLine("Digite as seguintes informações sobre seu celular: ");
            Console.Write("Cor: ");
            celular1.cor = Console.ReadLine();
            Console.Write("Modelo: ");
            celular1.modelo = Console.ReadLine();
            Console.Write("Tamanho: ");
            celular1.tamanho = double.Parse(Console.ReadLine());

            celular1.lOuD();

            celular1.acoes();
        }
    }
}
