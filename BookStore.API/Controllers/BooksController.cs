using BookStore.API.Contracts;
using BookStore.Application.Servies;
using BookStore.DataAcces.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController:ControllerBase
    {
        private readonly IBooksServies _booksServies;
        public BooksController(IBooksServies booksServies)
        {
            _booksServies = booksServies;
        }
        [HttpGet]
        public async Task<ActionResult<List<BooksResponce>>> GetBooks() 
        {
            var books = await _booksServies.GetOLDBook();

            var responce = books.Select(b => new BooksResponce(b.Id, b.Title, b.Description, b.Price));

            return Ok(responce);
        }
    }
}
