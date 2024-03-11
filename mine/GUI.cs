using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mine
{
    public partial class Mine : Form
    {
        Steuerung steuerung = new Steuerung();
        public Mine()
        {
            InitializeComponent();
            
        }

        private void Mine_Load(object sender, EventArgs e)
        {
            lblUpdater.RunWorkerAsync();
            storageCalc.RunWorkerAsync();
            UIStartup();
            Steuerung.thread.Start();


        }

        private void lblUpdater_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                
                this.Invoke(new MethodInvoker(delegate
                {

                    //lblUpdater updatet die Money, Preise
                    inventory();
                    inventoryCount();
                    inventoryStorage();
                    btnEnable();
                    Shop();
                    gamer();
                    
                }));

            }
            
        }

        private void btn_Mine_Click(object sender, EventArgs e)
        {
            steuerung.Mineing();
            
           
        }

        private void inventory()
        {
            if (steuerung.testfor_Stone() == true)
            {
                if (lbl_Stone.Visible == false)
                {
                    lbl_Stone.Visible = true;
                    lbl_StoneInfo.Visible = true;
                }
            }
            else
            {
                if (lbl_Stone.Visible == true)
                {
                    lbl_Stone.Visible = false;
                    lbl_StoneInfo.Visible = false;
                }

            }

            if (steuerung.testfor_Gold() == true)
            {
                lbl_Gold.Visible = true;
                lbl_GoldInfo.Visible = true;
            }
            else
            {
                lbl_Gold.Visible = false;
                lbl_GoldInfo.Visible = false;
            }
            if (steuerung.testfor_Iron() == true)
            {
                lbl_Iron.Visible = true;
                lbl_IronInfo.Visible = true;
            }
            else
            {
                lbl_Iron.Visible = false;
                lbl_IronInfo.Visible = false;
            }
        }
        private void inventoryCount()
        {
            lbl_Gold.Text = steuerung.getQuantityGold();
            lbl_Stone.Text = steuerung.getQuantityStone();
            lbl_Iron.Text = steuerung.getQuantityIron();
        }
        private void inventoryStorage() 
        {
            
            lbl_Storage.Text = steuerung.StorageToString();
        }

        private void storageCalc_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                steuerung.setPlayerStorage();
            }
            
        }

        private void btn_Sell_Click(object sender, EventArgs e)
        {
            steuerung.Sell();
        }

        
        private void UIStartup()
        {

        }
        private void btnEnable()
        {
            if (Steuerung.cool == true /*&& btn_Sell.Enabled == true */)
            {

                btn_Sell.Enabled = false;
                pb_Sell.Visible = true;
                pb_Sell.Value = Steuerung.time;
            }
            else
            {
                btn_Sell.Enabled = true;
                pb_Sell.Visible = false;
                pb_Sell.Value = 0;
            }
        }
        private void Shop()
        {
            btn_Upgrade1.Text = steuerung.multiPriceToString();
            btn_Upgrade3.Text = steuerung.StoragePriceToString();
            btn_Upgrade2.Text = Convert.ToString(steuerung.sleepPrice);
        }
        private void gamer()
        {
            lbl_Money.Text = steuerung.MoneyToString();
            lbl_Multi.Text = steuerung.multiToString();
        }

        private void btn_Upgrade1_Click(object sender, EventArgs e)
        {
            steuerung.buy_Upgrade1();
        }

        private void btn_Upgrade2_Click(object sender, EventArgs e)
        {
            steuerung.buy_Upgrade2();
        }

        private void btn_Upgrade3_Click(object sender, EventArgs e)
        {
            steuerung.buy_Upgrade3();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            steuerung.Save();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            steuerung.Load();
        }
    }
}
