namespace Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public Name Name { get; private set; }
    public Surname Surname { get; private set; }
    public ICollection<Book> Books { get; }

    public User(Guid id, Name name, Surname surname)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Books = new List<Book>();
    }
}
