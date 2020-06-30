using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace GroceryManagement
{
    public class Food
    {
        // initialising and getters + setters
        public string Name { get; set; }
        public double KilojoulesPHG { get; set; }
        public double ProteinPHG { get; set; }
        public double FatPHG { get; set; }
        public double SatFatPHG { get; set; }
        public string ColesID { get; set; }
        public double ColesPrice { get; set; }
        public string WoolworthsID { get; set; }
        public double WoolworthsPrice { get; set; }
        public Dictionary<string, ArrayList> Properties { get; set; } // quantity, purchaseDate, openDate, useBy, coles/woolworths?

        // constructors
        public Food(string name, double kilojoulesPHG, double proteinPHG, double fatPHG, double satFatPHG, Dictionary<string, ArrayList> properties)
        {
            // this constructor is used by the user when manually inputting a food item for the first time
            this.Name = name;
            this.KilojoulesPHG = kilojoulesPHG;
            this.ProteinPHG = proteinPHG;
            this.FatPHG = fatPHG;
            this.SatFatPHG = satFatPHG;
            this.Properties = properties;
        }

        public Food(string name, Dictionary<string, ArrayList> properties)
        {
            this.Name = name;
            this.Properties = properties;
        }
    }
}
