namespace Application.Commands;

public record CreateBook(Guid Id, Title Title, string Description, Author Author)
{
}
