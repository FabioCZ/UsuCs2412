using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace IdleGame
{
    public partial class Form1 : Form
    {
        GameState game = new GameState(1000);
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        double timeElapsed = 0;
        string resourceErrorString = "You don't have enough resources.";
        string resourcePopErrorString = "You don't have enough resources or population capacity.";
        bool isKeyPressed = false;

        public Form1()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(updateTimer);
            timer.Interval = 100;
            timer.Start();
            groupBoxBuyWorkers.Text = "Buy Workers (" + game.workerCost.ToString() + "f)";
            groupBoxHouse.Text = "Buy House (" + game.houseWoodCost + "w, " + game.houseStoneCost + "s)";
            labelClickerUpgradeCost.Text = "Cost: " + game.clickerUpgradeWoodCost + "w, " + game.clickerUpgradeGoldCost + "g";
            labelWorkerUpgradeCost.Text = "Cost: " + game.workerUpgradeFoodCost + "f, " + game.workerUpgradeGoldCost + "g";
            labelHouseUpgradeCost.Text= "Cost: " + game.houseUpgradeWoodCost + "w, " + game.houseUpgradeStoneCost + "s";
            labelTickUpgradeCost.Text = "Cost: " + game.tickerUpgradeCost + " each";

        }

        public void updateTimer(Object myObject, EventArgs myEventArgs)
        {
            updateLabels();
            timeElapsed += 0.1;
            labelTimeElapsed.Text = string.Format("{0:00}:{1:00}:{2:00}", timeElapsed / 3600, (timeElapsed / 60) % 60, timeElapsed % 60);

        }


        //updates all the resource etc. labels
        public void updateLabels()
        {
            tickTimeLabel.Text = ((double)game.tickTimeMilliSeconds / 1000).ToString();
            popCurrentLabel.Text = game.popCurrent.ToString();
            popCapacityLabel.Text = game.popCapacity.ToString();

            fTotalLabel.Text = game.food.getResourceCt();
            wTotalLabel.Text = game.wood.getResourceCt();
            sTotalLabel.Text = game.stone.getResourceCt();
            gTotalLabel.Text = game.gold.getResourceCt();

            fGenLabel.Text = (game.food.workerCt * game.food.productivity).ToString();
            wGenLabel.Text = (game.wood.workerCt * game.wood.productivity).ToString();
            sGenLabel.Text = (game.stone.workerCt * game.stone.productivity).ToString();
            gGenLabel.Text = (game.gold.workerCt * game.gold.productivity).ToString();

            fWorkersLabel.Text = game.food.workerCt.ToString();
            wWorkersLabel.Text = game.wood.workerCt.ToString();
            sWorkersLabel.Text = game.stone.workerCt.ToString();
            gWorkersLabel.Text = game.gold.workerCt.ToString();

            fProdLabel.Text = game.food.productivity.ToString();
            wProdLabel.Text = game.wood.productivity.ToString();
            sProdLabel.Text = game.stone.productivity.ToString();
            gProdLabel.Text = game.gold.productivity.ToString();

        }

        // CLICKER HANDLERS
        private void fClickButton_Click(object sender, EventArgs e)
        {
            game.resourceClick(ResourceType.food);
            fTotalLabel.Text = game.food.resourceCt.ToString();
        }

        private void wClickButton_Click(object sender, EventArgs e)
        {
            game.resourceClick(ResourceType.wood);
            wTotalLabel.Text = game.wood.resourceCt.ToString();            
        }

        private void sClickButton_Click(object sender, EventArgs e)
        {
            game.resourceClick(ResourceType.stone);
            sTotalLabel.Text = game.stone.resourceCt.ToString();           
        }

        private void gClickButton_Click(object sender, EventArgs e)
        {
            game.resourceClick(ResourceType.gold);
            gTotalLabel.Text = game.gold.resourceCt.ToString();
        }

        //WORKER BUYING HANDLERS
        private void fWorkerButton_Click(object sender, EventArgs e)
        {
            if(!game.buyWorker(ResourceType.food)) MessageBox.Show(resourcePopErrorString);
            updateLabels();
        }

        private void wWorkerButton_Click(object sender, EventArgs e)
        {
            if (!game.buyWorker(ResourceType.wood)) MessageBox.Show(resourcePopErrorString);
            updateLabels();
        }

        private void sWorkerButton_Click(object sender, EventArgs e)
        {
            if (!game.buyWorker(ResourceType.stone)) MessageBox.Show(resourcePopErrorString);
            updateLabels();
        }

        private void gWorkerButton_Click(object sender, EventArgs e)
        {
            if (!game.buyWorker(ResourceType.gold)) MessageBox.Show(resourcePopErrorString);
            updateLabels();
        }

        //HOUSE BUYING HANDLER
        private void buyHousesButton_Click(object sender, EventArgs e)
        {
            if (!game.buyHouse()) MessageBox.Show(resourceErrorString);
            updateLabels();
        }
        //UPGRADE HANDLERS
        private void fUpgradeButton_Click(object sender, EventArgs e)
        {
            if (!game.upgradeClicker(ResourceType.food)) MessageBox.Show(resourceErrorString);
            fClickButton.Text = "Food (+" + game.food.clickRate + ")";
        }

        private void wUpgradeButton_Click(object sender, EventArgs e)
        {
            if (!game.upgradeClicker(ResourceType.wood)) MessageBox.Show(resourceErrorString);
            wClickButton.Text = "Wood (+" + game.wood.clickRate + ")";
        }

        private void sUpgradeButton_Click(object sender, EventArgs e)
        {
            if (!game.upgradeClicker(ResourceType.stone)) MessageBox.Show(resourceErrorString);
            sClickButton.Text = "Stone (+" + game.stone.clickRate + ")";
        }

        private void gUpgradeButton_Click(object sender, EventArgs e)
        {
            if (!game.upgradeClicker(ResourceType.gold)) MessageBox.Show(resourceErrorString);
            gClickButton.Text = "Gold (+" + game.gold.clickRate + ")";
        }

        private void fwUpgradeButton_Click(object sender, EventArgs e)
        {
            if (!game.upgradeWorkers(ResourceType.food)) MessageBox.Show(resourceErrorString);
            updateLabels();
        }

        private void wwUpgradeButton_Click(object sender, EventArgs e)
        {
            if (!game.upgradeWorkers(ResourceType.wood)) MessageBox.Show(resourceErrorString);
            updateLabels();
        }

        private void swUpgradeButton_Click(object sender, EventArgs e)
        {
            if (!game.upgradeWorkers(ResourceType.stone)) MessageBox.Show(resourceErrorString);
            updateLabels();
        }

        private void gwUpgradeButton_Click(object sender, EventArgs e)
        {
            if (!game.upgradeWorkers(ResourceType.gold)) MessageBox.Show(resourceErrorString);
            updateLabels();

        }

        private void hUpgradeButton_Click(object sender, EventArgs e)
        {
            if (!game.upgradeHouses()) MessageBox.Show(resourceErrorString);
        }

        private void tickUpgradeButton_Click(object sender, EventArgs e)
        {
            if (!game.upgradeTickTime()) MessageBox.Show(resourceErrorString);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            isKeyPressed = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (isKeyPressed) return;
            isKeyPressed = true;
            switch (e.KeyData)
            {
                case Keys.A:   //food
                    fClickButton_Click(sender, null);
                    break;
                case Keys.S:   //wood
                    wClickButton_Click(sender, null);
                    break;
                case Keys.D:   //stone
                    sClickButton_Click(sender, null);
                    break;
                case Keys.F:   //gold
                    gClickButton_Click(sender, null);
                    break;
            }
        }

        private void guideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Just a fun little clicker game. \n" +
                "Keyboard shortcuts:\n" +
                "a - click food\n" +
                "s - click wood\n" +
                "d - click stone\n" +
                "f - click gold\n");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Fabio Gottlicher, 2014");
        }



    }
}
