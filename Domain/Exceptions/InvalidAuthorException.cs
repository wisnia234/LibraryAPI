namespace Domain.Exceptions;

internal sealed class InvalidAuthorException : CustomException
{
    public InvalidAuthorException() : base("Author is not valid")
    {

    }
}
