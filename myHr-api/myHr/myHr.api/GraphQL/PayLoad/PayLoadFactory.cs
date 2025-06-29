namespace myHr.api.GraphQL.PayLoad
{
    public static class PayLoadFactory
    {
        public static PayLoad<T> ProduceResult<T>(FluentResults.Result<T> result) 
        {
            return new PayLoad<T>
            {
                success = result.IsSuccess,
                data = result.IsSuccess ? result.Value : default,
                message = result.IsSuccess ? $"{typeof(T)} success!" : string.Join("; ", result.Errors.Select(x => x.Message))
            };
        }
    }
}
