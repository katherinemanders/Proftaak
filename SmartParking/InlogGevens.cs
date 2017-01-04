using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParking
{
    class InlogGevens
    {
        // fields
        private string gebruikersnaam;
        private string wachtwoord;

        // properties
        public string Gebruikersnaam
        {
            get
            {
                return gebruikersnaam;
            }

            private set
            {
                gebruikersnaam = value;
            }
        }

        public string Wachtwoord
        {
            get
            {
                return wachtwoord;
            }

            private set
            {
                wachtwoord = value;
            }
        }

        // constructors
        public InlogGevens(string gebruikersnaam, string wachtwoord)
        {
            this.gebruikersnaam = gebruikersnaam;
            this.wachtwoord = wachtwoord;
        }

        //methods

    }
}
