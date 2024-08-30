namespace App.Domain;

public class User : Auditable
{
    public string Name { get; set; }
    public string Email { get; set; }
}
