namespace AccountManagement.Application.Contracts.Account;

public class Login
{
    //[Required(ErrorMessage = ValidationMessages.IsRequired)]

    public string Username { get; set; }

    //[Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Password { get; set; }
}