namespace myHr.application.Features.Authentication.Command.AuthenticateUser;

public class AuthenticateUserCommand : IRequest<Result<string>> 
{
    public required string username { get; set; }

    public required string password { get; set; }
}
