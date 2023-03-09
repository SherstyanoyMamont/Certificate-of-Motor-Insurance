namespace Certificate_of_Motor_Insurance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool resultAge = false;
            int personAge = 0;
            
            // Prompt the user for their gender, full name, age, location:
            Console.WriteLine("Enter your gender (M or F):");
            string? personGender = Console.ReadLine();
            while (personGender != "M" && personGender != "F" && personGender != "Female" && personGender != "Male") // Validation of input male
            {
                Console.WriteLine("Error: Enter your gender as in the example in brackets (M or F):");
                personGender = Console.ReadLine();
            }
            Console.WriteLine("Enter your full name (First name and Second name:");
            string? fullName = Console.ReadLine();
            
            while (resultAge == false) // Validation of input age
            {
                Console.WriteLine("Enter your age:");
                resultAge = int.TryParse(Console.ReadLine(), out personAge);
                if (resultAge == false)
                {
                    Console.WriteLine("Error: Enter your age in integer number please:");
                }
            }
            Console.WriteLine("Enter your location (County):");
            string? personLocation = Console.ReadLine();

            Person client = new Person(personGender, fullName, personAge, personLocation);

            // Main information about client's car
            Console.WriteLine("Enter your car make:");
            string? carMake = Console.ReadLine();
            Console.WriteLine("Enter your car model:");
            string? carModel = Console.ReadLine();
            Console.WriteLine("Enter your emissions (High, Medium or Low):");
            string? emissions = Console.ReadLine();
            Console.WriteLine("Enter your coverage (Fully or Partial):");
            string? coverage = Console.ReadLine();

            Car clientsСar = new Car(carMake, carModel, emissions, coverage);

            // Calculate the final price using the CalculateInsuranceCost function and display the result to the user.
            double finalPrice = CalculateInsuranceCost(client.Gender, client.Age, client.Location, clientsСar);;
            Console.WriteLine($"Insurance cost: {finalPrice}");
        }
        static double CalculateInsuranceCost(string? Gender, int Age, string? Location, Car clientsСar)
        {
            double basePrice = 1000; // Define the base price for the insurance.

            // Define the factors for each of the user's inputs.
            double genderFactor = Gender == "M" || Gender == "Male" || Gender == "m" ? 2 : 0.8; // Higher for male drivers
            double ageFactor = Age switch
            {
                < 20 => genderFactor * basePrice * 0.2,
                >= 20 and <= 35 => genderFactor * basePrice * -0.4,
                < 80 and > 35 => genderFactor * basePrice * -0.65,
                _ => genderFactor * basePrice * -1
            };
            // Choise the location factor
            double locationFactor = Location switch
            {
                "Clare" or "Cl" => 225,
                "Limerick" or "L" => -75,
                "Tipperary" or "T" => -80,
                "Waterford" or "W" => -100,
                "Cork" or "Kerry" or "Co" or "K" => 50,
                _ => 0
            };
            double carModelFactor = GetCarModelFactor(clientsСar.Make, clientsСar.Model); // Higher for certain car models
            double emissionsFactor = GetCarEmissionFactor(clientsСar.Emission);  // Higher for full coverage
            double coverageFactor = clientsСar.Coverage == "Fully" || clientsСar.Coverage == "F" ? 200 : -120; ; // Meaning for middle emission
            
            // Calculate the final price based on the factors and the base price.
            double finalPrice = basePrice * genderFactor + ageFactor + locationFactor + carModelFactor + emissionsFactor + coverageFactor;
            return finalPrice; // Return the final price.
        }
        static double GetCarEmissionFactor(string? Emission)
        {
            if (Emission == "High" || Emission == "H") { return 300; }
            else if (Emission == "Low" || Emission == "L") { return -55; }
            else { return 150; }
        }
        static double GetCarModelFactor(string? Make, string? Model) // Define the factors for certain car models.
        {
            return Make switch
            {
                "BMW" => Model switch
                {
                    "Convertible" => 200,
                    "Gratn Terismo" => 250,
                    "X6" => 300,
                    "Z4" => 175,
                    _ => 300
                },
                "Opel" => Model switch
                {
                    "Corsa" => 50,
                    "Astra" => 105,
                    "Vectra" => 150,
                    _ => 150
                },
                "Toyota" => Model switch
                {
                    "Yaris" => 50,
                    "Auris" => 75,
                    "Corolla" => 100,
                    "Avensis" => 125,
                    _ => 125
                },
                "Renault" => Model switch
                {
                    "Fleunce" => 100,
                    "Megane" => 75,
                    "Clio" => 50,
                    _ => 100
                },
                _ => 300
            };
        }
    }
}
