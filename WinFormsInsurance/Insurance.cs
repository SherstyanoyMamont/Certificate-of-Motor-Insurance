using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificate_of_Motor_Insurance
{
    internal class Insurance
    {
        public double BasePrice { get; private set; }
        public string? Coverage { get; private set; }
        public double FinalPrice { get; private set; }
        public string? CertificateNumber { get; private set; }
        public Person Client { get; private set; }
        internal ListInsurance ListInsurance { get; private set; }
        public Insurance(Person client, string? coverage) 
        {
            BasePrice = 1000;                                                                                                           // Define the base price for the insurance.
            CertificateNumber = "FCCC" + client.DateOfBirth.ToString("yyyyMMddHH", System.Globalization.CultureInfo.InvariantCulture);  // Create Certificate Number from client's date of birth
            Client = client;
            Coverage = coverage;
            FinalPrice = CalculateInsuranceCost(client);
        }
        public double CalculateInsuranceCost(Person client)
        {
            double genderFactor = client.Gender == "M" || client.Gender == "Male" || client.Gender == "m" ? 2 : 0.8;                    // Higher for male drivers
            double ageFactor = client.Age switch
            {
                < 20 => genderFactor * BasePrice * 0.2,
                >= 20 and <= 35 => genderFactor * BasePrice * -0.4,
                < 80 and > 35 => genderFactor * BasePrice * -0.65,
                _ => genderFactor * BasePrice * -1
            };
            double locationFactor = client.Location switch    // Choise the location factor
            {
                "Clare" or "Cl" => 225,
                "Limerick" or "L" => -75,
                "Tipperary" or "T" => -80,                                                                          
                "Waterford" or "W" => -100,
                "Cork" or "Kerry" or "Co" or "K" => 50,
                _ => 0
            };
            double carModelFactor = client.Car.Make switch    // Higher for certain car models
            {
                "BMW" => client.Car.Model switch
                {
                    "Convertible" => 200,
                    "Gran Turismo" => 250,
                    "X6" => 300,
                    "Z4" => 175,
                    _ => 300
                },
                "Opel" => client.Car.Model switch
                {
                    "Corsa" => 50,
                    "Astra" => 105,
                    "Vectra" => 150,
                    _ => 150
                },
                "Toyota" => client.Car.Model switch
                {
                    "Yaris" => 50,
                    "Auris" => 75,
                    "Corolla" => 100,
                    "Avensis" => 125,
                    _ => 125
                },
                "Renault" => client.Car.Model switch
                {
                    "Fleunce" => 100,
                    "Megane" => 75,
                    "Clio" => 50,
                    _ => 100
                },
                _ => 300
            };
            double emissionsFactor = 150;                                                                                                  // Higher for full coverage
            if (client.Car.Emission == "High" || client.Car.Emission == "H") { emissionsFactor = 300; }
            else if (client.Car.Emission == "Low" || client.Car.Emission == "L") { emissionsFactor = - 55; }
            double coverageFactor = Coverage == "Fully" || Coverage == "F" ? 200 : -120; ;                                                 // Meaning for middle emission

            return FinalPrice = BasePrice * genderFactor + ageFactor + locationFactor + carModelFactor + emissionsFactor + coverageFactor; // Return the final price.
        }
    }
}
