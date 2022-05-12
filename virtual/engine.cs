using System;

namespace CSPolymorpism
{
    class Engine
    {
        public virtual int HorsePower {get;set;}
        public virtual int EnergyStoreMaxSize {get;set;}
        public virtual int CurrentEnergyStore {get; set;}
        public Engine() 
        {

        }
        public Engine(int pHorsePower, int pEnergyStoreMaxSize)
        {
            this.HorsePower = pHorsePower;
            EnergyStoreMaxSize = pEnergyStoreMaxSize;
            CurrentEnergyStore = EnergyStoreMaxSize;
        }
        public virtual void rev() 
        {

        }
        public virtual void rev(int distance)
        {

        }
        public virtual void refuel()
        {

        }
        public virtual void refuel(int amount)
        {

        }
    }
}