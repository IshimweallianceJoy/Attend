using Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Application.DTOs;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Domain.ValueObject;
namespace Infrastructure.Identity
{
    public class IdentityRepository:IIdentity
    {
        private readonly ApplicationDbContext _dbcontext;
        private readonly IUserContext _Usercontext;
         public readonly SignInManager<User> _signInManager;
        public readonly UserManager<User> _userManager;
        public readonly RoleManager<IdentityRole<int>> _roleManager;

        public IdentityRepository(ApplicationDbContext dbContext,  UserManager<User> userManager, RoleManager<IdentityRole<int>> roleManager, SignInManager<User> signInManager, IUserContext userContext)
        {
            _dbcontext=dbContext;
             _signInManager =signInManager;
            _userManager = userManager;
            _roleManager= roleManager;
            _Usercontext = userContext;
        }
        public async Task<List<GetUserDTO>> GetAllUsersAsync()
        {
            
            return await _dbcontext.Users.Select(u=> new GetUserDTO
            {
                Id=u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email,
                UserName = u.UserName,
                PhoneName = u.PhoneNumber,
                Status = u.Status,
                
            }).ToListAsync();
        }
        public async Task RegisterUserAsync(RegisterUserDTO register)
        {
            if(_Usercontext.IsAdmin==false)
            {
                throw new UnauthorizedAccessException("Only Admin can register new users.");
            }
           User newuser = new User()
           {
               FirstName = register.FirstName,
               LastName = register.LastName,
               DateAdded =DateTime.UtcNow,
               Email = register.Email,
               EmailConfirmed = true,
               UserName = register.Email,
               PhoneNumber = register.PhoneName,
               Status = IdentityStatus.Active,
               UserAdded ="Admin"

           };
           var result = await _userManager.CreateAsync(newuser, register.Password);
           if (!result.Succeeded)
            {
                var errors = string.Join(" User Creation Error: ", result.Errors.Select(e => e.Description));
                throw new InvalidOperationException($"Failed to create user: {errors}");
            }
            if (!string.IsNullOrEmpty(register.Role))
            {
                await _userManager.AddToRoleAsync(newuser, register.Role);
            }
        }
          public async Task<bool> LoginAsync(LoginDTO dto)
            {
            //      // Load default roles if no roles exist
            // if (!await _roleManager.Roles.AnyAsync())
            // {
            //     await _roleManager.CreateAsync(new IdentityRole<int> { Name = UserRole.Admin.ToString() });
            //     await _roleManager.CreateAsync(new IdentityRole<int> { Name = UserRole.Customer.ToString() });
            // }


            // // Load Sample data if no users exist
            // var AdminUser = new User()
            // {
            //     FirstName = "Admin",
            //     LastName = "User",
            //     Email = "admin@example.com",
            //     PhoneNumber = "1234567890",
            //     UserName = "admin@example.com",
            //     EmailConfirmed = true,
            // };

            // var existing = await _userManager.FindByEmailAsync(AdminUser.Email);
            // if (existing == null)
            // {
            //     await _userManager.CreateAsync(AdminUser, "Admin@123");
            // }

            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user == null)
            {
                return false;
            }

            var result = await _signInManager.PasswordSignInAsync(
                user.UserName ?? dto.Email,
                dto.Password,
                dto.RememberMe,
                lockoutOnFailure: true
            );

            return result.Succeeded;
            }
        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}