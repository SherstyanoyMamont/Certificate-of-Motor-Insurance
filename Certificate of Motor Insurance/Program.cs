namespace Certificate_of_Motor_Insurance
{
    internal class Program
    {
        static void Main(string[] args)
        {;
            bool resultAge = false;
            DateTime dateOfBirth = DateTime.Now;

            Console.WriteLine("Enter your gender (M or F):");
            string? personGender = Console.ReadLine();
            while (personGender != "M" && personGender != "F" && personGender != "Female" && personGender != "Male") // Validation of input male
            {
                Console.WriteLine("Error: Enter your gender as in the example in brackets (M or F):");
                personGender = Console.ReadLine();
            }
            Console.WriteLine("Enter your full name (First name and Second name:)");
            string? fullName = Console.ReadLine();
            while (resultAge == false)                                                                              // Validation of input age
            {
                Console.WriteLine("Enter your date of birth (dd/mm/yyyy):");
                resultAge = DateTime.TryParse(Console.ReadLine(), out dateOfBirth);
                if (resultAge == false)
                {
                    Console.WriteLine("Error: Enter your age in integer number please:");
                }
            }
            Console.WriteLine("Enter your location (County):");
            string? personLocation = Console.ReadLine();
            Console.WriteLine("Enter your car make:");                                                              // Main information about client's car:
            string? carMake = Console.ReadLine();
            Console.WriteLine("Enter your car model:");
            string? carModel = Console.ReadLine();
            Console.WriteLine("Enter your emissions (High, Medium or Low):");
            string? emissions = Console.ReadLine();
            Console.WriteLine("Enter your coverage (Fully or Partial):");
            string? coverage = Console.ReadLine();
            Console.WriteLine("Enter your E-mail:");
            string? email = Console.ReadLine();
            Console.WriteLine("Enter your phone number:");
            string? phoneNumber = Console.ReadLine();

            Car car = new Car(carMake, carModel, emissions);
            Person client = new Person(personGender, fullName, dateOfBirth, personLocation, car, email, phoneNumber);
            Insurance inshurance1 = new Insurance(client, coverage);
            ListInsurance List = new ListInsurance(inshurance1);

            Console.WriteLine($"Insurance cost: {inshurance1.FinalPrice}");                                          // Calculate the final price using the CalculateInsuranceCost function and display the result to the user.
            Console.WriteLine(inshurance1.CertificateNumber);
        }
    }
}
