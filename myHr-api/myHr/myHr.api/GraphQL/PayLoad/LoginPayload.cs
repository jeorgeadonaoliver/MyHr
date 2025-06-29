namespace myHr.api.GraphQL.PayLoad
{
    public class LoginPayload
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public string? Token { get; set; }

    }
}
