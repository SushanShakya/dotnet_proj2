namespace sol22.Models;

public class Company
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }

    public override string ToString()
    {
        return $"Company(id: {Id}, name: {Name}, address: {Address})";
    }
}