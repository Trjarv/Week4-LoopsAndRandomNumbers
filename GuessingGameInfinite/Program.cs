using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvate, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikku numbrit üks korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            bool loopActive = true;
            int i = 0;

            Console.WriteLine("Palun sisesta arvatav number 1-10:");

            while(loopActive)
            {
                int myRandomNumber = rnd.Next(1, 11);
                int userArv = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Juhuslik number on: {myRandomNumber}");
                
                if (userArv == myRandomNumber)
                {
                    Console.WriteLine("Oled võitnud!");
                    i = myRandomNumber;
                    loopActive = false;
                }
                else 
                {
                    i++;
                    Console.WriteLine("Vale arv. Arvuti võitis. Proovi uuesti!");
                }
            }
        }
    }
}