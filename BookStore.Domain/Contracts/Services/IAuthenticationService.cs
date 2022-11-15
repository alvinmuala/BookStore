using BookStore.Domain.Models.Dtos;

namespace BookStore.Domain.Contracts.Services
{
    public interface IAuthenticationService
    {
        Task<string> Register(RegisterRequestDto request);
        Task<string> Login(LoginRequestDto request);
    }
}
