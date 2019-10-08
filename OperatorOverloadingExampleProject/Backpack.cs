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
        private List<InventoryItem> inventoryItem;
        public Backpack() {
            inventory = new List<object>();
        }
        public void addItem(object item) {
            inventory.Add(item);
        }
        public void PrintInventory() {
            foreach (object myInventoryItem in inventoryItem) {
                if (myInventoryItem is Shoes) {
                    Console.WriteLine(((Shoes)myItem).ToString());
                }
            }
        }
    }
}
