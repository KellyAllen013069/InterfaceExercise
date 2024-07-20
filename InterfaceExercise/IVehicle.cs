namespace InterfaceExercise;

public interface IVehicle
{
    //In your IVehicle:
            
    /* Create 4 members that Car, Truck, & SUV all have in common.
     * Example: public int NumberOfWheels { get; set; }
     */

    int NumberOfWheels { get; set; }
    int Year { get; set; }
    string Make { get; set; }
    string Model { get; set; }

    void DisplayDetails();
}