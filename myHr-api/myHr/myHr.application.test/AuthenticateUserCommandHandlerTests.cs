using FluentAssertions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using myHr.application.Contracts;
using myHr.application.Features.Authentication.Command.AuthenticateUser;
using myHr.domain.myHrIdentityDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace myHr.application.test;

public class AuthenticateUserCommandHandlerTests
{
    private readonly Mock<UserManager<ApplicationUser>> _userManagerMock;
    private readonly Mock<SignInManager<ApplicationUser>> _signInManagerMock;
    private readonly Mock<IJwtService> _jwtServiceMock;
    private readonly AuthenticateUserCommandHandler _handler;

    public AuthenticateUserCommandHandlerTests()
    {
        var userStoreMock = new Mock<IUserStore<ApplicationUser>>();
        _userManagerMock = new Mock<UserManager<ApplicationUser>>(userStoreMock.Object, null, null, null, null, null, null, null, null);

        var contextAccessorMock = new Mock<IHttpContextAccessor>();
        var userPrincipalFactoryMock = new Mock<IUserClaimsPrincipalFactory<ApplicationUser>>();

        _signInManagerMock = new Mock<SignInManager<ApplicationUser>>(/* Don't mock here */);
        var realSignInManager = GetFakeSignInManager();

        _jwtServiceMock = new Mock<IJwtService>();

        _handler = new AuthenticateUserCommandHandler(_jwtServiceMock.Object, _userManagerMock.Object, _signInManagerMock.Object);

        //_handler = new AuthenticateUserCommandHandler(_jwtServiceMock.Object, _userManagerMock.Object, realSignInManager);
    }

    private SignInManager<ApplicationUser> GetFakeSignInManager()
    {
        var userManager = _userManagerMock.Object;
        var contextAccessor = new Mock<IHttpContextAccessor>();
        var claimsFactory = new Mock<IUserClaimsPrincipalFactory<ApplicationUser>>();
        var options = new Mock<IOptions<IdentityOptions>>();
        var logger = new Mock<ILogger<SignInManager<ApplicationUser>>>();
        var schemes = new Mock<IAuthenticationSchemeProvider>();
        var confirmation = new Mock<IUserConfirmation<ApplicationUser>>();


        var signInManagerMock = new Mock<SignInManager<ApplicationUser>>(
            _userManagerMock.Object,
            contextAccessor.Object,
            claimsFactory.Object,
            options.Object,
            logger.Object,
            schemes.Object,
            confirmation.Object
        )
        { CallBase = true };

        signInManagerMock.Setup(x => x.PasswordSignInAsync(
            It.IsAny<string>(),
            It.IsAny<string>(),
            false,
            false))
            .ReturnsAsync(SignInResult.Success);



        return new SignInManager<ApplicationUser>(
            userManager,contextAccessor.Object,claimsFactory.Object,options.Object,logger.Object,schemes.Object
        );
    }

    //[Fact]
    //public async Task Handle_ValidCredentials_ReturnsToken()
    //{
    //    // Arrange
    //    var user = new ApplicationUser { UserName = "jeorge" };
    //    var roles = new List<string> { "Admin" };
    //    var token = "mocked-jwt-token";

    //    var request = new AuthenticateUserCommand
    //    {
    //        username = "jeorge",
    //        password = "password123"
    //    };

    //    _userManagerMock.Setup(x => x.FindByNameAsync(request.username))
    //            .ReturnsAsync(user);

    //    _userManagerMock.Setup(x => x.GetRolesAsync(user))
    //                    .ReturnsAsync(roles);

    //    _jwtServiceMock.Setup(x => x.GenerateToken(user, roles))
    //                   .ReturnsAsync(token);

    //    // Act
    //    var result = await _handler.Handle(request, CancellationToken.None);

    //    // Assert
    //    Assert.Equal(token, result);
    //}
}
