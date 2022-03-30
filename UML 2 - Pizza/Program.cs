using System;

namespace UML_2_PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuCatalog menuCatalog = new MenuCatalog();
            menuCatalog.PizzaList();
            menuCatalog.RunApp();
        }
    }
}
