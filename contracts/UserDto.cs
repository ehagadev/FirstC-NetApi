public class UserDto
{
    public Guid Id { get; set;}
    public string Email { get; set;}
    public string Password { get; set;}
    public string PhoneNumber { get; set;}

    public UserDto() {
    }

    public UserDto(Guid id, string email, string password, string phoneNumber)
    {
        Id = id;
        Email = email;
        Password = password;
        PhoneNumber = phoneNumber;
    }

    public UserDto(string email, string password, string phoneNumber)
    {
        Email = email;
        Password = password;
        PhoneNumber = phoneNumber;
    }
}