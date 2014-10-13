using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Catalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;

        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Component(string name, decimal price, string details = null) : this(name, price)
        {
            this.Details = details;
        }

        public string Name 
        {
            get { return this.name; }
            set
            {
            }
        }

        public string Details 
        {
            get { return this.details; }
            set
            {
            }
        }

        public decimal Price 
        {
            get { return this.price; }
            set
            {
            }
        }
    }
}
