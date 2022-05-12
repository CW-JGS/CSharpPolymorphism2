using System;

namespace CSPolymorphism
{
    public interface IEngine
    {
        public int HorsePower {get;set;}
        public int EnergyStoreMaxSize {get;set;}
        public int CurrentEnergyStore {get;set;}
        
        public void rev();
        public void rev(int distance);
        public void refuel();
        public void refuel(int amount);
    }
}