using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace mine
{
    internal class Player
    {
        private int storage = 0;
        private int maxstorage = 50;
        private int StoragePrice = 500;
        private int multi = 1;
        private int multiPrice = 10;
        private int Money = 0;
        
        // TODO 

        public Player()
        {    
        }

        public int getStorage() {  return storage; }
        public int getMaxStorage() { return maxstorage; } 
        public void addMaxStorage()
        {
            maxstorage = maxstorage + 10;
        }
        public int getMulti() { return multi;}
        public int getMoney() { return Money; }
        public void setSave(int mon,int mul,int mulprice,int maxstorage,int storageprice)
        {
            Money = mon;
            multi = mul;
            multiPrice = mulprice;
            this.maxstorage = maxstorage;
            StoragePrice = storageprice;
        }
        public void addMoney(int amount){  Money = Money + (amount * multi); }
        public void removeMoney(int valvue) { Money = Money - valvue; }
        public void setStorage(int valvue) { storage = valvue; }
        public void addMulti() { multi++; }
        public int getMultiPrice() { return multiPrice; }
        public void addMultiPrice()
        
        {
            multiPrice = multiPrice + multi;
        }
        public int getStoragePrice() { return StoragePrice; }
        public  void addStoragePrice()
        {
            StoragePrice = StoragePrice +(5 *maxstorage);
        }
        
    }
}
