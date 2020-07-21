using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ball
{
    class Size
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        private int diameter;
        public int Diameter
        {
            get { return diameter; }
            set { this.diameter = value; }
        }
        public Size()
        {

        }
        public Size(string name,int diameter)
        {
            this.Name = name;
            this.Diameter = diameter;
        }
    }
}
