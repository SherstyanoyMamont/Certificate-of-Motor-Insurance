using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificate_of_Motor_Insurance
{
   public  class Car
    {
        public string? MakeAndModel{ get; private set; }
        public string? Emission { get; private set; }
        internal Person Person { get; private set; }
        public Car(string? carMakeAndModel, string? emission)
        {
            MakeAndModel = carMakeAndModel;
            Emission = emission;
        }
    }
}
