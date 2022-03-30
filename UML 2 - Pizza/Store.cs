using System;

namespace UML_2_PizzaStore
{
    public class Store
    {
        public void Start()
        {
            RunApp();
        }

        public void RunApp()
        {
            Console.WriteLine("Welcome To The Menu!");
            Console.WriteLine();
            Console.WriteLine("Please Select An Option!");
            Console.WriteLine();
            Console.WriteLine("1. Create A Pizza!");
            Console.WriteLine("2. Show Full Menu!");
            Console.WriteLine("3. Search For A Pizza By Number!");
            Console.WriteLine("4. Search For A Pizza By Name!");
            Console.WriteLine("5. Remove Pizza From Menu!");
            Console.WriteLine("To Close Program Press 'x'");

            var userinput = Console.ReadLine();
            MenuCatalog menuCatalog = new MenuCatalog();
            menuCatalog.PizzaList();

            while (true)

            {
                switch (userinput)
                {
                    case "1":
                        Console.Clear();
                        menuCatalog.CreatePizza();
                        break;

                    case "2":
                        Console.Clear();
                        menuCatalog.ShowFullMenu();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Please Enter A Number To Display Specific Pizza:");
                        int searchNumber = Convert.ToInt32(Console.ReadLine());
                        menuCatalog.SearchForPizzaNumber(searchNumber);
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Please Enter A Pizza Name Or Letters To Search For A Specific Pizza:");
                        var searchPhrase = Console.ReadLine();
                        menuCatalog.SearchForPizza(searchPhrase);
                        break;

                    case "5":
                        break;

                    case "x":
                        return;

                    default:
                        Console.WriteLine("Please Select Valid Option :-)");
                        break;

                }

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine();
                Console.WriteLine("Please Select New Option!");
                Console.WriteLine();
                Console.WriteLine("1. Create A Pizza!");
                Console.WriteLine("2. Show Full Menu!");
                Console.WriteLine("3. Search For A Pizza By Number!");
                Console.WriteLine("4. Search For A Pizza By Name!");
                Console.WriteLine("5. Remove Pizza From Menu!");
                Console.WriteLine("To Close Program Press 'x'");
                userinput = Console.ReadLine();


            }


        }


    }
}

