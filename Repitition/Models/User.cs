namespace Repitition.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public int Age { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }

    public override string ToString()
        => $"Id: {Id}, Username: {Username}, Age: {Age}, Phone number: {PhoneNumber}, Addres: {Address}";
}
