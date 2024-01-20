//author: Rod Mastria	
//date: Jan 2024
//topic: Lab 1, Task 1
//framework: dotNet 8

public class Program
{

    private static int sodaCount = 100;
    private static int chipsCount = 40;
    private static int candyCount = 60;

    private static string spaceChar = " ";

    const int SODA_LOW = 40;
    const int CHIPS_LOW = 20;
    const int CANDY_LOW = 40;

    public static void Main()

    {

        Console.WriteLine("--------------Snack Stock Assistant--------------");
        Console.WriteLine("-------------------------------------------------");

        DisplayPrompts();

        DisplayResults();

        Console.WriteLine(); // white space for better UX
        Console.WriteLine("Press enter to close the assistant");
        Console.ReadLine();

    }

    private static void DisplayPrompts()
    {

        // SODA
        Console.WriteLine("How many sodas have been sold today?" + spaceChar + sodaCount + spaceChar + "in stock");
        int sodaSalesCount = int.Parse(Console.ReadLine());
        if (sodaSalesCount > 100)
        {
            Console.WriteLine("You entered" + spaceChar + sodaSalesCount + spaceChar + "(too high!) Stock not adjusted");
        }
        else // assume the input is valid
        {
            sodaCount -= sodaSalesCount; // update stock count
            Console.WriteLine(sodaCount + spaceChar + "sodas left in stock");
        }

        // CHIPS
        Console.WriteLine();
        Console.WriteLine("How many chips have been sold today?" + spaceChar + chipsCount + spaceChar + "in stock");
        int chipSalesCount = int.Parse(Console.ReadLine());
        if (chipSalesCount > chipsCount)
        {
            Console.WriteLine("You entered" + spaceChar + chipSalesCount + spaceChar + "(too high!) Stock not adjusted");
        }
        else // assume the input is valid
        {
            chipsCount -= chipSalesCount; // update stock count
            Console.WriteLine(chipsCount + spaceChar + "chips left in stock");
        }

        // CANDY
        Console.WriteLine();
        Console.WriteLine("How many candy bags have been sold today?" + spaceChar + candyCount + spaceChar + "in stock");
        int candySalesCount = int.Parse(Console.ReadLine());
        if (candySalesCount > candyCount)
        {
            Console.WriteLine("You entered" + spaceChar + candySalesCount + spaceChar + "(too high!) Stock not adjusted");
        }
        else // assume the input is valid
        {
            candyCount -= candySalesCount; // update stock count
            Console.WriteLine(candyCount + spaceChar + "candy bags left in stock");
        }
    }

    private static void DisplayResults() {

        bool lowStock = true;


        if (candyCount > CANDY_LOW && 
            chipsCount > CHIPS_LOW && 
            sodaCount > SODA_LOW) {
            lowStock = false;
        }

        Console.WriteLine();
        Console.WriteLine("-------------------------------------------------");

        if (!lowStock)
        {
            Console.WriteLine(); // white space for better UX
            Console.WriteLine("Result: no need to re-stock today");
            return;
        }

        Console.WriteLine("Result: please re-stock the following product(s)");

        if (sodaCount <= SODA_LOW)
        {
            Console.WriteLine("- Soda");
        }

        if (chipsCount <= CHIPS_LOW)
        {
            Console.WriteLine("- Chips");
        }

        if (candyCount <= CANDY_LOW)
        {
            Console.WriteLine("- Candy bags");
        }

    }

}