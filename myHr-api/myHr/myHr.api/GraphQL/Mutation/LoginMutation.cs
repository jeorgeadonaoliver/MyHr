using HotChocolate.Authorization;

namespace myHr.api.GraphQL.Mutation;

[ExtendObjectType("Mutation")]
public class LoginMutation
{
    private readonly ICookieService _cookieService;
    public LoginMutation(ICookieService cookieService)
    {
        _cookieService = cookieService;
    }

    [AllowAnonymous]
    [GraphQLName("login")]
    public async Task<PayLoad<string>> Login([Service] IMediator mediator, [GraphQLName("command")]  AuthenticateUserCommand command, CancellationToken cancellationToken)
    {
        var result = await mediator.Send(command, cancellationToken);
        return PayLoadFactory.ProduceResult(result);
    }
}
