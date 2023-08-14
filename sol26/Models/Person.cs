namespace sol26.Models;

public class Person
{
    public string? Name { get; set; }

    public override string ToString()
    {
        return Name!;
    }
}