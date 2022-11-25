namespace Day16_Blazor.Data.Model;

public class Animal
{
    public int Id { get; set; }
    public string Nombre { get; set; }

    public ICollection<Zoo> Zoos { get; set; }
}