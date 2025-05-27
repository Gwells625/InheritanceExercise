namespace Inheritance;

public class Reptile : Animals
{
    public Reptile()
    {
        IsAlive = true;
        NumberOfLegs = 4;
        LandSeaAir = "Land";
        Age = 0;
    }
    
    public bool IsColdBlooded { get; set; }
    public bool IsScaly { get; set; }
    public string Habitat { get; set; }
    public bool CanGrowBackTail { get; set; }
}