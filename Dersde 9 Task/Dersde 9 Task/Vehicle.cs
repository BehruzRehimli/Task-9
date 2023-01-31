using System;
using System.Collections.Generic;
using System.Text;

namespace Dersde_9_Task
{
    internal class Vehicle
    {
        public Vehicle(double km=0)
        {
            _mileAge= km;
        }
        protected double _mileAge;
        public double MillAge {
            get { return _mileAge; }
        }
        public virtual void Drive (double km)
        {
            if (km>=0)
            {
                _mileAge += km;
            }
        }
    }
}
