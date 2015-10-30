using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuyLibrary
{
    public class Guy
    {
        public string Name { get; set; }

        private int cash;

        public int Cash
        {
            get { return this.cash; }
            set
            {
                this.cash = (value < 0) ? 0 : value;
            }
        }

        public int GiveCash(int amount)
        {
            if (amount <= this.Cash)
            {
                this.Cash -= amount;
                return amount;
            }
            else
            {
                return 0;
            }
        }

        public int ReceiveCash(int amount)
        {
            if (amount >= 0)
            {
                this.Cash += amount;
                return amount;
            }
            else
            {
                return 0;
            }
        }
    }
}