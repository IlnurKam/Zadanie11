using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    
    struct Equation
    {
        private double _coefK;

        public double CoefK
        {
            get
            {
                return _coefK;
            }
            set
            {
                if (value != 0)
                {
                    _coefK = value;
                }
                else
                {
                    Console.WriteLine("k не может быть равен 0");
                }
            }
        }
        public double CoefB { get; set; }
        public Equation(double CoefK, double CoefB)
        {
            this._coefK = CoefK;
            this.CoefB = CoefB;
        }
        public void Solution()
        {
            Console.WriteLine("Х={0:f2}", (-CoefB) / CoefK);
        }
    }
}
