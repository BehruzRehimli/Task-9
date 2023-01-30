using System;
using System.Collections.Generic;
using System.Text;

namespace _2ci_Task_uchun
{
    public class Drink:Product
    {
        private byte _alcoholPercent=0;
        public byte AlcoholPercent { set { if (value >= 0 && value <= 100) { _alcoholPercent = value; } } get { return _alcoholPercent; } }
    }
}
