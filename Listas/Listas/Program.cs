using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Jão");
            list.Add("Aão");
            list.Add("Vão");

            Console.WriteLine("List count:"+list.Count);

            Console.WriteLine("---------------------------------");
            //Listar nome que possuem letra 'A' como primeiro caractere
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro nome com inicial 'A': " + s1);

            Console.WriteLine("---------------------------------");
            //Listar nomes que possuem letra 'A' como primeiro caractere na primeira posição
            int pos1 = list.FindIndex(x => x[0] == 'A');

            Console.WriteLine("Primeira POSISÃO com inicial 'A': " + pos1);


            Console.WriteLine("---------------------------------");
            //Listar nomes que possuem letra 'A' como ultimo caractere na ultima posição
            int pos2 = list.FindLastIndex(x => x[0] == 'A');

            Console.WriteLine("Ultima POSISÃO com inicial 'A': " + pos2);

            Console.WriteLine("---------------------------------");


            //Listar nomes que possuem 5 caracteres
            List<string> resultado = list.FindAll(x => x.Length == 5);

            foreach(string obj in resultado)
            {
                Console.WriteLine(obj);
            }


            Console.WriteLine("---------------------------------");
            //Remover elemento no nome tal
            list.Remove("Aão");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------------");
            //Remover elementos com inicial 'o'
            list.RemoveAll(x => x[0] == 'o');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------------");

            //Remover tal elemento na posição tal
            list.RemoveAt(2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------------");

            //Apartir da posição tal, remover trantos elementos
            list.RemoveRange(0, 2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
