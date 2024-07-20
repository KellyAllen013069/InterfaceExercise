using System;
namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    public int NumberOfWheels { get; set; }
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string HeadquartersLocation { get; set; }
    public string Logo { get; set; }
    public int NumberOfSeats { get; set; }
    public bool HasFourWheelDrive { get; set; }
    
    public void DisplayDetails()
    {
        Console.WriteLine($"SUV Details: \nMake: {Make}, Model: {Model}, Number of Wheels: {NumberOfWheels}, Year: {Year} , Number of Seats: {NumberOfSeats}, Four Wheel Drive: {HasFourWheelDrive}\nCompany Details: Logo: {Logo}, Headquarters: {HeadquartersLocation}");
    }
}