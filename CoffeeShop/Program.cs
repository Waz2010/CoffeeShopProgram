using System;

namespace CoffeeShop
{
    class Program
    {
        public static void Main(string[] args)
        {

            string userString = string.Empty;

            for (int i = 1; i < 10000; i++)
            {
                userString += i.ToString() + " ";


            }
            Console.WriteLine(userString);
            Console.WriteLine("Test content");
            Console.ReadLine();


            int Total = 0;
            string UserDecision = string.Empty;
            do
            {
                int CoffeeSize = -1;
                do
                {
                    //Buy a cup of coffee.
                    Console.WriteLine("Please Select your coffee. 1 - Small. 2 - Medium. 3. Larg.");
                    CoffeeSize = int.Parse(Console.ReadLine());

                    switch (CoffeeSize)
                    {
                        case 1:
                            Total += 1;
                            break;
                        case 2:
                            Total += 2;
                            break;
                        case 3:
                            Total += 3;
                            break;
                        default:
                            Console.WriteLine("Invalid choice: Please Select your coffee. 1 - Large. 2 - Medium. 3. Small.");
                            break;
                    }
                } while (CoffeeSize != 1 && CoffeeSize != 2 && CoffeeSize != 3);

                do
                {
                    Console.WriteLine("Do you want to buy another cofee - Yes or No");
                    UserDecision = Console.ReadLine().ToUpper();
                    if (UserDecision != "YES" && UserDecision != "NO")
                    {
                        Console.WriteLine("Your choice is {0} invalid. Please Try agine...", UserDecision);
                    }
                } while (UserDecision != "YES" && UserDecision != "NO");
            }while (UserDecision.ToUpper() != "NO");

            //Final recipt:
            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Total Bill Amount = ${0}", Total);
            Console.ReadLine();
        }
    }
}



