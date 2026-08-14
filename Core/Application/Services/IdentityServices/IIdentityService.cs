using Domain.Entities;
using Application.DTOs;
namespace Application.Services.IdentityServices
{
    public interface IIdentityService
    {
         Task<List<GetUserDTO>> GetAllUsersAsync();
         Task RegisterUserAsync(RegisterUserDTO register);
          Task<bool>LoginAsync(LoginDTO login);
        Task LogOutAsync();
         
    }
}