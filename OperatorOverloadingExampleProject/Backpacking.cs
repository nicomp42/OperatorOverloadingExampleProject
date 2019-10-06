using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesNamespace;

namespace OperatorOverloadingExampleProject {
    class Backpacking {

        //private List<iInventory> inventory;   This project avoids Interfaces because we have not covered them  yet. 


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
        
        public Backpacking() {

        }
        public Backpacking(String destination) {
            this.destination = destination;
            backpack = new Backpack();
            shoes = new Shoes("Hoka", "One One Clifton 6", 200, 125.95, new Uri("https://www.zappos.com/p/hoka-one-one-clifton-6-black-white/product/9229252/color/151"));
            backpack = backpack + shoes;
            backpack.PrintInventory();
        }


    }
}
