using System;
using System.Collections.Generic;

namespace Diamantes_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo ao diamantes 2022.\nInforme um numero impar entre 3 e 21:");
            int impar = Convert.ToInt32(Console.ReadLine());
            List<string> lista = new List<string>();

            if (impar % 2 == 0) Console.WriteLine("Tu inseristes um valor inválido.");
            else
            {
                int metade = impar / 2, contador = 1; ;
                string valor = "";

                for (int x = 0; x < impar; x++) valor += " ";

                for (int x = 0; x < impar; x++) lista.Add(valor);

                for (int x = 0; x < metade; x++)
                {
                    for (int y = 0; y < contador; y++) lista[x] = lista[x].Remove(lista[x].Length / 2, 1);

                    for (int y = 0; y < contador; y++) lista[x] = lista[x].Insert(lista[x].Length / 2, "x");

                    lista[lista.Count - 1 - x] = lista[x];

                    contador += 2;
                }
                lista[lista.Count / 2] = lista[lista.Count / 2].Replace(" ", "x");

                for (int x = 0; x < lista.Count; x++) Console.WriteLine(lista[x]);
            }
        }
    }
}