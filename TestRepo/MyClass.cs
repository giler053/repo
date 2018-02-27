using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepo
{
    class MyClass
    {
        public static int Serial_num=0;
        private int num;
        private string name_class;
        public MyClass(string name_class)
        {
            this.num = Serial_num++;
            this.name_class = name_class + "";
        }
        override public string ToString()
        {
            return this.name_class + "\nnumber = " + this.num;
        }
    }
}
