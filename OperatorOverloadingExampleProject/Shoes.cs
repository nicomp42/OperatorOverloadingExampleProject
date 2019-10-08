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
        private String brand;
        private String productName;
        private int weightGrams;
        private double cost;
        private Uri uri;

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
    }
}
