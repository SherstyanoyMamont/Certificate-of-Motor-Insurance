using Certificate_of_Motor_Insurance;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsInsurance
{
    public static class JSONManager
    {
        public static void Save(string FileName, SystemState systemState)
        {
            File.WriteAllText(FileName, JsonConvert.SerializeObject(systemState, Formatting.Indented));
        }

        public static SystemState Load(string FileName)
        {
            if (File.Exists(FileName))
                return JsonConvert.DeserializeObject<SystemState>(File.ReadAllText(FileName));
            else return null;
        }
    }
}


