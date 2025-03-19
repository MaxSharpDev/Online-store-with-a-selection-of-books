using BookStore.Core.Models;

namespace BookStore.Application.Servies
{
    public interface IBooksServies
    {
        Task<Guid> CreateBook(Book book);
        Task<Guid> DeleteBook(Guid id);
        Task<List<Book>> GetOLDBook();
        Task<Guid> UpdateBook(Guid id, string title, string description, decimal price);
    }
}