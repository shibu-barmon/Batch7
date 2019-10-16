using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
   public class Refrigerator
   {
       private double maxWeight;
       private double currentWeight=0;
       private List<double> itemNo=new List<double>();
       private List<double> unitWeight = new List<double>();
       

       public  double MaxWeight { set; get; }
       public  double ItemNo { set; get; }
       public  double UnitWeight { set; get; }

       public void AddWeight(double maxWeight)
       {
           this.maxWeight = maxWeight;
       }
       public void AddItemunit(double itemNo, double unitWeight)
       {
           this.itemNo.Add(itemNo);
           this.unitWeight.Add(unitWeight);
           this.currentWeight += itemNo * unitWeight;
       }

       public double CurrentWeight()
       {
           
           return currentWeight;
       }

       public double RemainingWeight()
       {
           double remainingWeight = this.maxWeight - this.currentWeight;
           return remainingWeight;
       }

       public bool Validation()
       {
           bool vailidity = true;
           if (CurrentWeight() > maxWeight)
           {
               vailidity = false;
           }

           return vailidity;
       }

    }
}
