namespace mine
{
    partial class Mine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Mine = new System.Windows.Forms.Button();
            this.lblUpdater = new System.ComponentModel.BackgroundWorker();
            this.lbl_MoneyInfo = new System.Windows.Forms.Label();
            this.lbl_MultiInfo = new System.Windows.Forms.Label();
            this.btn_Sell = new System.Windows.Forms.Button();
            this.pnl_Shop = new System.Windows.Forms.Panel();
            this.btn_Upgrade3 = new System.Windows.Forms.Button();
            this.lbl_Upgrade3 = new System.Windows.Forms.Label();
            this.btn_Upgrade2 = new System.Windows.Forms.Button();
            this.lbl_Upgrade2 = new System.Windows.Forms.Label();
            this.btn_Upgrade1 = new System.Windows.Forms.Button();
            this.lbl_PriceInfo = new System.Windows.Forms.Label();
            this.lbl_Upgrade1 = new System.Windows.Forms.Label();
            this.lbl_ShopInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Storage = new System.Windows.Forms.Label();
            this.lbl_StorageInfo = new System.Windows.Forms.Label();
            this.lbl_Gold = new System.Windows.Forms.Label();
            this.lbl_GoldInfo = new System.Windows.Forms.Label();
            this.lbl_Stone = new System.Windows.Forms.Label();
            this.lbl_StoneInfo = new System.Windows.Forms.Label();
            this.lbl_Inventory = new System.Windows.Forms.Label();
            this.lbl_Money = new System.Windows.Forms.Label();
            this.lbl_Multi = new System.Windows.Forms.Label();
            this.storageCalc = new System.ComponentModel.BackgroundWorker();
            this.pb_Sell = new System.Windows.Forms.ProgressBar();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_IronInfo = new System.Windows.Forms.Label();
            this.lbl_Iron = new System.Windows.Forms.Label();
            this.pnl_Shop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Mine
            // 
            this.btn_Mine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Mine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mine.Font = new System.Drawing.Font("Bauhaus 93", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mine.Location = new System.Drawing.Point(13, 416);
            this.btn_Mine.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Mine.Name = "btn_Mine";
            this.btn_Mine.Size = new System.Drawing.Size(288, 71);
            this.btn_Mine.TabIndex = 0;
            this.btn_Mine.Text = "Mine";
            this.btn_Mine.UseVisualStyleBackColor = false;
            this.btn_Mine.Click += new System.EventHandler(this.btn_Mine_Click);
            // 
            // lblUpdater
            // 
            this.lblUpdater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.lblUpdater_DoWork);
            // 
            // lbl_MoneyInfo
            // 
            this.lbl_MoneyInfo.AutoSize = true;
            this.lbl_MoneyInfo.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoneyInfo.Location = new System.Drawing.Point(4, 3);
            this.lbl_MoneyInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MoneyInfo.Name = "lbl_MoneyInfo";
            this.lbl_MoneyInfo.Size = new System.Drawing.Size(92, 28);
            this.lbl_MoneyInfo.TabIndex = 3;
            this.lbl_MoneyInfo.Text = "Money:";
            // 
            // lbl_MultiInfo
            // 
            this.lbl_MultiInfo.AutoSize = true;
            this.lbl_MultiInfo.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MultiInfo.Location = new System.Drawing.Point(4, 31);
            this.lbl_MultiInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MultiInfo.Name = "lbl_MultiInfo";
            this.lbl_MultiInfo.Size = new System.Drawing.Size(159, 28);
            this.lbl_MultiInfo.TabIndex = 5;
            this.lbl_MultiInfo.Text = "Multiplikator:";
            // 
            // btn_Sell
            // 
            this.btn_Sell.BackColor = System.Drawing.Color.White;
            this.btn_Sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sell.Font = new System.Drawing.Font("Bauhaus 93", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sell.Location = new System.Drawing.Point(599, 416);
            this.btn_Sell.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sell.Name = "btn_Sell";
            this.btn_Sell.Size = new System.Drawing.Size(288, 71);
            this.btn_Sell.TabIndex = 7;
            this.btn_Sell.Text = "Sell";
            this.btn_Sell.UseVisualStyleBackColor = false;
            this.btn_Sell.Click += new System.EventHandler(this.btn_Sell_Click);
            // 
            // pnl_Shop
            // 
            this.pnl_Shop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_Shop.Controls.Add(this.btn_Upgrade3);
            this.pnl_Shop.Controls.Add(this.lbl_Upgrade3);
            this.pnl_Shop.Controls.Add(this.btn_Upgrade2);
            this.pnl_Shop.Controls.Add(this.lbl_Upgrade2);
            this.pnl_Shop.Controls.Add(this.btn_Upgrade1);
            this.pnl_Shop.Controls.Add(this.lbl_PriceInfo);
            this.pnl_Shop.Controls.Add(this.lbl_Upgrade1);
            this.pnl_Shop.Controls.Add(this.lbl_ShopInfo);
            this.pnl_Shop.Location = new System.Drawing.Point(599, 12);
            this.pnl_Shop.Name = "pnl_Shop";
            this.pnl_Shop.Size = new System.Drawing.Size(288, 385);
            this.pnl_Shop.TabIndex = 8;
            // 
            // btn_Upgrade3
            // 
            this.btn_Upgrade3.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Upgrade3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Upgrade3.Font = new System.Drawing.Font("Bauhaus 93", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upgrade3.Location = new System.Drawing.Point(162, 89);
            this.btn_Upgrade3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Upgrade3.Name = "btn_Upgrade3";
            this.btn_Upgrade3.Size = new System.Drawing.Size(122, 31);
            this.btn_Upgrade3.TabIndex = 19;
            this.btn_Upgrade3.Text = "Sell";
            this.btn_Upgrade3.UseVisualStyleBackColor = false;
            this.btn_Upgrade3.Click += new System.EventHandler(this.btn_Upgrade3_Click);
            // 
            // lbl_Upgrade3
            // 
            this.lbl_Upgrade3.AutoSize = true;
            this.lbl_Upgrade3.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Upgrade3.Location = new System.Drawing.Point(4, 92);
            this.lbl_Upgrade3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Upgrade3.Name = "lbl_Upgrade3";
            this.lbl_Upgrade3.Size = new System.Drawing.Size(92, 28);
            this.lbl_Upgrade3.TabIndex = 18;
            this.lbl_Upgrade3.Text = "Storage";
            // 
            // btn_Upgrade2
            // 
            this.btn_Upgrade2.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Upgrade2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Upgrade2.Font = new System.Drawing.Font("Bauhaus 93", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upgrade2.Location = new System.Drawing.Point(162, 128);
            this.btn_Upgrade2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Upgrade2.Name = "btn_Upgrade2";
            this.btn_Upgrade2.Size = new System.Drawing.Size(122, 31);
            this.btn_Upgrade2.TabIndex = 17;
            this.btn_Upgrade2.Text = "Sell";
            this.btn_Upgrade2.UseVisualStyleBackColor = false;
            this.btn_Upgrade2.Click += new System.EventHandler(this.btn_Upgrade2_Click);
            // 
            // lbl_Upgrade2
            // 
            this.lbl_Upgrade2.AutoSize = true;
            this.lbl_Upgrade2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Upgrade2.Location = new System.Drawing.Point(4, 131);
            this.lbl_Upgrade2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Upgrade2.Name = "lbl_Upgrade2";
            this.lbl_Upgrade2.Size = new System.Drawing.Size(143, 28);
            this.lbl_Upgrade2.TabIndex = 16;
            this.lbl_Upgrade2.Text = "Verkaufszeit";
            // 
            // btn_Upgrade1
            // 
            this.btn_Upgrade1.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Upgrade1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Upgrade1.Font = new System.Drawing.Font("Bauhaus 93", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upgrade1.Location = new System.Drawing.Point(162, 50);
            this.btn_Upgrade1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Upgrade1.Name = "btn_Upgrade1";
            this.btn_Upgrade1.Size = new System.Drawing.Size(122, 31);
            this.btn_Upgrade1.TabIndex = 14;
            this.btn_Upgrade1.Text = "Sell";
            this.btn_Upgrade1.UseVisualStyleBackColor = false;
            this.btn_Upgrade1.Click += new System.EventHandler(this.btn_Upgrade1_Click);
            // 
            // lbl_PriceInfo
            // 
            this.lbl_PriceInfo.AutoSize = true;
            this.lbl_PriceInfo.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PriceInfo.Location = new System.Drawing.Point(213, 0);
            this.lbl_PriceInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PriceInfo.Name = "lbl_PriceInfo";
            this.lbl_PriceInfo.Size = new System.Drawing.Size(75, 28);
            this.lbl_PriceInfo.TabIndex = 15;
            this.lbl_PriceInfo.Text = "Prices";
            // 
            // lbl_Upgrade1
            // 
            this.lbl_Upgrade1.AutoSize = true;
            this.lbl_Upgrade1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Upgrade1.Location = new System.Drawing.Point(4, 53);
            this.lbl_Upgrade1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Upgrade1.Name = "lbl_Upgrade1";
            this.lbl_Upgrade1.Size = new System.Drawing.Size(150, 28);
            this.lbl_Upgrade1.TabIndex = 14;
            this.lbl_Upgrade1.Text = "Multiplikator";
            // 
            // lbl_ShopInfo
            // 
            this.lbl_ShopInfo.AutoSize = true;
            this.lbl_ShopInfo.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShopInfo.Location = new System.Drawing.Point(4, 0);
            this.lbl_ShopInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ShopInfo.Name = "lbl_ShopInfo";
            this.lbl_ShopInfo.Size = new System.Drawing.Size(68, 28);
            this.lbl_ShopInfo.TabIndex = 14;
            this.lbl_ShopInfo.Text = "SHOP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lbl_Iron);
            this.panel1.Controls.Add(this.lbl_IronInfo);
            this.panel1.Controls.Add(this.lbl_Storage);
            this.panel1.Controls.Add(this.lbl_StorageInfo);
            this.panel1.Controls.Add(this.lbl_Gold);
            this.panel1.Controls.Add(this.lbl_GoldInfo);
            this.panel1.Controls.Add(this.lbl_Stone);
            this.panel1.Controls.Add(this.lbl_StoneInfo);
            this.panel1.Controls.Add(this.lbl_Inventory);
            this.panel1.Location = new System.Drawing.Point(13, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 233);
            this.panel1.TabIndex = 9;
            // 
            // lbl_Storage
            // 
            this.lbl_Storage.AutoSize = true;
            this.lbl_Storage.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Storage.Location = new System.Drawing.Point(160, 205);
            this.lbl_Storage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Storage.Name = "lbl_Storage";
            this.lbl_Storage.Size = new System.Drawing.Size(62, 28);
            this.lbl_Storage.TabIndex = 16;
            this.lbl_Storage.Text = "0/50";
            // 
            // lbl_StorageInfo
            // 
            this.lbl_StorageInfo.AutoSize = true;
            this.lbl_StorageInfo.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StorageInfo.Location = new System.Drawing.Point(4, 205);
            this.lbl_StorageInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StorageInfo.Name = "lbl_StorageInfo";
            this.lbl_StorageInfo.Size = new System.Drawing.Size(101, 28);
            this.lbl_StorageInfo.TabIndex = 15;
            this.lbl_StorageInfo.Text = "Storage:";
            // 
            // lbl_Gold
            // 
            this.lbl_Gold.AutoSize = true;
            this.lbl_Gold.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gold.Location = new System.Drawing.Point(160, 110);
            this.lbl_Gold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Gold.Name = "lbl_Gold";
            this.lbl_Gold.Size = new System.Drawing.Size(26, 28);
            this.lbl_Gold.TabIndex = 14;
            this.lbl_Gold.Text = "0";
            // 
            // lbl_GoldInfo
            // 
            this.lbl_GoldInfo.AutoSize = true;
            this.lbl_GoldInfo.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GoldInfo.Location = new System.Drawing.Point(4, 110);
            this.lbl_GoldInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GoldInfo.Name = "lbl_GoldInfo";
            this.lbl_GoldInfo.Size = new System.Drawing.Size(61, 28);
            this.lbl_GoldInfo.TabIndex = 13;
            this.lbl_GoldInfo.Text = "Gold";
            // 
            // lbl_Stone
            // 
            this.lbl_Stone.AutoSize = true;
            this.lbl_Stone.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stone.Location = new System.Drawing.Point(160, 54);
            this.lbl_Stone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Stone.Name = "lbl_Stone";
            this.lbl_Stone.Size = new System.Drawing.Size(26, 28);
            this.lbl_Stone.TabIndex = 12;
            this.lbl_Stone.Text = "0";
            // 
            // lbl_StoneInfo
            // 
            this.lbl_StoneInfo.AutoSize = true;
            this.lbl_StoneInfo.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StoneInfo.Location = new System.Drawing.Point(4, 54);
            this.lbl_StoneInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StoneInfo.Name = "lbl_StoneInfo";
            this.lbl_StoneInfo.Size = new System.Drawing.Size(69, 28);
            this.lbl_StoneInfo.TabIndex = 11;
            this.lbl_StoneInfo.Text = "Stone";
            // 
            // lbl_Inventory
            // 
            this.lbl_Inventory.AutoSize = true;
            this.lbl_Inventory.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inventory.Location = new System.Drawing.Point(4, 0);
            this.lbl_Inventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Inventory.Name = "lbl_Inventory";
            this.lbl_Inventory.Size = new System.Drawing.Size(118, 28);
            this.lbl_Inventory.TabIndex = 10;
            this.lbl_Inventory.Text = "Inverntory";
            // 
            // lbl_Money
            // 
            this.lbl_Money.AutoSize = true;
            this.lbl_Money.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Money.Location = new System.Drawing.Point(160, 3);
            this.lbl_Money.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Money.Name = "lbl_Money";
            this.lbl_Money.Size = new System.Drawing.Size(26, 28);
            this.lbl_Money.TabIndex = 11;
            this.lbl_Money.Text = "0";
            // 
            // lbl_Multi
            // 
            this.lbl_Multi.AutoSize = true;
            this.lbl_Multi.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Multi.Location = new System.Drawing.Point(160, 31);
            this.lbl_Multi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Multi.Name = "lbl_Multi";
            this.lbl_Multi.Size = new System.Drawing.Size(26, 28);
            this.lbl_Multi.TabIndex = 12;
            this.lbl_Multi.Text = "1";
            // 
            // storageCalc
            // 
            this.storageCalc.DoWork += new System.ComponentModel.DoWorkEventHandler(this.storageCalc_DoWork);
            // 
            // pb_Sell
            // 
            this.pb_Sell.ForeColor = System.Drawing.Color.Silver;
            this.pb_Sell.Location = new System.Drawing.Point(599, 403);
            this.pb_Sell.MarqueeAnimationSpeed = 0;
            this.pb_Sell.Maximum = 10;
            this.pb_Sell.Name = "pb_Sell";
            this.pb_Sell.Size = new System.Drawing.Size(288, 10);
            this.pb_Sell.Step = 1;
            this.pb_Sell.TabIndex = 14;
            this.pb_Sell.Visible = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Bauhaus 93", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(309, 416);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(122, 71);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Font = new System.Drawing.Font("Bauhaus 93", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(439, 416);
            this.btn_load.Margin = new System.Windows.Forms.Padding(4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(152, 71);
            this.btn_load.TabIndex = 16;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lbl_Money);
            this.panel2.Controls.Add(this.lbl_MoneyInfo);
            this.panel2.Controls.Add(this.lbl_Multi);
            this.panel2.Controls.Add(this.lbl_MultiInfo);
            this.panel2.Location = new System.Drawing.Point(13, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 140);
            this.panel2.TabIndex = 17;
            // 
            // lbl_IronInfo
            // 
            this.lbl_IronInfo.AutoSize = true;
            this.lbl_IronInfo.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IronInfo.Location = new System.Drawing.Point(4, 82);
            this.lbl_IronInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IronInfo.Name = "lbl_IronInfo";
            this.lbl_IronInfo.Size = new System.Drawing.Size(54, 28);
            this.lbl_IronInfo.TabIndex = 17;
            this.lbl_IronInfo.Text = "Iron";
            // 
            // lbl_Iron
            // 
            this.lbl_Iron.AutoSize = true;
            this.lbl_Iron.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Iron.Location = new System.Drawing.Point(160, 82);
            this.lbl_Iron.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Iron.Name = "lbl_Iron";
            this.lbl_Iron.Size = new System.Drawing.Size(26, 28);
            this.lbl_Iron.TabIndex = 18;
            this.lbl_Iron.Text = "0";
            // 
            // Mine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(898, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pb_Sell);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Shop);
            this.Controls.Add(this.btn_Sell);
            this.Controls.Add(this.btn_Mine);
            this.Font = new System.Drawing.Font("Bauhaus 93", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mine";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Mine idle";
            this.Load += new System.EventHandler(this.Mine_Load);
            this.pnl_Shop.ResumeLayout(false);
            this.pnl_Shop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Mine;
        private System.ComponentModel.BackgroundWorker lblUpdater;
        private System.Windows.Forms.Label lbl_MoneyInfo;
        private System.Windows.Forms.Label lbl_MultiInfo;
        private System.Windows.Forms.Button btn_Sell;
        private System.Windows.Forms.Panel pnl_Shop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Inventory;
        private System.Windows.Forms.Label lbl_ShopInfo;
        private System.Windows.Forms.Label lbl_Money;
        private System.Windows.Forms.Label lbl_Multi;
        private System.Windows.Forms.Label lbl_PriceInfo;
        private System.Windows.Forms.Label lbl_Upgrade1;
        private System.Windows.Forms.Button btn_Upgrade1;
        private System.Windows.Forms.Label lbl_Stone;
        private System.Windows.Forms.Label lbl_StoneInfo;
        private System.Windows.Forms.Label lbl_GoldInfo;
        private System.Windows.Forms.Label lbl_Gold;
        private System.Windows.Forms.Label lbl_Storage;
        private System.Windows.Forms.Label lbl_StorageInfo;
        private System.ComponentModel.BackgroundWorker storageCalc;
        private System.Windows.Forms.ProgressBar pb_Sell;
        private System.Windows.Forms.Button btn_Upgrade2;
        private System.Windows.Forms.Label lbl_Upgrade2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Upgrade3;
        private System.Windows.Forms.Label lbl_Upgrade3;
        private System.Windows.Forms.Label lbl_Iron;
        private System.Windows.Forms.Label lbl_IronInfo;
    }
}

