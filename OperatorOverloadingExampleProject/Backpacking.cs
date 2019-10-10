using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesNamespace;

namespace OperatorOverloadingExampleProject {
    class Backpacking {

        private String destination;
        private Backpack backpack;
        private Camera camera;
        private PuffyJacket puffyJacket;
        private Shoes shoes;
        private Sleepingbag sleepingbag;
        private Sleepingpad sleepingpad;
        private Stove stove;
        private Tent tent;
        private WaterPurificationSystem waterPurificationSystem;
        private List<InventoryItem> inventoryItems;
        
        public Backpacking() {

        }
        public Backpacking(String destination) {
            InitInventoryItemList();
            int foundItems = 0, missingItems = 0;
            this.destination = destination;
            backpack = new Backpack();
            AddInventoryItemsToPackpack();
            backpack.PrintInventory();

            if (backpack.Find(new BearCannister()) != null) {Console.WriteLine("Found Bear Cannister"); foundItems++;} else {Console.WriteLine("Didn't find Bear Cannister"); missingItems++;}

            if (backpack.Find(new Shoes()) != null) {Console.WriteLine("Found Shoes"); foundItems++;} else {Console.WriteLine("Didn't find shoes"); missingItems++;}

            if (backpack.Find(new TrekkingPoles()) != null) {Console.WriteLine("Found Trekking Poles"); foundItems++;} else {Console.WriteLine("Didn't find Trekking Poles"); missingItems++;}
        }
        private void AddInventoryItemsToPackpack() {
            foreach (InventoryItem inventoryItem in inventoryItems) {
                try {
                    inventoryItem.AddToBackpack(backpack);

//                  Shoes.AddToBackpack(backpack);
                } catch (Exception ex) {
                    Console.WriteLine("Error calling InventoryItem.AddToBackpack(): " + inventoryItem.GetType());
                }
            }
//            try {Shoes.AddToBackpack(backpack);} catch (Exception ex) {}
        }
        private void InitInventoryItemList() {
            inventoryItems = new List<InventoryItem>();
            inventoryItems.Add(new BearCannister());
            inventoryItems.Add(new Camera());
            inventoryItems.Add(new CommunicationDevice());
            inventoryItems.Add(new Shoes());
        }   
    }
}
