using System;

namespace UML_2_PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What Do You Want To Do?");
            Console.WriteLine("1 Create New Pizza");
            Console.WriteLine("2 Show Menu");
            Console.WriteLine("3 Search For Pizza By Name");
            Console.WriteLine("4 Remove Pizza From Menu");
            Console.WriteLine("Press 'X' To Exit Program.");

            var userInput = Console.ReadLine();

            var menuCatalog = new MenuCatalog();

            while (true)
            {

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Pizza Number:");
                        var numberOfPizza = Console.ReadLine();
                        Console.WriteLine("Pizza Name:");
                        var nameOfPizza = Console.ReadLine();
                        Console.WriteLine("Pizza Toppings. Please use ',' Between Each Topping!:");
                        var toppings = Console.ReadLine();
                        Console.WriteLine("Pizza Price:");
                        var priceOfPizza = Console.ReadLine();

                        Pizza p = new Pizza(Convert.ToInt32(numberOfPizza), nameOfPizza, Convert.ToDouble(priceOfPizza), toppings);
                        pizzaList.Add(p);

                        break;
                    case "2":
                        menuCatalog.ShowFullMenu();
                        break;

                    case "3":
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Select Valid Option");
                        break;

                }
                Console.WriteLine("Select New Option");
                userInput = Console.ReadLine();
            }


        }
    }
}
