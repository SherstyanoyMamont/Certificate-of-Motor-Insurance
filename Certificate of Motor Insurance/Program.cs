namespace Certificate_of_Motor_Insurance
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            // Prompt the user for their gender, age, location, car model, emissions, and coverage.
            Console.WriteLine("Enter your gender (M or F):");
            string? gender = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your location:");
            string? location = Console.ReadLine();

            Console.WriteLine("Enter your car make:");
            string? carMake = Console.ReadLine();

            Console.WriteLine("Enter your car model:");
            string? carModel = Console.ReadLine();

            Car clientsСar = new Car(carMake, carModel);

            Console.WriteLine("Enter your emissions:");
            string? emissions = Console.ReadLine();

            Console.WriteLine("Enter your coverage:");
            string? coverage = Console.ReadLine();

            // Calculate the final price using the CalculateInsuranceCost function and display the result to the user.
            double finalPrice = CalculateInsuranceCost(gender, age, location, clientsСar, emissions, coverage);
            Console.WriteLine($"Insurance cost: {finalPrice}");
        }

        static double CalculateInsuranceCost(string? gender, int age, string? location, Car car, string? emissions, string? coverage)
        {
            // Define the base price for the insurance.
            double basePrice = 1000;

            // Define the factors for each of the user's inputs.
            double genderFactor = gender == "M" ? 2 : 0.8; // Higher for male drivers
            double ageFactor = genderFactor * basePrice * -1; // Higher for younger drivers
            if (age < 20)
            {
                ageFactor = genderFactor * basePrice * 0.2;
            }
            else if(age <= 35 && age >= 20)
            {
                ageFactor = genderFactor * basePrice * -0.4;
            }
            else if (age < 80 && age > 35)
            {
                ageFactor = genderFactor * basePrice * -0.65;
            }
            double locationFactor = 0; // neutral
            if (location == "Clare")
            {
                locationFactor = 225;
            }
            else if (location == "Limerick")
            {
                locationFactor = -75;
            }
            else if (location == "Tipperary")
            {
                locationFactor = -80;
            }
            else if (location == "Waterford")
            {
                locationFactor = -100;
            }
            else if (location == "Cork" || location == "Kerry")
            {
                locationFactor = 50;
            }
            double carModelFactor = GetCarModelFactor(car); // Higher for certain car models
            double emissionsFactor = 150; // Meaning for middle emission
            if (emissions == "High")
            {
                emissionsFactor = 300;
            }
            else if (emissions == "Low")
            {
                emissionsFactor = -55;
            }
            double coverageFactor = coverage == "Fully" ? 200 : -120; // Higher for full coverage


            // Calculate the final price based on the factors and the base price.
            double finalPrice = basePrice * genderFactor + ageFactor + locationFactor + carModelFactor + emissionsFactor + coverageFactor;


            // Return the final price.
            return finalPrice;
        }
        static double GetCarModelFactor(Car car)
        {
            // Define the factors for certain car models.
            switch (car.Make)
            {
                case "BMW":
                    switch (car.Model)
                    {
                        case "Convertible":
                            return 200;
                        case "Gratn Terismo":
                            return 250;
                        case "X6":
                            return 300;
                        case "Z4":
                            return 175;
                        default:
                            return 300;
                    }
                case "Opel":
                    switch (car.Model)
                    {
                        case "Corsa":
                            return 50;
                        case "Astra":
                            return 105;
                        case "Vectra":
                            return 150;
                        default:
                            return 150;
                    }
                case "Toyota":
                    switch (car.Model)
                    {
                        case "Yaris":
                            return 50;
                        case "Auris":
                            return 75;
                        case "Corolla":
                            return 100;
                        case "Avensis":
                            return 125;
                        default:
                            return 1.1;
                    }
                case "Renault":
                    switch (car.Model)
                    {
                        case "Fleunce":
                            return 100;
                        case "Megane":
                            return 75;
                        case "Clio":
                            return 50;
                        default:
                            return 100;
                    }
                default:
                    return 1.0;
            }
        }
    }
}