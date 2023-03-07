using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificate_of_Motor_Insurance
{
    class Car
    {
        public string? Make { get; private set; }
        public string? Model { get; private set; }
        public string? Emission { get; private set; }
        public string? Coverage { get; private set; }

        public Car(string? make, string? model, string? emission, string? coverage)
        {
            Make = make;
            Model = model;
            Emission = emission;
            Coverage = coverage;
        }
    }
}
