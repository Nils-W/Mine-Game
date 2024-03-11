using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace mine
{
    internal class Iron : Blocks
    {
        private int storage = 10;
        private int valvue = 5;
        private int quantity = 0;
        private int rare = 25;
        private int maxAmount = 3;
        private string name = "Iron";

        public Iron()
        {
            
        }
        public int getStorage() { return storage; }
        public int getValvue() { return valvue; }
        public int getQuantity() { return quantity; }
        public void addQuantity(int valvue) { quantity += valvue; }
        public void resetQuantity() { quantity = 0; }
        public string getName() { return name; }
        public int getRare() {  return rare; }
        public int getMaxAmount() { return maxAmount; }

        public void setQuantity(int value)
        {
            quantity = value;
        }

        public override string ToString()
        {
            return quantity + "\n";
        }
    }
}
