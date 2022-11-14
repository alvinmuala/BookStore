using BookStore.Domain.Contracts.Services;
using BookStore.Domain.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [Produces("application/json")]
    [Route("books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

     
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var result = await _bookService.GetBookAsync(id);

            return result;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            var result = await _bookService.GetAllBooksAsync();

            return result.ToList();
        }
    }
}
