using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    public class Refrigerator
    {
        public double Weight { set; get; }
        public double CurrentWeight { set; get; }
        public double RemaininWeight { set; get; }


        public string FindWeight(double item, double kg)
        {
            string message="";
            CurrentWeight = item*kg;
            RemaininWeight = Weight - CurrentWeight;
            if(CurrentWeight> Weight )
            {
                 message = "Your Given Amount Can't be enterd bcauese it will be over flown";
                CurrentWeight = 0;
                RemaininWeight = 0;


            }
            else
            {
                message = "Weight information is given below";
            }
            return message;


        }
    }
}
