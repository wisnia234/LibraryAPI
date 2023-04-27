namespace Domain.ValueObjects;

public sealed record BookId
{
    public Guid Value { get; }

    public BookId(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new InvalidBookIdException(value);
        }

        Value = value;
    }

    public static implicit operator Guid(BookId date)
        => date.Value;

    public static implicit operator BookId(Guid value)
        => new(value);
}
