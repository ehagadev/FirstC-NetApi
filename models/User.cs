public class User {
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }

    public User() {
    }

    public User(string email, string password, string phoneNumber) {
        Email = email;
        Password = password;
        PhoneNumber = phoneNumber;
    }
}