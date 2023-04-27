namespace Domain.Entities
{
    public class Book
    {
        public Guid Id { get; private set; }
        public Title Title { get; private set; }
        public string? Description { get; private set; }
        public Author Author { get; private set; }
        public DateTime CreatedDate { get; private set; }
 
        public Book(Guid id, Title title, string? description, Author author, DateTime createdDate)
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
            CreatedDate = createdDate;
        }
    }
}