using System;

namespace CSPolymorphism
{
    class ElectricEngine: IEngine
    {
        int _horsePower;
        int _energyStoreMaxSize;
        int _currentEnergyStore;

        public int HorsePower 
        {
            get => _horsePower;  
            set => _horsePower = value;
        }
        public int EnergyStoreMaxSize 
        {
            get => _horsePower;
            set => _horsePower = value;            
        }
        public int CurrentEnergyStore 
        {
            get => _currentEnergyStore;
            set => _currentEnergyStore = value;
        }
        public string? BatteryType {get;set;}
        public ElectricEngine()
        {

        }
        public ElectricEngine(int pHorsePower, int pEnergyStoreMaxSize, string pBatteryType)
        {
            this.HorsePower = pHorsePower;
            EnergyStoreMaxSize = pEnergyStoreMaxSize;
            CurrentEnergyStore = pEnergyStoreMaxSize;
            BatteryType = BatteryType == null ? "Lithium ION" : pBatteryType;

        }
        public void rev()
        {
            Console.WriteLine("SWWIIIISSSSHHH!");
            CurrentEnergyStore -= 1;
        }
        public void rev(int distance)
        {
            for(int i = 0; i<distance; i++)
            {
                rev();
            }
        }
        public void refuel()
        {
            CurrentEnergyStore = EnergyStoreMaxSize;
            Console.WriteLine("Recharged To Full");
        }
        public void refuel(int amount)
        { 
            if(CurrentEnergyStore+amount >= EnergyStoreMaxSize)
            {
                refuel();
            } 
            else
            {
                Console.WriteLine("Recharged {0} Amp Hours", amount);
                CurrentEnergyStore += amount;
            }
        }
    }
}