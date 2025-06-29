namespace myHr.application.Features.Authentication.Command.AuthenticateUser;

public class AuthenticateUserCommandValidator : AbstractValidator<AuthenticateUserCommand>
{
    private readonly IUserRepository _repository;

    public AuthenticateUserCommandValidator(IUserRepository repository)
    {
        _repository = repository;

        RuleFor(x => x.username)
            .NotNull().WithMessage("Username must not be null!");

        RuleFor(x => x.password)
            .NotNull().WithMessage("Password must not be null!");
    }
}
