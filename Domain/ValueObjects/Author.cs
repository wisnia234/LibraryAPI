namespace Domain.ValueObjects;

public sealed record Author
{
    public string Value { get; }

    
    public Author(string value) 
    {
        if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            throw new InvalidAuthorException();

        Value = value;
    }

    public static implicit operator string(Author author)
         => author.Value;

    public static implicit operator Author(string value)
        => new(value);

}
