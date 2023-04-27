namespace Domain.Exceptions;

internal sealed class InvalidBookIdException : CustomException
{
    public InvalidBookIdException(Guid guid) : base($"Id: {guid} is invalid")
    {
    }
}
