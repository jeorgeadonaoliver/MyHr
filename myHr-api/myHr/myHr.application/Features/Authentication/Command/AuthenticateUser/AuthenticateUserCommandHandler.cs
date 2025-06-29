namespace myHr.application.Features.Authentication.Command.AuthenticateUser;

public class AuthenticateUserCommandHandler : IRequestHandler<AuthenticateUserCommand, Result<string>>
{
    private readonly IJwtService _jwtService;
    private readonly UserManager<ApplicationUser> _usermanager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    public AuthenticateUserCommandHandler(IJwtService jwtService, UserManager<ApplicationUser> usermanager, SignInManager<ApplicationUser> signInManager)
    {
        _signInManager = signInManager;
        _jwtService = jwtService;
        _usermanager = usermanager;
    }

    public async Task<Result<string>> Handle(AuthenticateUserCommand request, CancellationToken cancellationToken)
    {
        var data = await _usermanager.FindByNameAsync(request.username);
        if (data is null) 
        {
            return Result.Fail("Username does not exist!");
        }

        var result = await _signInManager.PasswordSignInAsync(request.username, request.password, false, false);
        if (!result.Succeeded)
        { 
           return Result.Fail("Invalid password! Please try again!"); 
        }

        var role = await _usermanager.GetRolesAsync(data);
        string token = await _jwtService.GenerateToken(data, role);

        return Result.Ok(token);
    }
}
