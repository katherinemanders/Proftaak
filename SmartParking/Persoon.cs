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
        private bool specialeBehoeftes;

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
        }

            // constructors 
        public Persoon(string voorNaam, string achterNaam, bool specialeBehoeftes)
        {
            this.voorNaam = voorNaam;
            this.achterNaam = achterNaam;
            this.specialeBehoeftes = specialeBehoeftes;
        }

        // methods

    }
 }
