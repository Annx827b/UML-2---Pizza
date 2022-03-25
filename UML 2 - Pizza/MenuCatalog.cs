using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UML_2_PizzaStore
{
    public class MenuCatalog
    {

        public List<Pizza> pizzaList = new List<Pizza>();
     
        public void Start(Pizza pizza)
        {
            Pizza pizza1 = new Pizza(1, "Hawaii", 85, "Ham, Pineapple, Cheese");
            Pizza pizza2 = new Pizza(2, "Veggie", 80, "Bellpepper, Olives, Mushrooms");
            Pizza pizza3 = new Pizza(3, "House Special", 90, "Kebab, Chili, Cheese");
            
            pizzaList.Add(pizza1);
            pizzaList.Add(pizza2);
            pizzaList.Add(pizza3);
        }

        public void ShowFullMenu()
        {
            foreach (Pizza pizza in pizzaList)
            {
                Console.WriteLine($"{pizza.NameOfPizza} - ({pizza.Toppings}) - {pizza.PriceOfPizza} DKK");
            }
        }

        public void SearchForPizza(string searchPhrase)
        {
            var matchingPizzas = pizzaList.Where(p => p.NameOfPizza.Contains(searchPhrase)).ToList();
            foreach (Pizza pizza in matchingPizzas)
            {
                Console.WriteLine($"{pizza.NameOfPizza} - ({pizza.Toppings}) - {pizza.PriceOfPizza} DKK");
            }
        }

        public void SearchForTopping(string searchPhrase)
        {
            var matchingPizzas = pizzaList.Where(p => p.Toppings.Contains(searchPhrase)).ToList();
            foreach (Pizza pizza in matchingPizzas)
            {
                Console.WriteLine($"{pizza.NameOfPizza} - ({pizza.Toppings}) - {pizza.PriceOfPizza} DKK");
            }
        }
    
    }
}

    

  



        /*List<Pizza> pizzalist = new List<Pizza>();

        Pizza pizza1 = new Pizza("Hawaii", 80);
        Pizza pizza2 = new Pizza("Veggie", 75);
        Pizza pizza3 = new Pizza("House Special", 90);
        Pizza pizza4 = new Pizza("Capricosa", 60);

        MenuCatalog()
        {
            pizzalist.Add(pizza1);
            pizzalist.Add(pizza2);
            pizzalist.Add(pizza3);
            pizzalist.Add(pizza4);
        }

        public void PrintMenu()
        {
            Console.WriteLine(pizzalist);
        }


        /*AuthorList.Add(new Author("Neel Beniwal", 18, "Graphics Development with C#", false, new DateTime(2010, 2, 22)));
        AuthorList.Add(new Author("Praveen Kumar", 28, "Mastering WCF", true, new DateTime(2012, 01, 01)));
        AuthorList.Add(new Author("Mahesh Chand", 35, "Graphics Programming with GDI+", true, new DateTime(2008, 01, 20)));
        AuthorList.Add(new Author("Raj Kumar", 30, "Building Creative Systems", false, new DateTime(2011, 6, 3)));
        */


        #region Instance Fields




        #endregion

        #region Constructor
        #endregion

        #region Properties 
        #endregion

        #region Methods
        #endregion


    

