namespace TipCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tip Calculator");
            string YorN = "y";
            YorN = YorN.ToUpper();
            while (YorN == "Y")
            {
                Console.Write("Cost Of meal:  ");
                string mealcost = Console.ReadLine();
                Decimal MealCost = Decimal.Parse(mealcost);
                Decimal fifteenpercenttip = MealCost * 0.15m;
                Console.WriteLine("\n" + "15%");
                Console.WriteLine("Tip Amount :      $" + fifteenpercenttip.ToString("N2"));
                Decimal Totalwithfifteen = MealCost + fifteenpercenttip;
                Console.WriteLine("Total Amount:      $" + Totalwithfifteen.ToString("N2"));
                Decimal twentypercenttip = MealCost * 0.2m;
                Console.WriteLine("\n" + "20%");
                Console.WriteLine("Tip Amount :      $" + twentypercenttip.ToString("N2"));
                Decimal TotalwithTwenty = MealCost + twentypercenttip;
                Console.WriteLine("Total Amount:      $" + TotalwithTwenty.ToString("N2"));
                Decimal twentyfivepercenttip = MealCost * 0.25m;
                Console.WriteLine("\n" + "25%");
                Console.WriteLine("Tip Amount :      $" + twentyfivepercenttip.ToString("N2"));
                Decimal Totalwithtwentyfive = MealCost + twentyfivepercenttip;
                Console.WriteLine("Total Amount:      $" + Totalwithtwentyfive.ToString("N2"));
                
                Boolean success = false;
                while(!success)
                {
                    Console.WriteLine("Continue? y/n?");
                    string choice = Console.ReadLine();
                    choice = choice.ToUpper();
                    if (choice == "Y")
                    {
                        success = true;
                        YorN = choice;
                        break;
                    }
                    else if(choice == "N")
                    {
                        success = true;
                        YorN = choice;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter Y or N");
                       

                    }
                }
            }
        }
    }
}