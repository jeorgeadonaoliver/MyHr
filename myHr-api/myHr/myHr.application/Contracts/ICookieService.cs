using Microsoft.AspNetCore.Http;

namespace myHr.application.Contracts
{
    public interface ICookieService
    {
        public Task SetToken(HttpResponse response, string token, string key);
    }
}
