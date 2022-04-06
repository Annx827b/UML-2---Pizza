using System;
using System.Collections.Generic;
using System.Text;

namespace UML_2_PizzaStore
{
    public class Pizza 
    {
        #region Instance Fields
        private int _numberOfPizza;
        private string _nameOfPizza;
        private double _priceOfPizza;
        private string _toppings;
        #endregion

        #region Constructor
        public Pizza(int numberOfPizza, string nameOfPizza, double priceOfPizza, string toppings)
        {
            _numberOfPizza = numberOfPizza;
            _nameOfPizza = nameOfPizza;
            _priceOfPizza = priceOfPizza;
            _toppings = toppings;
        }

        #endregion

        #region Properties
        public int NumberOfPizza
        {
            get { return _numberOfPizza; }
            set { _numberOfPizza = value; }
        }

        public string NameOfPizza
        {
            get { return _nameOfPizza; }
            set { _nameOfPizza = value; }
        }

        public double PriceOfPizza
        {
            get { return _priceOfPizza; }
            set { _priceOfPizza = value; }
        }

        public string Toppings
        {
            get { return _toppings; }
            set { _toppings = value; }
        }
        #endregion  

    }
}
