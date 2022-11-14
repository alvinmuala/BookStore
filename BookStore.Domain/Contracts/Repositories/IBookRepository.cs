using BookStore.Domain.Models.Entities;

namespace BookStore.Domain.Contracts.Repositories
{
    public interface IBookRepository
    {
        Task<Book> GetAsync(int id);
        Task<IEnumerable<Book>> GetAllAsync();
    }
}
