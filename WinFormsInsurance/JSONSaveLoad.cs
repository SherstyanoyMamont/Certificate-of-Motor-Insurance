using Certificate_of_Motor_Insurance;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsInsurance
{
    public class JSONSaveLoad
    {
        public int MyProperty { get; set; }
        public string? FileName { get; set; }
        public string? JsonString { get; set; }
        public JSONSaveLoad(Insurance inshurance1)
        {
            MyProperty = 243;
            FileName = "instance.json";
            JsonString = JsonConvert.SerializeObject(inshurance1);
        }
    }
}


