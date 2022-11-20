using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_1
{
    public class Kunde
    {
        private string _name;
        private int _tlf;
        private string _adresse;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Tlf
        { 
            get { return _tlf; } 
            set { _tlf = value; } 
        }
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public Kunde(string name, int tlf, string adresse)
        {
            _name = name;
            _tlf = tlf;
            _adresse = adresse;
        }
        public override string ToString()
        {
            return $"Name {_name}, " +
                   $"Telefon nr. {_tlf}, " +
                   $"Adresse {_adresse}";
        }
    }

}
