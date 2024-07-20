using System;
namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    public int NumberOfWheels { get; set; }
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string HeadquartersLocation { get; set; }
    public string Logo { get; set; }
    public bool HasTrunk { get; set; }
    public string CarType { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Car Details: \nMake: {Make}, Model: {Model}, Number of Wheels: {NumberOfWheels}, Year: {Year}, Has Trunk: {HasTrunk}, Type: {CarType}\nCompany Details: Logo: {Logo}, Headquarters: {HeadquartersLocation}");
    }
}