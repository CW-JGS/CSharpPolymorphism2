using System;

namespace CSPolymorphism
{
    class Program 
    {
        static void Main(string[] args)
        {

            InternalCombustionEngine v6LS = new InternalCombustionEngine(600, 60, "Unleaded");
            ElectricEngine telsa = new ElectricEngine(600, 120, "L-ION");
            IEngine mainEngine;
            mainEngine = v6LS;
            mainEngine.rev();
            mainEngine.refuel();
            mainEngine.rev(45);
            mainEngine.refuel(40);
            mainEngine.refuel(40);
            mainEngine = telsa;
            mainEngine.rev();
            mainEngine.refuel();
            mainEngine.rev(45);
            mainEngine.refuel(40);
            mainEngine.refuel(40);

        }   
    }
}