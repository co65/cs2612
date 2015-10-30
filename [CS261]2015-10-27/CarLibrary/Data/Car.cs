using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary.Data
{
    public class Car
    {
        private string name;
        private int year;

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetYear(int value)
        {
            if (value >= 2015)
                this.year = 2015;
            else if (value <= 1945)
                this.year = 1945;
            else
                this.year = value;
        }

        public int GetYear()
        {
            return this.year;
        }

        public int Year
        {
            get { return this.year; }

            set
            {
                if (value >= 2015)
                    this.year = 2015;
                else if (value <= 1945)
                    this.year = 1945;
                else
                    this.year = value;
            }
        }
    }
}