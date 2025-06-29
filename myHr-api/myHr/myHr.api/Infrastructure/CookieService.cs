namespace myHr.api.Infrastructure;

public class CookieService : ICookieService
{
    public async Task SetToken(HttpResponse response, string token, string key)
    {
        await Task.Run(() => {

            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Secure = false, // true in production
                SameSite = SameSiteMode.Lax,
                Expires = DateTimeOffset.UtcNow.AddDays(1),
                Path = "/"
            };

            response.Cookies.Append(key, token, cookieOptions);

        });
    }
    public void ClearCookie(HttpResponse response, string key)
    {
        response.Cookies.Delete(key, new CookieOptions { Path = "/" });
    }

}
