using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Pizza
    {
        private string size;
        private int cheeseToppings;
        private int pepperoniToppings;
        private int hamToppings;

        public Pizza(string size, int cheeseToppings, int pepperoniToppings, int hamToppings)
        {
            this.size = size;
            this.cheeseToppings = cheeseToppings;
            this.pepperoniToppings = pepperoniToppings;
            this.hamToppings = hamToppings;

        }

        public string Size
        {
            get { return size; }
            set { size = value; }

        }

        public int CheeseToppings
        {
            get { return cheeseToppings; }
            set { cheeseToppings = value; }
        }

        public int PepperoniToppings
        {
            get { return pepperoniToppings; }
            set { pepperoniToppings = value; }
        }

        public int HamToppings
        {
            get { return hamToppings; }
            set { hamToppings = value; }
        }

        public double CalcCost()
        {
            double baseCost = 0;

            switch (size.ToLower())
            {
                case "Small":
                    baseCost = 10;
                    break;
                case "medium":
                    baseCost = 12;
                    break;
                case "Large":
                    baseCost = 14;
                    break;
                default:
                    Console.WriteLine("Invalid size entered");
                    return 0;

            }

            double toppingCost = (cheeseToppings + pepperoniToppings + hamToppings) * 2;

            double totalCost = baseCost + toppingCost;

            return totalCost;
        }

        public string GetDescription()
        {
            return $"Pizza Size: {size}, Cheese Toppings: {cheeseToppings}, pepperoni Toppings: {pepperoniToppings}, Ham Toppings: {hamToppings}";

        }


    }
}
