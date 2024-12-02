namespace MainApp.Interfaces;

public interface ICustomer
{
    string Id { get; set; }
    string Email { get; set; }
}

public interface IPrivateCustomer
{
    string FirstName { get; set; }
    string LastName { get; set; }
}

