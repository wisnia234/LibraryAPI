namespace Domain.ValueObjects;

public sealed record Surname
{
    public string Value { get; }

    public Surname(string value)
    {
        if (string.IsNullOrEmpty(value)
            || string.IsNullOrWhiteSpace(value)
            || char.IsLower(value[0]))

            throw new InvalidSurnameException();

        Value = value;
    }

    public static implicit operator string(Surname name)
        => name.Value;

    public static implicit operator Surname(string value)
        => new(value);
}
