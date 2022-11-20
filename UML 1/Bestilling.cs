using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_1
{
    public class Bestilling
    {
        private static int _ordreCounter = 0;
        private int _ordreID;

        private Pizza _pizza;
        public Pizza Pizza 
        {
            get { return _pizza; }
            set { _pizza = value; }
        }
        private Kunde _kunde;
        public Kunde Kunde
        {
            get { return _kunde; }
            set { _kunde = value; }
        }

        public DateTime EndDate { get; private set; }

        public Bestilling(Pizza pizza, Kunde kunde)
        {
            EndDate = DateTime.Now;
            _ordreCounter++;
            _ordreID = _ordreCounter;
            _kunde = kunde;
            _pizza = pizza;
        }
        public override string ToString()
        {
            return $"Kunde {_kunde.ToString()}, Pizza {_pizza.ToString()}, Date/Time: {EndDate.ToString("G")}";
        }
        //{_kunde.Name} refere til kunden, og printer kun navnet.
        //{_kunde.ToString()} med paranteser fordi det er en metode, printer al information of Kunden.
        // Samme med Pizza () v. ToString metode, -() v. .Name, .Price etc.
    }
}
