using BookStore.Domain.Contracts.Repositories;
using BookStore.Domain.Contracts.Services;
using BookStore.Domain.Models.Entities;

namespace BookStore.Domain.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<Book> GetBookAsync(int id)
        {
            return await _bookRepository.GetAsync(id);
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _bookRepository.GetAllAsync();
        }
    }
}
