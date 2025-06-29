using myHr.domain.myHrIdentityDb;

namespace myHr.application.Contracts;

public interface IJwtService
{
    public Task<string> GenerateToken(ApplicationUser user, IList<string> roles);
}
