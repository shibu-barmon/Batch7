using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10
{
    public class Vehicle
    {
        public string VehilcleName { set; get; }
        public string Reg_No { set; get; }
        public double max;
        public double min;
        public double avg;

        List<double> Speed = new List<double> { };

        public void AddSpeed(double speed)
        {
            Speed.Add(speed);
            max = Speed.Max();
            min = Speed.Min();
            avg = Speed.Average();
        }
        public void FindSpeed()
        {
            
            
        }

    }
}
