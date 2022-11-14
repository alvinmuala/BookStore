using BookStore.Domain.Models.Entities;

namespace BookStore.Domain.Contracts.Services
{
    public interface IBookService
    {
        Task<Book> GetBookAsync(int id);
        Task<IEnumerable<Book>> GetAllBooksAsync();
    }
}
