using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareProperties
{
    //public class Square
    //{
    //    public double Side { get; set; }

    //    public double Area
    //    {
    //        get
    //        {
    //            return Side * Side;
    //        }
    //        set
    //        {
    //            Side = Math.Sqrt(value);
    //        }
    //    }

    //    //public double GetArea()
    //    //{
    //    //    return Side * Side;
    //    //}

    //    //public void SetArea(double value)
    //    //{
    //    //    Side = Math.Sqrt(value);
    //    //}
    //}

    public class Square
    {
        public double Side
        {
            get
            {
                return Math.Sqrt(Area);
            }
            set
            {
                Area = value*value;
            }
        }

        public double Area { get; set; }
        
    }
}

