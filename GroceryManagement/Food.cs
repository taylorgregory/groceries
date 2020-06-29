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
        public int KilojoulesPHG { get; set; }
        public int ProteinPHG { get; set; }
        public int FatPHG { get; set; }
        public int SatFatPHG { get; set; }
        public string ColesID { get; set; }
        public int ColesPrice { get; set; }
        public string WoolworthsID { get; set; }
        public int WoolworthsPrice { get; set; }
        public Dictionary<string, Array> Properties { get; set; } // quantity, purchaseDate, openDate, useBy, coles/woolworths?

        // constructors
        public Food(string name, int kilojoulesPHG, int proteinPHG, int fatPHG, int satFatPHG, Dictionary<string, Array> properties)
        {
            // this constructor is used by the user when manually inputting a food item for the first time
            this.Name = name;
            this.KilojoulesPHG = kilojoulesPHG;
            this.ProteinPHG = proteinPHG;
            this.FatPHG = fatPHG;
            this.SatFatPHG = satFatPHG;
            this.Properties = properties;
        }

        public Food(string name, Dictionary<string, Array> properties)
        {
            this.Name = name;
            this.Properties = properties;
        }
    }
}
