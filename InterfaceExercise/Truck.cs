using System;
namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public int NumberOfWheels { get; set; }
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string HeadquartersLocation { get; set; }
    public string Logo { get; set; }
    public int CargoCapacity { get; set; }
    public bool HasTrailer { get; set; }

    
    public void DisplayDetails()
    {
        Console.WriteLine($"Truck Details: \nMake: {Make}, Model: {Model}, Number of Wheels: {NumberOfWheels}, Year: {Year}, Cargo Capacity: {CargoCapacity} tons, Has Trailer: {HasTrailer}\nCompany Details: Logo: {Logo}, Headquarters: {HeadquartersLocation}");
    }
}