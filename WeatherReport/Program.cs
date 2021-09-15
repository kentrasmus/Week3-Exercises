using System;

namespace WeatherReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib mitu kraadi õues on;
            //kui õues on rohkem kui 35 kraadi, programm kuvab"boiling hot"
            //kui õues on 30 kuni 35 kraadi, programm kuvab "hot";
            //kui õues on 20 kuni 30 kraadi, programm kuvab "Nice";
            //kui õues on 10 kuni 20 kraadi, programm kuvab "chilly"
            //kui õues on 0 kuni 10 kraadi, programm kuvab "Cold"
            /*  Console.WriteLine("Mitu kraadi õues on?");
          int Kraad = Convert.ToInt32(Console.ReadLine());
            //case var _ when kraad < 0 
            //case var _ when(kraad > 0 && temp <10)
          switch (Kraad)
          {
              case 35: Console.WriteLine(" Liiga soe on tra"); break;
              case 34: Console.WriteLine(" Liiga soe on tra"); break;
              case 33: Console.WriteLine(" Liiga soe on tra"); break;
              case 32: Console.WriteLine(" Liiga soe on tra"); break;
              case 31: Console.WriteLine(" Liiga soe on tra"); break;
              case 30: Console.WriteLine(" Liiga soe on tra"); break;


              case 29: Console.WriteLine("Suht soe"); break;
              case 28: Console.WriteLine("Suht soe"); break;
              case 27: Console.WriteLine("Suht soe "); break;
              case 26: Console.WriteLine("Suht soe "); break;
              case 25: Console.WriteLine("Suht soe "); break;
              case 24: Console.WriteLine("Suht soe "); break;
              case 23: Console.WriteLine("Suht soe "); break;
              case 22: Console.WriteLine("Suht soe "); break;
              case 21: Console.WriteLine("Suht soe "); break;
              case 20: Console.WriteLine("Suht soe "); break;


              case 19: Console.WriteLine("Chilly "); break;
              case 18: Console.WriteLine("Chilly "); break;
              case 17: Console.WriteLine("Chilly "); break;
              case 16: Console.WriteLine("Chilly "); break;
              case 15: Console.WriteLine("Chilly "); break;
              case 14: Console.WriteLine("Chilly "); break;
              case 13: Console.WriteLine("Chilly "); break;
              case 12: Console.WriteLine("Chilly "); break;
              case 11: Console.WriteLine("Chilly "); break;
              case 10: Console.WriteLine("Chilly "); break;


              case 9: Console.WriteLine("Külm tra "); break;
              case 8: Console.WriteLine("Külm tra "); break;
              case 7: Console.WriteLine("Külm tra "); break;
              case 6: Console.WriteLine("Külm tra "); break;
              case 5: Console.WriteLine("Külm tra "); break;
              case 4: Console.WriteLine("Külm tra "); break;
              case 3: Console.WriteLine("Külm tra "); break;
              case 2: Console.WriteLine("Külm tra "); break;
              case 1: Console.WriteLine("Külm tra "); break;

              default: Console.WriteLine("Õues on liiga soe või külm"); break;
            }

          */



            Console.WriteLine("Mitu kraadi õues on?");

            int kraad = Int32.Parse(Console.ReadLine());

            if(kraad >= 30 && kraad < 35)
            {
                Console.WriteLine("Liiga soe tra");
            }
            else if(kraad >= 20 && kraad <30)
            {
                Console.WriteLine("suht soe");
            }
            else if(kraad >= 10 && kraad <20)
            {
                Console.WriteLine("Chilly");
            }
            else if(kraad >= 0 && kraad <10)
            {
                Console.WriteLine("Külm tra");
            }
            else if(kraad < 0)
            {
                Console.WriteLine("Külm traaaaaa");
            }
            
                
            
            
                
            

        }
    }
}
