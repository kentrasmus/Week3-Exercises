using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks;
            //miinimum matemaatikas 85 punkti;
            //miinimum keemias 90 punkti;
            //miinimun bioloogias 95 punkti;
            //programm küsib kasutajal sisestada tema
            //eksami punktid ja otsustab, kas kasutaja 
            //saab arstiks õppida

            Console.WriteLine("Palun sisesta oma punkti arv");
            Console.WriteLine("Matemaatika punktid");

            int TulemusA = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Keemia punktid");

            int TulemusB = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Bioloogia punktid");

            int TulemusC = Int32.Parse(Console.ReadLine());

            
            if (TulemusA >= 85 && TulemusB >= 90 && TulemusC >= 95)
            {
                Console.WriteLine("Tubli saad arstiks õppida!");
            }
            else
            {
                Console.WriteLine("Sa ei saa arstiks õppida!");
            }
        }
    }
}
