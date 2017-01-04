using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParking
{
    class Persoon
    {
        // fields
        private string voorNaam;
        private string achterNaam;
        private string kenteken;
        private bool specialeBehoeftes;
        InlogGevens p = new InlogGevens(gebruikersnaam, wachtwoord);

        // propterties
        public string VoorNaam
        {
            get
            {
                return voorNaam;
            }

            private set
            {
                voorNaam = value;
            }
        }

        public string AchterNaam
        {
            get
            {
                return achterNaam;
            }

            private set
            {
                achterNaam = value;
            }
        }

        public string Kenteken
        {
            get
            {
                return kenteken;
            }

            private set
            {
                kenteken = value;
            }
        }

        public bool SpecialeBehoeftes
        {
            get
            {
                return specialeBehoeftes;
            }

            private set
            {
                specialeBehoeftes = value;
            }

            // constructors 

            // methods
        }
    }
}
