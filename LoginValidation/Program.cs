using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus");
                string kt = Console.ReadLine();
                Console.WriteLine("Sisesta kasutaja parool");
                string pr = Console.ReadLine();
                if (kt == "admin" && pr == "admin1234")
                {
                    Console.WriteLine("Tere tulemast");
                    break;

                }
                else
                {
                    Console.WriteLine($"Vale PIN, {3 - i } katset on jäänud");
                    i = i + 1;
                }




            }
        }
    }

}
