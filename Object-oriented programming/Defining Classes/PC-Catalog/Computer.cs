using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Catalog
{
    class Computer
    {
        private string name;
        private decimal price;
        private Component motherboard;
        private Component processor;
        private Component graphics;

        public Computer(string name, Component motherboard, Component processor, Component graphics)
        {
            this.Name = name;
            this.Motherboard = motherboard;
            this.Processor = processor;
            this.Graphics = graphics;
        }

        public string Name 
        {
            get { return this.name; }
            set
            {
                Validation.IsStringEmpty(value, "Computer name");
            }
        }

        public Component Motherboard 
        {
            get { return this.motherboard; }
            set
            { this.motherboard = value; }
        }

        public Component Graphics 
        {
            get { return this.graphics; }
            set
            { this.graphics = value; }
        }

        public Component Processor 
        {
            get { return this.processor; }
            set
            { this.processor = value; }
        }
    }
}
