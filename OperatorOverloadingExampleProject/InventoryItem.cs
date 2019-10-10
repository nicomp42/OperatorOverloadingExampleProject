/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OperatorOverloadingExampleProject
{
    class InventoryItem
    {
        private String mBrand;
        private String mProductName;
        private int mWeightGrams;
        private double mCost;
        private Uri mUri;

        public Uri uri {
            get {return mUri;}
            set {mUri = value;}
        }
        public String brand {
            get {return mBrand;}
            set {mBrand = value;}
        }


        public override String ToString() {
            throw new NotImplementedException("InventoryItem.ToString() not implemented."); 
        }
    }
}
