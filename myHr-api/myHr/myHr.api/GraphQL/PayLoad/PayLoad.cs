namespace myHr.api.GraphQL.PayLoad
{
    public class PayLoad<T>
    {
        public bool success { get; set; }

        public T? data { get; set; }

        public string? message { get; set; } = string.Empty;
    }
}
