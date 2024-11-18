using System;
namespace Uppgift_3._10
{
    class Program


    {
        static void Main(string[] args)

        {
            Console.Write("Hur många timmar vill du hyra bilen? ");
            int timmar = int.Parse(Console.ReadLine());

            int kostnad;

            
            if (timmar * 80 > 950)
            {
                kostnad = 950;
            }
            else
            {
                kostnad = timmar * 80;
            }

            {
                Console.WriteLine("Kostnaden för att hyra bilen är: " + kostnad + " kr.");
            }

              
        }
    }






    

















}





    



