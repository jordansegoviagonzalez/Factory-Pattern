namespace FactoryPattern
//'namespace' is used to group related classes and avoid nameconflicts.
//'FactoryPattern' is the namespace that organizes all factory realted classes.
{
    public class Program
    //'public allows this class to be accessed from other parts of the program.
    //'class' defines a blueprint for creating objects
    //'Program' is the name of the class that serves as the entry point of the application.
    {
        static void Main(string[] args)
        //'static' means this method belongs to the class itself than an instance of the class.
        //'void' means this method does not return any value.
        //'string[] args' allows passing command line arguments when running the program
        {
            Console.WriteLine("How many wheels dose your vehicle have?");
            //'Console.WriteLine' prints the given text to the console.
            //The message ask the user to enter the number of wheels for their vehicle.
            
            var wheelCount = int.Parse(Console.ReadLine());
            //'var' lets the compiler decided the variable's type based on the asssigned value.
            //Since 'int.Parse()' returns an integer, 'wheelCount' will be an 'int'.
            //'wheelCount' stores the number of wheels entered by the user.
            //'int.Parse()' converts the input string into an integer to be used in the program.
            //'wheelCount' stores the number of wheels entered by user.

            var vehicle = VehicleFactory.CreateVehicle(wheelCount);
            //'var' letrs the compiler decided the variable's type based on the assined value.
            //Since 'VehicleFactory.CreatedVehicle(wheelCount)' returns a class impementing 'IVehicle'
            //'vehicle' will be an object of a specific vehicle type.
            vehicle.Drive();
            //'vehicle.Drive()' call the 'Drive' method on the created vehicle object.
            //This executes the behavior specific to the type of vehicle that was instantiated'
            
        }
    }
}
