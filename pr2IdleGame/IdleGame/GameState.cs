using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace IdleGame
{

    enum ResourceType
    {
        food,
        wood,
        stone,
        gold
    }
    class GameState
    {
        //Timer
        System.Windows.Forms.Timer tickTimer = new System.Windows.Forms.Timer();
        public int tickTimeMilliSeconds;

        //resources
        public ResourceModel food = new ResourceModel();
        public ResourceModel wood = new ResourceModel();
        public ResourceModel stone = new ResourceModel();
        public ResourceModel gold = new ResourceModel();

        //housing
        public int popCapacity;
        public int popCurrent;
        public int houseLevel;
        

        //Costs
        public int workerCost = 10;

        public int houseWoodCost = 10;
        public int houseStoneCost =30;

        public int clickerUpgradeWoodCost = 30;
        public int clickerUpgradeGoldCost = 30;

        public int workerUpgradeFoodCost = 50;
        public int workerUpgradeGoldCost = 50;

        public int houseUpgradeWoodCost = 50;
        public int houseUpgradeStoneCost = 50;

        public int tickerUpgradeCost = 100;

        //other
        int houseIncrementer = 5;
        

        public GameState(int tickTimeMilliSeconds)
        {
            popCapacity = 0;
            popCurrent = 0;
            houseLevel = 1;

            this.tickTimeMilliSeconds = tickTimeMilliSeconds;
            tickTimer.Tick += new EventHandler(updateGameState);
            tickTimer.Interval = tickTimeMilliSeconds;
            tickTimer.Start();
        }

        public void updateGameState(Object myObject, EventArgs myEventArgs)
        {
                food.updateResources();
                wood.updateResources();
                stone.updateResources();
                gold.updateResources();
        }

        public bool upgradeTickTime()
        {
            if (food.resourceCt < tickerUpgradeCost ||
                wood.resourceCt < tickerUpgradeCost ||
                stone.resourceCt < tickerUpgradeCost ||
                gold.resourceCt < tickerUpgradeCost) return false;
            if (tickTimeMilliSeconds == 100) return false;
            else tickTimeMilliSeconds -= 100;
            food.resourceCt -= tickerUpgradeCost;
            wood.resourceCt -= tickerUpgradeCost;
            stone.resourceCt -= tickerUpgradeCost;
            gold.resourceCt -= tickerUpgradeCost;
            return true;
        }

        public void resourceClick(ResourceType type){
             switch(type){
                case ResourceType.food:
                    food.clickHandler();
                    break;
                case ResourceType.wood:
                    wood.clickHandler();
                    break;
                case ResourceType.stone:
                    stone.clickHandler();
                    break;
                case ResourceType.gold:
                    gold.clickHandler();
                    break;
            }
        }

        public bool buyWorker(ResourceType type){
            if(food.resourceCt < workerCost || popCurrent >= popCapacity) return false;
            switch(type){
                case ResourceType.food:
                    food.workerCt++;
                    popCurrent++;
                    break;
                case ResourceType.wood:
                    wood.workerCt++;
                    popCurrent++;
                    break;
                case ResourceType.stone:
                    stone.workerCt++;
                    popCurrent++;
                    break;
                case ResourceType.gold:
                    gold.workerCt++;
                    popCurrent++;
                    break;
            }
            food.resourceCt -= 10;
            return true;
        }

        public bool buyHouse()
        {
            if (wood.resourceCt < houseWoodCost || stone.resourceCt < houseStoneCost) return false;
            wood.resourceCt -= houseWoodCost;
            stone.resourceCt -= houseStoneCost;
            popCapacity += houseLevel * houseIncrementer;
            return true;
        }

        public bool upgradeClicker(ResourceType type)
        {
            if (wood.resourceCt < clickerUpgradeWoodCost || gold.resourceCt < clickerUpgradeGoldCost) return false;
            wood.resourceCt -= clickerUpgradeWoodCost;
            gold.resourceCt -= clickerUpgradeGoldCost;            
            
            switch (type)
            {
                case ResourceType.food:
                    food.increaseClickRate();
                    break;
                case ResourceType.wood:
                    wood.increaseClickRate();
                    break;
                case ResourceType.stone:
                    stone.increaseClickRate();
                    break;
                case ResourceType.gold:
                    gold.increaseClickRate();
                    break;
            }
            return true;
        }

        public bool upgradeWorkers(ResourceType type)
        {
            if (food.resourceCt < workerUpgradeFoodCost || gold.resourceCt < workerUpgradeGoldCost) return false;
            food.resourceCt -= workerUpgradeFoodCost;
            gold.resourceCt -= workerUpgradeGoldCost;

            switch (type)
            {
                case ResourceType.food:
                    food.increaseLProductivity();
                    break;
                case ResourceType.wood:
                    wood.increaseLProductivity();
                    break;
                case ResourceType.stone:
                    stone.increaseLProductivity();
                    break;
                case ResourceType.gold:
                    gold.increaseLProductivity();
                    break;
            }
            return true;
        }

        public bool upgradeHouses()
        {
            if (wood.resourceCt < houseUpgradeWoodCost || stone.resourceCt < houseUpgradeStoneCost) return false;
            wood.resourceCt -= houseUpgradeWoodCost;
            stone.resourceCt -= houseUpgradeStoneCost;
            houseLevel++;
            return true;
        }

    }
}
