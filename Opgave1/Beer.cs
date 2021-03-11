using System;

namespace Opgave1
{

    public class Beer
    {
        private string _name;
        private double _abv;
        private double _price;

        public int Id { get; set; }
        public string Name
        {
            get => _name; set
            {
                if (value.Length < 4) throw new ArgumentException("Name has to be longer than 4 characters"); _name = value;
            }
        }
        public double Price
        {
            get => _price; set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("Price cannot be 0"); _price = value;
            }
        }

        public double Abv
        {
            get { return _abv; }
            set
            {
                if (value <= 0 || value >= 100)
                    throw new ArgumentOutOfRangeException("Abv can't be 0 or under and/or 100 or over"); _abv = value;
            }

        }
        public Beer(int id, string name, double price, double abv)
        {
            Id = id;
            Name = name;
            Price = price;
            Abv = abv;

        }


    }

}
