using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParking
{
    class Parkeervak
    {
        // fields
        private bool beschikbaarheid;
        private string locatie;

        // properties
        public bool Beschikbaarheid
        {
            get
            {
                return beschikbaarheid;
            }

            private set
            {
                beschikbaarheid = value;
            }
        }

        public string Locatie
        {
            get
            {
                return locatie;
            }

            private set
            {
                locatie = value;
            }
        }

        // constructors
        public Parkeervak(bool beschikbaarheid, string locatie)
        {
            this.beschikbaarheid = beschikbaarheid;
            this.locatie = locatie;
        }
    }
}
