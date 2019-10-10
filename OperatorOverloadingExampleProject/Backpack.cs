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
        private List<InventoryItem> inventoryItems;
        public Backpack() {
            inventoryItems = new List<InventoryItem>();
        }
        public void addItem(object item) {
            inventoryItems.Add(item);
        }
        public void PrintInventory() {
            foreach (object myInventoryItem in inventoryItems) {
                if (myInventoryItem is Shoes) {
                    Console.WriteLine(((Shoes)myInventoryItem).ToString());
                }
            }
        }
    }
}
