using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificate_of_Motor_Insurance
{
    public class ListInsurance
    {
        public List<Insurance> InsurancesList = new List<Insurance>();
        public Insurance Insurance { get; private set; }
        public ListInsurance(Insurance insurance)
        {
            Insurance = insurance;
            InsurancesList.Add(Insurance);
        }
    }
}