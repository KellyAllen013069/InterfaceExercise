namespace InterfaceExercise;

public interface ICompany
{
    //In ICompany: 
            
    /* Create 2 members that are specific to each every company
     * regardless of vehicle type.
     * Example: public string Logo { get; set; }
     */
    string HeadquartersLocation { get; set; }
    string Logo { get; set; }
}