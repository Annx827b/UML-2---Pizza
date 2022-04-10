using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UML_2_PizzaStore
{
    public class MenuCatalog
    {
        #region My List
        public List<Pizza> pizzaList = new List<Pizza>();
        #endregion

        #region My Methods

        #region Pizza List
        public void PizzaList()
        {
            Pizza pizza1 = new Pizza(1, "Hawaii", 85, "Ham, Pineapple, Cheese");
            Pizza pizza2 = new Pizza(2, "Veggie", 80, "Bellpepper, Olives, Mushrooms");
            Pizza pizza3 = new Pizza(3, "House Special", 90, "Kebab, Chili, Cheese");
            Pizza pizza4 = new Pizza(4, "Capricosa", 60, "Mushrooms, Ham, Cheese");

            pizzaList.Add(pizza1);
            pizzaList.Add(pizza2);
            pizzaList.Add(pizza3);
            pizzaList.Add(pizza4);

        }
        #endregion

        #region UserMenu
        public void UserMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome To The Menu!");
            Console.WriteLine();
            Console.WriteLine("Please Select An Option!");
            Console.WriteLine();
            Console.WriteLine("PIZZA");
            Console.WriteLine();
            Console.WriteLine("1. Create A Pizza!");
            Console.WriteLine("2. Show Full Menu!");
            Console.WriteLine("3. Update A Pizza!");
            Console.WriteLine("4. Search For A Pizza!");
            Console.WriteLine("5. Remove Pizza From Menu!");
            Console.WriteLine();
            Console.WriteLine("COSTUMERS");
            Console.WriteLine();
            Console.WriteLine("6. Create A Costumer!");
            Console.WriteLine("7. Show All Customers!");
            Console.WriteLine("8. Update Customer Info!");
            Console.WriteLine("9. Search For A Customer!");
            Console.WriteLine("10.Remove A Customer!");
            Console.WriteLine();
            Console.WriteLine("To Close Program Press 'x'");
        }
        #endregion

        #region Show Full Menu
        public void ShowFullMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("~~~~");

            foreach (Pizza pizza in pizzaList)
            {
                Console.WriteLine("______________________________________________________________________");
                Console.WriteLine($"No.{pizza.NumberOfPizza} - {pizza.NameOfPizza} - ({pizza.Toppings}) - {pizza.PriceOfPizza} DKK");
            }
        }
        #endregion

        #region Create Pizza
        public void CreatePizza()
        {
            string nameOfPizza;
            double priceOfPizza;
            string toppings;
            int numberOfPizza;

            try
            {
                Console.WriteLine($"CREATE PIZZA");
                Console.WriteLine($"____________");
                Console.WriteLine($"Name Your Pizza:");
                nameOfPizza = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine($"Set Price For Pizza::");
                priceOfPizza = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"Add Your Toppings. Please seperate toppings with ',':");
                toppings = Console.ReadLine();
                Console.WriteLine($"You Have Now Created Your Pizza! Your Pizza Has Been Assigned Number {pizzaList.Count + 1}");
                numberOfPizza = pizzaList.Count + 1;
                Pizza pizza = new Pizza(numberOfPizza, nameOfPizza, priceOfPizza, toppings);
                pizzaList.Add(pizza);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Use Only Numbers When Setting A Price! Press Enter To Start Over");
                Console.ReadKey();
                Console.Clear();
                CreatePizza();
            }

        }
        #endregion

        #region Search For Pizza
        public void SearchForPizza(string searchPhrase)
        { 
            var matchingPizzas = pizzaList.Where(pizza => pizza.NameOfPizza.Contains(searchPhrase)).ToList();
            foreach (Pizza pizza in matchingPizzas)
            {
                Console.WriteLine($"No.{pizza.NumberOfPizza} - {pizza.NameOfPizza} - ({pizza.Toppings}) - {pizza.PriceOfPizza} DKK");
            }
            Console.WriteLine("Didn't Find What You Were Looking For? Return To Menu And Try Again!");
        }
        #endregion

        #region Update Pizza
        public void UpdatePizza(int numberOfPizza)
        { 
            var pizza = pizzaList.FirstOrDefault(pizza => pizza.NumberOfPizza == numberOfPizza);
            try
            {
                if (pizza == null)
                {
                    Console.WriteLine($"Pizza Not Found");
                }
                else
                {
                    Console.WriteLine($"You Have Chosen Pizza No.{pizza.NumberOfPizza}");
                    Console.WriteLine();
                    Console.WriteLine("Enter New Name:");
                    pizza.NameOfPizza = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter New Toppings:");
                    pizza.Toppings = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine($"Enter New Price:");
                    pizza.PriceOfPizza = Convert.ToInt32(Console.ReadLine()); ;
                    Console.WriteLine();
                    Console.WriteLine("Succes! You Pizza Has Been Updated!");
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Use Only Numbers When Setting A Price! Press Enter To Start Over");
                Console.ReadKey();
                Console.Clear();
                UpdatePizza(numberOfPizza);
            }
        }
        #endregion

        #region Remove Pizza
        public void RemovePizza(int numberOfPizza)
        {
            try
            {
                pizzaList.RemoveAt(numberOfPizza - 1);
                Console.WriteLine($"Pizza No.{numberOfPizza} Has Been Removed From The Menu.");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Use Only Numbers When Choosing A Pizza To Remove! Press Enter To Start Over");
                Console.ReadKey();
                Console.Clear();
                RemovePizza(numberOfPizza);
            }
            catch(System.ArgumentOutOfRangeException)
            {
                Console.WriteLine($"No Result - Please Try Again!");
                Console.ReadKey();
                Console.Clear();
                UserMenu();
            }

            #endregion

            #endregion
        }
    }
}


    

