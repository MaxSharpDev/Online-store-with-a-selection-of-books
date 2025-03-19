namespace BookStore.API.Contracts
{
    public record BooksResponce(Guid id,
        string Title,
        string Description,
        decimal Price);
    
}
