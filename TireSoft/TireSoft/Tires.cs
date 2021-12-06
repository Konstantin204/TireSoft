using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace TireSoft
{
    public class Tires : MainFunctions

    {

        private string _tire_brand;
        private string _tire_size;
        private string _tire_load_capacity;
        private string _tire_price;

        public string Brand 
        {
            get
            {
                return _tire_brand;
            }
            set
            {
                _tire_brand = value;
            }
        }

        public string Size
        {
            get
            {
                return _tire_size;
            }
            set
            {
                _tire_size = value;
            }
        }

        public string Load_C
        {
            get
            {
                return _tire_load_capacity;
            }
            set
            {
                _tire_load_capacity = value;
            }
        }

        public string Price
        {
            get
            {
                return _tire_price;
            }
            set
            {
                _tire_price = value;
            }
        }
        public override string ToString()
        {
            return $"BRAND / {Brand} / SIZE / {Size} / CAPACITY / {Load_C} / PRICE / {Price} ; ";
        }

    }
}
