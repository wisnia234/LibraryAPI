namespace Domain.Exceptions;

internal sealed class InvalidSurnameException : CustomException
{
    public InvalidSurnameException() : base("Surname is invalid")
    {
    }
}
