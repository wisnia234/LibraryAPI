namespace Infrastructure.Configuration;

internal sealed class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Title).HasConversion(x => x.Value, x => new Title(x)).IsRequired();
        builder.Property(x => x.Author).HasConversion(x => x.Value, x => new Author(x)).IsRequired();
        builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now.Date);
    }
}
