using System;

namespace UML_2_PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            MenuCatalog menuCatalog = new MenuCatalog();
            menuCatalog.PizzaList();
            store.RunApp();
        }
    }
}
