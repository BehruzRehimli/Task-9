using System;
using System.Collections.Generic;
using System.Text;

namespace Dersde_9_Task
{
    internal class Car : Vehicle
    {
        private double _fuelCapacity;
        public double FuelCapacity => _fuelCapacity;
        private double _currentFuel;
        public double CurrentFuel => _currentFuel;
        private double _fuelfor1km;
        public double FuelFor1Km => _fuelfor1km;
        public Car(double fuelCap,double fuelFor1km, double mileage = 0, double currentFuel=0) : base(mileage)
        {
            if (fuelCap>0&&fuelCap>=_currentFuel)
            {
                this._fuelCapacity = fuelCap;
            }
            if (fuelFor1km>0)
            {
                _fuelfor1km = fuelFor1km;
            }
            if (currentFuel>=0)
            {
                _currentFuel = currentFuel;
            }
        }
        public void AddFuel(int km)
        {
            if (_currentFuel+km<=_fuelCapacity)
            {
                _currentFuel += km;
            }
        }
        public override void Drive(double km)
        {
            if (km*_fuelfor1km<=_currentFuel)
            {
                base.Drive(km);
                _currentFuel -= km*_fuelfor1km;
            }
        }
    }
}
