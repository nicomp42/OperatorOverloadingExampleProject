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

        public override String ToString() {
            throw new NotImplementedException("InventoryItem.ToString() not implemented."); 
        }
    }
}
