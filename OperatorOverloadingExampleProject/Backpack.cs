/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesNamespace;
namespace OperatorOverloadingExampleProject {
    class Backpack {
        private List<object> inventory;         // It's paramaterized, but not very well.
        public Backpack() {
            inventory = new List<object>();
        }
        public void addItem(object item) {
            inventory.Add(item);
        }
        public void PrintInventory() {
            foreach (object myItem in inventory) {
                if (myItem is Shoes) {
                    ((Shoes)myItem).Print();
                }
            }
        }
    }
}
