﻿namespace myHr.domain.myHrIdentityDb;

public class JwtSettings
{
    public string Issuer { get; set; } = string.Empty!;
    public string Audience { get; set; } = string.Empty;
    public string Secret { get; set; } = string.Empty;
    public int ExpirationInMinutes { get; set; } = 60;
}
