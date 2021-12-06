using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace TireSoft
{
    [Serializable]
    public class Car : MainFunctions
    {
        private string _brand;
        private string _model;
        private string _coupe;
        private string _tire_size;

        public string Brand {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            } 
        }

        public string Model {
            get
            {
                return _model;
            } 
            set
            {
                _model = value;
            }
        }

        public string Coupe {
            get
            {
                return _coupe;
            }    
            set
            {
                _coupe = value;
            }
        }

        public string TireS {
            get
            {
                return _tire_size;
            }
            set
            {
                _tire_size = value;
            }
        }
        public override string ToString()
        {
            return $"BRAND / {Brand} / MODEL / {Model} / COUPE / {Coupe} / TIRESIZE / {TireS} ; ";
        }
    }
}
