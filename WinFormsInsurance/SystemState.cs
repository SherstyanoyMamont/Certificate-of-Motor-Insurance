using Certificate_of_Motor_Insurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsInsurance
{
    public class SystemState
    {   
        public List<Client> Clients = new List<Client> ();
        public List<Insurance> Insurances = new List<Insurance>();

        public SystemState()
        {

        }
        
    }
}
