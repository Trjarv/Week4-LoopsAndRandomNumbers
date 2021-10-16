using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvate, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti.
            //*programm genereerib juhuslikku numbrit üks korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            Console.WriteLine("Palun sisesta arvatav number 1-10:");

            int i = 0;
            while (i < 3)
            {
                int myRandomNumber = rnd.Next(1, 11);
                int userArv = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Juhuslik number on: {myRandomNumber}");

                if (userArv == myRandomNumber)
                {
                    Console.WriteLine("Oled võitnud!");
                    i = myRandomNumber;
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale number. {3 - i} katset on jäänud.");
                    Console.WriteLine("Arvuti võitis.");
                }
            }
        }
    }
}
