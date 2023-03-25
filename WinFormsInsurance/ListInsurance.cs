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
        public ListInsurance(Insurance insurance)
        {
            InsurancesList.Add(insurance);
        }
    }
}