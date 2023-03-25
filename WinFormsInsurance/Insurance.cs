using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificate_of_Motor_Insurance
{
    public class Insurance
    {
        public double BasePrice { get; private set; }
        public string? Coverage { get; private set; }
        public DateTime Date { get; private set; }
        public double FinalPrice { get; private set; }
        public string? CertificateNumber { get; private set; }
        public Person Client { get; private set; }

        public static List<Insurance> ListInsurance = new List<Insurance>(1);
        public Insurance(Person client, string? coverage, DateTime dateTime)
        {
            this.BasePrice = 1000;                                                                                                           // Define the base price for the insurance.
            this.CertificateNumber = "FCCC" + client.DateOfBirth.ToString("yyyyMMddHH", System.Globalization.CultureInfo.InvariantCulture);  // Create Certificate Number from client's date of birth
            this.Client = client;
            this.Coverage = coverage;
            this.Date = dateTime;
            this.FinalPrice = CalculateInsuranceCost(client);
            ListInsurance.Add(this);
        }
        public double CalculateInsuranceCost(Person client)
        {
            double genderFactor = client.Gender == "M" || client.Gender == "Male" || client.Gender == "m" ? 2 : 0.8;                    // Higher for male drivers
            double ageFactor = client.Age switch
            {
                < 20 => genderFactor * BasePrice * 0.2,
                >= 20 and <= 35 => genderFactor * BasePrice * -0.4,
                _ => genderFactor * BasePrice * -0.65
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
            double carModelFactor = client.Car.MakeAndModel switch    // Higher for certain car models
            {
                "BMW Convertible" => 200,
                "BMW Gran Turismo" => 250,
                "BMW X6" => 300,
                "BMW Z4" => 175,
                "Opel Corsa" => 50,
                "Opel Astra" => 105,
                "Opel Vectra" => 150,
                "Toyota Yaris" => 50,
                "Toyota Auris" => 50,
                "Toyota Corolla" => 50,
                "Toyota Avensis" => 50,
                "Renault Fleunce" => 100,
                "Renault Megane" => 75,
                "Renault Clio" => 50,
                _ => 300
            };
            double emissionsFactor = 150;                                              // Higher for full coverage
            if (client.Car.Emission == "High") { emissionsFactor = 300; }
            else if (client.Car.Emission == "Low") { emissionsFactor = - 55; }
            double coverageFactor = Coverage == "Fully" ? 200 : -120; ;                // Meaning for middle emission

            return FinalPrice = BasePrice * genderFactor + ageFactor + locationFactor + carModelFactor + emissionsFactor + coverageFactor; // Return the final price.
        }
    }
}
