using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_1
{
    public class Pizza
    {
        private string _name;
        private int _number;
        private double _price;
        private string _ingredient;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        private double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        
        public string Ingredient
        {
            get { return _ingredient; }
            set { _ingredient = value; }
        }

        

        public Pizza(int number, string name, double price, string ingredient)
        {
            _name = name;
            _number = number;
            _price = price;
            _ingredient = ingredient;
        }

        public override string ToString()
        {
            return $"Number {_number}, Name {_name}, Price {_price}, Ingredient {_ingredient}";
        }

    }
}
