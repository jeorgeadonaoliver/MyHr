namespace myHr.application.Common;

public class ValidationHandler
{
    public static async Task<Result> ValidateAsync<T>(IValidator<T> validator, T commandInstance, CancellationToken cancellationToken = default)
    {
        if (commandInstance == null)
            return Result.Fail($"{typeof(T)} must not be null!");

        ValidationResult result = await validator.ValidateAsync(commandInstance, cancellationToken);
        if (result.IsValid)
            return Result.Ok();

        return Result.Fail(result.Errors.Select(e => e.ErrorMessage).ToList());
    }
}
