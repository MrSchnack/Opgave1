using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave1
{

    class Beer
    {
        private string name;
        private double alcoholamount;
        private double price;

        public int Id { get; set; }
        public string Name { get => name; set
            {
                if (value.Length < 4) throw new ArgumentException("Name has to be longer than 4 characters"); }
            }
        public double Price{ get => price; set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Price cannot be 0");
            }
        }
        public double Alcoholamount { get => alcoholamount; set => alcoholamount = value; }



    }

}
