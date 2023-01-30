using System;
using System.Collections.Generic;
using System.Text;

namespace Dersde_9_Task
{
    internal class Student
    {
        public string Name;
        private byte _age=15;
        public byte Age { 
            set 
            {
                if (value >= 15)
                {
                    _age = value;
                }
            } 
            get
            {
                return _age;
            }
        }
    }
}
