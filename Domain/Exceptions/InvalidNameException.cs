namespace Domain.Exceptions;

internal sealed class InvalidNameException : CustomException
{
    public InvalidNameException() : base("Name is invalid")
    {
    }
}
