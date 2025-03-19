

using BookStore.Core.Models;
using BookStore.DataAcces.Repository;

namespace BookStore.Application.Servies
{
    public class BooksServies : IBooksServies
    {
        private readonly IBooksRepository _repository;
        public BooksServies(IBooksRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Book>> GetOLDBook()
        {
            return await _repository.Get();

        }

        public async Task<Guid> CreateBook(Book book)
        {
            return await _repository.Create(book);

        }
        public async Task<Guid> UpdateBook(Guid id, string title, string description, decimal price)
        {
            return await _repository.Update(id, title, description, price);
        }
        public async Task<Guid> DeleteBook(Guid id)
        {
            return await _repository.Delete(id);
        }
    }
}
