/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatorOverloadingExampleProject;

namespace ShoesNamespace {
    class Shoes : InventoryItem {

        public Shoes() {}

        public Shoes(String brand, String productName, int weightGrams, double cost, Uri uri) {
            this.brand = brand;
            this.productName = productName;
            this.weightGrams = weightGrams;
            this.cost = cost;
            this.uri = new Uri(uri.ToString());        // Use the copy constructor
        }

        public static Backpack operator + (Backpack backpack, Shoes shoes) {
            backpack.addItem(shoes);
            return backpack;
        }
        public override String ToString() {
            return "Shoes: Brand = " + brand + ", Model = " + productName + ", " + weightGrams + " grams, $" + cost + ", URL = " + uri.ToString();
        }

        public new void AddToBackpack(Backpack backpack) {
            Shoes shoes = new Shoes("Hoka", "One One Clifton 6", 200, 125.95, new Uri("https://www.zappos.com/p/hoka-one-one-clifton-6-black-white/product/9229252/color/151"));
            backpack = backpack + shoes;
        }
    }
}
