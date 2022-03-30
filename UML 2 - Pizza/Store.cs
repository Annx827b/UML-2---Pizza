using System;
using UML_2___Pizza;

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
            CustomerCatalog customerCatalog = new CustomerCatalog();
            MenuCatalog menuCatalog = new MenuCatalog();
            menuCatalog.UserMenu();
            var userinput = Console.ReadLine();
            menuCatalog.PizzaList();
            customerCatalog.CustomerList();

            while (true)

            {
                switch (userinput)
                {
                    case "1":
                        Console.Clear();
                        try
                        {
                            menuCatalog.CreatePizza();
                        }
                        catch(Exception)
                        {
                            Console.WriteLine($"No Pizza Was Created");
                        }
                        break;

                    case "2":
                        Console.Clear();
                        menuCatalog.ShowFullMenu();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Choose The Number Of The Pizza You Want To Update!");
                        Console.WriteLine();
                        menuCatalog.ShowFullMenu();
                        int numberOfPizza = Convert.ToInt32(Console.ReadLine());
                        menuCatalog.UpdatePizza(numberOfPizza);
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Please Enter A Pizza Name Or Letters To Search For A Specific Pizza:");
                        var searchPhrase = Console.ReadLine();
                        menuCatalog.SearchForPizza(searchPhrase);
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Please Choose The Number Of The Pizza You Want To Remove From The Menu:");
                        menuCatalog.ShowFullMenu();
                        int pizzaNumber = Convert.ToInt32(Console.ReadLine());
                        menuCatalog.RemovePizza(pizzaNumber);
                        break;

                    case "6":
                        Console.Clear();
                        try
                        {
                            customerCatalog.CreateCustomer();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No Customer Was Created");
                        }
                        break;

                    case "7":
                        Console.Clear();
                        customerCatalog.AllCustomers();
                        break;

                    case "8":
                        Console.Clear();
                        Console.WriteLine("Choose The Number Of The Customer You Want To Update!");
                        customerCatalog.AllCustomers();
                        Console.WriteLine();
                        int numberOfCustomer = Convert.ToInt32(Console.ReadLine());
                        customerCatalog.UpdateCustomer(numberOfCustomer);
                        break;

                    case "9":
                        Console.Clear();
                        Console.WriteLine("Please Enter A Customer Name Or Letters To Search For A Specific Customer:");
                        var search = Console.ReadLine();
                        customerCatalog.SearchForCustomer(search);
                        break;

                    case "10":
                        Console.Clear();
                        Console.WriteLine("Please Choose The Number Of The Customer You Want To Remove From The Customer Catalog:");
                        customerCatalog.AllCustomers();
                        int numberCustomer = Convert.ToInt32(Console.ReadLine());
                        customerCatalog.RemoveCustomer(numberCustomer);
                        break;

                    case "x":
                        return;

                    default:
                        Console.WriteLine("Please Select Valid Option :-)");
                        break;

                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press 'o' To Return To Menu!");
                if (userinput == "o")
                {
                    menuCatalog.UserMenu();
                }
                userinput = Console.ReadLine();

            }


        }


    }
}

