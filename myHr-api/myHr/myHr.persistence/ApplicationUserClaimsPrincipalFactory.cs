namespace myHr.persistence;

public class ApplicationUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser, IdentityRole>
{
    public ApplicationUserClaimsPrincipalFactory(
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager,
        IOptions<IdentityOptions> optionsAccessor)
        : base(userManager, roleManager, optionsAccessor)
    {
    }

    public override async Task<ClaimsPrincipal> CreateAsync(ApplicationUser user)
    {

        var principal = await base.CreateAsync(user);

        var identity = (ClaimsIdentity)principal.Identity!;

        if (!string.IsNullOrEmpty(user.FullName))
        {
            identity.AddClaim(new Claim("fullname", user.FullName));

            // identity.AddClaim(new Claim(ClaimTypes.GivenName, user.FirstName ?? ""));
            // identity.AddClaim(new Claim(ClaimTypes.Surname, user.LastName ?? ""));
        }

        return principal;
    }
}