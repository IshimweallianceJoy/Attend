using Application.DTOs;
namespace Application.Interfaces
{
    public interface IIdentity
    {
        Task RegisterUserAsync(RegisterUserDTO register);
        Task<List<GetUserDTO>> GetAllUsersAsync();
    }
}