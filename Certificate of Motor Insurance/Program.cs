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
            double finalPrice = Calculator.CalculateInsuranceCost(client.Gender, client.Age, client.Location, clientsСar);;
            Console.WriteLine($"Insurance cost: {finalPrice}");
        }
        
    }

}
