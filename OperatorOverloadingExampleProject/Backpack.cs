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
        public void addItem(InventoryItem item) {
            inventoryItems.Add(item);
        }
        public void PrintInventory() {
            foreach (object myInventoryItem in inventoryItems) {
                if (myInventoryItem is Shoes) {
                    Console.WriteLine(((Shoes)myInventoryItem).ToString());
                }
            }
        }
        public InventoryItem Find(InventoryItem target) {
            InventoryItem found = null;

            foreach (InventoryItem inventoryItem in inventoryItems) {
                Type a = target.GetType();
                Type b = inventoryItem.GetType();
                if ((Object.ReferenceEquals(a, b))) {
                    // We have a match 
//                    Console.WriteLine("Found a match ");
                    found = inventoryItem;
                    break;
                }
            }
            return found;
        }
    }
}
