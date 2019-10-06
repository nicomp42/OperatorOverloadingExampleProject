using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatorOverloadingExampleProject;

namespace ShoesNamespace {
    class Shoes {
        private String brand;
        private String productName;
        private int weightGrams;
        private float cost;

        public Shoes(String brand, String productName, int weightGrams, float cost) {
            this.brand = brand;
            this.productName = productName;
            this.weightGrams = weightGrams;
            this.cost = cost;
        }

        public static Backpack operator + (Backpack backpack, Shoes shoes) {
            backpack.addItem(shoes);
            return backpack;
        }
        public void Print() {
            Console.WriteLine("Shoes: " + brand + ", " + productName);
        }
    }
}
