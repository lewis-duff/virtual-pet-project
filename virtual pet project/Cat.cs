using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_pet_project
{
    internal class Cat
    {
        private int hunger;
        private int thirst;
        private int sleep;

        public int Hunger
        {
            get
            {
                return hunger;
            }
            set
            {
                hunger = value;
            }
        }

        public int Thirst
        {
            get
            {
                return thirst;
            }
            set
            {
                thirst = value;
            }
        }

        public int Sleep
        {
            get
            {
                return sleep;
            }
            set 
            { 
                sleep = value; 
            }  
        }



        public Cat() 
        {
            hunger = 0;
            thirst = 0;
            sleep = 0;
            statDecrease();
        }

        public void statDecrease()
        {
            System.Timers.Timer hungerTimer = new System.Timers.Timer(2000);

            hungerTimer.Elapsed += makeHungry;
            hungerTimer.AutoReset = true;
            hungerTimer.Enabled = true;

            System.Timers.Timer thirstTimer = new System.Timers.Timer(2000);

            thirstTimer.Elapsed += makeThirsty;
            thirstTimer.AutoReset = true;
            thirstTimer.Enabled = true;

            System.Timers.Timer sleepTimer = new System.Timers.Timer(2000);

            sleepTimer.Elapsed += makeTired;
            sleepTimer.AutoReset = true;
            sleepTimer.Enabled = true;
            
        }

        public void makeHungry(object? sender, EventArgs e)
        {
            hunger += 10;
        }

        public void makeThirsty(object? sender, EventArgs e)
        {
            thirst += 10;
        }

        public void makeTired(object? sender, EventArgs e)
        {
            sleep += 10;
        }
    }
}
