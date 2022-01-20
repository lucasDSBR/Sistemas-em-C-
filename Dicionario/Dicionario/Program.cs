using System;
using System.Collections.Generic;

namespace Dicionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();


            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "21312234";

            Console.WriteLine(cookies["phone"]);
            Console.WriteLine(cookies["email"]);



            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }


            Console.WriteLine("Size: " + cookies.Count);


            Console.WriteLine("ALL COOKIES: ");
            foreach(KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": "+ item.Value);
            }
        }
    }
}
