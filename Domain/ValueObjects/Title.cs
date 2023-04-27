namespace Domain.ValueObjects;

public sealed record Title
{
    public string Value { get; }

    public Title(string value)
    {
        if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            throw new InvalidTitleException();

        Value = value;
    }

    public static implicit operator string(Title title)
        => title.Value;

    public static implicit operator Title(string value)
        => new(value);
}
