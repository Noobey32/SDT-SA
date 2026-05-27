using System;
using System.Collections.Generic;
using System.Text;

namespace SectionC
{
    internal class inventory
    {
        private string mobileCode;
        private string make;
        private string quantity;

        public inventory(string mobileCode, string make, string quantity)
        {
            this.mobileCode = mobileCode;
            this.make = make;
            this.quantity = quantity;
        }

        public string MobileCode
        {
            get { return mobileCode; }
            set { mobileCode = value; }
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Quantity { 
            get { return quantity; } 
            set { quantity = value; } 
        }
    }
}
