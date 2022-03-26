using System;

namespace UML_2_PizzaStore
{
    public class Store
    {
        MenuCatalog _menuCatalog = new MenuCatalog();
        
        public static void RunApp()
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
                MenuCatalog menucatalog = new MenuCatalog();
           

            while (true)
            {

                switch (userinput)
                {
                    case "1":
                        menucatalog.PizzaList();
                        menucatalog.CreatePizza();
                        break;

                    case "2":
                        menucatalog.ShowFullMenu();
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "x":
                        return;

                    default:
                        Console.WriteLine("Please Select Valid Option :-)");
                        break;

                }
                
                Console.WriteLine("Please Select New Option");
                userinput = Console.ReadLine();
                 
            }
            

        }
    }
}
