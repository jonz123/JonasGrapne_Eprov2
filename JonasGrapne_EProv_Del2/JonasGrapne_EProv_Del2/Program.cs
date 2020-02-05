using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonasGrapne_EProv_Del2
{
    class Program
    {

        public static string inputS = "";
        public static int inputI = 0;
        public static bool loop = true; //kom på senare att while = true och { break } existerar, men men...

        static void Main(string[] args)
        {

            Random rnd = new Random();
            List<Car> carList = new List<Car>();

            Console.WriteLine("Hur många bilar ska skapas?");

            SpellCheck();

            Car car = new Car();
            carList.Add(car); //behövs en tom!

            for (int i = 0; i < inputI; i++)
            {
                int randomCars = rnd.Next(0, 2);
                if (randomCars == 0)
                {
                    CleanCar cleanCar = new CleanCar();
                    carList.Add(cleanCar);
                }
                else
                {
                    ContrabandCar contrabandCar = new ContrabandCar();
                    carList.Add(contrabandCar);
                }
            }
            Console.WriteLine();
            bool loop2 = true;
            while (loop2 == true)
            {
                Console.WriteLine();
                Console.WriteLine("Vilken bil vill du titta på?");
                SpellCheck();

                Console.WriteLine();
                if (inputI > carList.Count) //Om det skrivna antalet är högre än hur många bilar som faktiskt finns
                {
                    Console.WriteLine("Så många bilar finns det inte.");
                }
                else if (carList[inputI].alreadyChecked == true) //Om bilen redan är checkad
                {
                    Console.WriteLine("Du har redan kollat den här bilen.");
                }
                else //Om inget är fel så kan sökningen gå igenom
                {
                    Console.WriteLine("Det finns " + carList[inputI].passengers + " passagerare i denna bil.");
                    carList[inputI].Examine();
                    if (carList[inputI].Examine() == true)
                    {
                        Console.WriteLine("Det finns knark i bilen!! :OOOo");
                    }
                }
            }
        }

        static void SpellCheck() //Det blev för jobbigt och rörigt att skriva om denna kod vid olika tillfällen, bättre som en metod
        {
            inputS = Console.ReadLine();
            loop = true;
            while (loop == true) //tittar om det är ett legit svar (enbart siffror, över 0)
            {
                if (int.TryParse(inputS, out inputI) == false) //bokstäver?
                {
                    Console.WriteLine("Använd enbart siffror.");
                    inputS = Console.ReadLine();
                }
                else if (inputI <= 0) //över 0?
                {
                    Console.WriteLine("Det måste vara större än 0.");
                    inputS = Console.ReadLine();
                }
                else if (inputI > 0)
                {
                    loop = false;
                }
            }
        }

    }
}
