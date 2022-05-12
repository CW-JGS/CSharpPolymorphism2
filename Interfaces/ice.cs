using System;

namespace CSPolymorphism
{
    class InternalCombustionEngine: IEngine
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
        public string? FuelType {get;set;}
        public InternalCombustionEngine()
        {

        }
        public InternalCombustionEngine(int pHorsePower, int pEnergyStoreMaxSize, string pFuelType)
        {
            this.HorsePower = pHorsePower;
            EnergyStoreMaxSize = pEnergyStoreMaxSize;
            CurrentEnergyStore = pEnergyStoreMaxSize;
            FuelType = FuelType == null ? "Unleaded" : pFuelType;

        }
        public void rev()
        {
            Console.WriteLine("VROOOOMMMM!");
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
            Console.WriteLine("Refuelled to full");
        }
        public void refuel(int amount)
        { 
            if(CurrentEnergyStore+amount >= EnergyStoreMaxSize)
            {
                refuel();

            } 
            else
            {
                Console.WriteLine("Refuelled {0} Liters", amount);
                CurrentEnergyStore += amount;
            }

        }


    }
}