using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingExampleProject {
    class Shoes {
        private String brand;
        private String productName;

        public Shoes(String brand, String productName) {
            this.brand = brand;
            this.productName = productName;
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
