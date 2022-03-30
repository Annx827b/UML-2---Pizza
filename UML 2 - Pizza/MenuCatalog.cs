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

        #region Run App
        

   
        #endregion

        #region UserMenu
        public void UserMenu()
        {
            Console.Clear();
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
        #endregion

        #region Search For Pizza By Name
        public void SearchForPizza(string searchPhrase)
        {
            var matchingPizzas = pizzaList.Where(pizza => pizza.NameOfPizza.Contains(searchPhrase)).ToList();
            foreach (Pizza pizza in matchingPizzas)
            {
                Console.WriteLine($"No.{pizza.NumberOfPizza} - {pizza.NameOfPizza} - ({pizza.Toppings}) - {pizza.PriceOfPizza} DKK");
            }
        }
        #endregion

        #region Search For Pizza By Number
        public void SearchForPizzaNumber(int numberOfPizza)
        {
            var pizza = pizzaList.FirstOrDefault(pizza => pizza.NumberOfPizza == numberOfPizza);
            if (pizza == null)
            {
                Console.WriteLine($"Pizza Not Found");
            }
            else
            {
                Console.WriteLine($"No.{pizza.NumberOfPizza} - {pizza.NameOfPizza} - ({pizza.Toppings}) - {pizza.PriceOfPizza} DKK");
            }
        }

        /*public void VisPizza(int nummer)
        {
            var pizza = pizzaer.FirstOrDefault(p => p._nummer == nummer);
            if (pizza == null)
            {
                Console.WriteLine("Pizza ikke fundet");
            }
            else
            {
                Console.WriteLine();
                VisPizzaDetaljer(pizza);
            }
        }
        */

        #endregion

        #endregion
    }
}


    

