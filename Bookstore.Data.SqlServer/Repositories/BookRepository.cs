using BookStore.Domain.Contracts.Repositories;
using BookStore.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Data.SqlServer.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly Storage _storage;

        public BookRepository(Storage storage)
        {
            _storage = storage;
        }

        public async Task<Book> GetAsync(int id)
        {
            var result = await _storage.Books.FindAsync(id);

            if (result == null)
            {
                throw new ArgumentException($"Book with Id '{id}' doesn't exist");
            }

            return result;
        }
        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _storage.Books.ToListAsync();
        }
    }
}
