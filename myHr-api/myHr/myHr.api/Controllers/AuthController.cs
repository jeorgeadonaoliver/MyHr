namespace myHr.api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IMediator _mediator;
    public AuthController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [Microsoft.AspNetCore.Authorization.Authorize]
    [HttpGet("Home")]
    public IActionResult Home() {

        return Ok("Hello World");
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login(AuthenticateUserCommand command) 
    {
        var data = await _mediator.Send(command);
        return Ok(data);
    }
}
