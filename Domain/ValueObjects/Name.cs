namespace Domain.ValueObjects;

public sealed record Name
{
    public string Value { get; }

    public Name(string value)
    {
        if (string.IsNullOrEmpty(value) 
            || string.IsNullOrWhiteSpace(value)
            || char.IsLower(value[0]))

            throw new InvalidNameException();

        Value = value;
    }

    public static implicit operator string(Name name)
        => name.Value;

    public static implicit operator Name(string value)
        => new(value);
}
