using System;

namespace PINValidationThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta PIN-kood");
                string userPIN = Console.ReadLine();
                if (userPIN == "1234")
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

            Console.WriteLine("Kena päeva!");
        }
    }

}