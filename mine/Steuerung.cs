using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mine
{
    internal class Steuerung
    {
        private static readonly string PathPlayerData = @"Save\Player.txt";
        private static readonly string PathBlocksData = @"Save\Blocks.txt";
        private static readonly string PathUpgradeData = @"Save\Upgrades.txt";
        public static bool cool = false;
        public static Thread thread = new Thread(new ThreadStart(timer));
        private static int sleepcooldown = 10000;
        public int sleepPrice = 1000;
        public int sleeper = 1;
        public static int time = 0;
        Player player = new Player();
        Random rand = new Random();
        Stone Stone = new Stone();
        Gold Gold = new Gold();
        Iron Iron = new Iron();
        public void Mineing()
        {
            int random = rand.Next(0,100);
            int storageAvailable = 0;
            storageAvailable = player.getMaxStorage() - player.getStorage();
            if (storageAvailable > Stone.getStorage() && random <= Stone.getRare())
            {
                if (storageAvailable > Gold.getStorage() && random <= Gold.getRare())
                {
                    if (storageAvailable > Iron.getStorage() && random <= Iron.getRare())
                    {
                        int temp = rand.Next(0, Iron.getMaxAmount());
                        Iron.addQuantity(temp);
                    }
                    else
                    {
                        int temp = rand.Next(0, Gold.getMaxAmount());
                        Gold.addQuantity(temp);
                    }
                }
                else
                {
                    int temp = rand.Next(0, Stone.getMaxAmount());
                    Stone.addQuantity(temp);
                }
            }
            else
            {

            }
        }
        public void Sell()
        {
            if (player.getStorage() > 0)
            {
                //Add money and reset Inventory
                player.addMoney((Stone.getQuantity() * Stone.getValvue()) + (Gold.getQuantity() * Gold.getValvue()) + (Iron.getQuantity() * Iron.getValvue()));
                Gold.resetQuantity();
                Stone.resetQuantity();
                Iron.resetQuantity();
                //Thread bool start for Progressbar timer
                cool = true;
            }  
        }
        // Testfor
        public bool testfor_Stone()
        {
            if (Stone.getQuantity() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool testfor_Gold()
        {
            if (Gold.getQuantity() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool testfor_Iron()
        {
            if (Iron.getQuantity() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //get set Methodes and Funktions
        public string getQuantityStone()
        {
            return Convert.ToString(Stone.getQuantity());
        }
        public string getQuantityGold()
        {
            
            return Convert.ToString(Gold.getQuantity());
        }
        public string getQuantityIron()
        {

            return Convert.ToString(Iron.getQuantity());
        }
        public void setPlayerStorage()
        {
            int storageTaken = 0;
            storageTaken = storageTaken + Gold.getQuantity()*Gold.getStorage();
            storageTaken = storageTaken + Stone.getQuantity()*Stone.getStorage();
            storageTaken = storageTaken + Iron.getQuantity() * Iron.getStorage();
            player.setStorage(storageTaken);
        }
        public string StorageToString()
        {
            return player.getStorage()+"/"+player.getMaxStorage();
        }
        private static void timer()
        {
            while (true)
            { 
                if (Steuerung.cool == true)
                {
                    for (int i = 0;i < 10; i++)
                    {
                        Steuerung.time = i;
                        Thread.Sleep(Steuerung.sleepcooldown / 10);
                    }
                    
                    Steuerung.cool = false;
                }   
            }
        }
        public string multiPriceToString()
        {
            return Convert.ToString(player.getMultiPrice());
        }
        public string multiToString()
        {
            return Convert.ToString(player.getMulti());
        }
        public string StoragePriceToString()
        {
            return Convert.ToString(player.getStoragePrice());
        }
        public string MoneyToString()
        {
            return Convert.ToString(player.getMoney());
        }

        // Upgrades Buy
        public void buy_Upgrade1()
        {
            if (player.getMoney() >= player.getMultiPrice())
            {
                player.addMulti();
                player.removeMoney(player.getMultiPrice());
                player.addMultiPrice();
            }
        }
        public void buy_Upgrade2()
        {
            if (player.getMoney() >= sleepPrice && sleeper < 39)
            {
                sleeper++;
                sleepcooldown -= 250;
                player.removeMoney(sleepPrice);
                sleepPrice = sleepPrice * sleeper;

            }
        }
        public void buy_Upgrade3()
        {
            if (player.getMoney()>= player.getStoragePrice())
            {
                player.addMaxStorage();
                player.removeMoney(player.getStoragePrice());
                player.addStoragePrice();
            }
        }

        // Save and Load
        public void Save()
        {
            if (Directory.Exists(@"save") == false)
            {
                Directory.CreateDirectory(@"save");
            }
            StreamWriter sr_Player = new StreamWriter(PathPlayerData);
            StreamWriter sr_Blocks = new StreamWriter(PathBlocksData);
            StreamWriter sr_Upgrade = new StreamWriter(PathUpgradeData);

            // Player kinda
            sr_Player.WriteLine(player.getMoney());
            sr_Player.Close();
            // Upgrades
            sr_Upgrade.WriteLine(player.getMulti());
            sr_Upgrade.WriteLine(player.getMultiPrice());
            sr_Upgrade.WriteLine(player.getMaxStorage());
            sr_Upgrade.WriteLine(player.getStoragePrice());
            sr_Upgrade.WriteLine(sleeper);
            sr_Upgrade.WriteLine(sleepPrice);
            sr_Upgrade.WriteLine(sleepcooldown);
            sr_Upgrade.Close();

            //Blocks
            sr_Blocks.Write(Stone.ToString());
            sr_Blocks.Write(Gold.ToString());
            sr_Blocks.Close();
        }
        public void Load()
        {
            StreamReader sr_Player = new StreamReader(PathPlayerData);
            StreamReader sr_Blocks = new StreamReader(PathBlocksData);
            StreamReader sr_Upgrade = new StreamReader(PathUpgradeData);

            //Load Player shit
            int Money = Convert.ToInt32(sr_Player.ReadLine());
            sr_Player.Close();

            //Upgrades
            int Multi = Convert.ToInt32(sr_Upgrade.ReadLine());
            int MultiPrice = Convert.ToInt32(sr_Upgrade.ReadLine());
            int MaxStorage = Convert.ToInt32(sr_Upgrade.ReadLine());
            int MaxStoragePrice = Convert.ToInt32(sr_Upgrade.ReadLine());
            sleeper = Convert.ToInt32(sr_Upgrade.ReadLine());
            sleepPrice = Convert.ToInt32(sr_Upgrade.ReadLine());
            sleepcooldown = Convert.ToInt32(sr_Upgrade.ReadLine());
            sr_Upgrade.Close();

            //Blocks
            Stone.setQuantity(Convert.ToInt32(sr_Blocks.ReadLine()));
            Gold.setQuantity(Convert.ToInt32(sr_Blocks.ReadLine()));
            sr_Blocks.Close();

            player.setSave(Money, Multi,MultiPrice,MaxStorage,MaxStoragePrice);

        }
    }
}
