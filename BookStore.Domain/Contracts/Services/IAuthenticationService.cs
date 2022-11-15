using BookStore.Domain.Models.Dtos;

namespace BookStore.Domain.Contracts.Services
{
    public interface IAuthenticationService
    {
        Task<string> RegisterAsync(RegisterRequestDto request);
        Task<string> LoginAsync(LoginRequestDto request);
    }
}
