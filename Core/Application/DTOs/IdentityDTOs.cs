using Domain.ValueObject;

namespace Application.DTOs
{
    public class GetUserDTO
    {
        public int Id{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public IdentityStatus Status{get;set;}
        public string Email {get;set;}
        public string UserName{get;set;}
        public string PhoneName{get;set;}
    }
    public class RegisterUserDTO
    {
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public string Email {get;set;}
        public string PhoneName{get;set;}
        public string Password{get;set;}
        public string Role{get;set;}
    }
    public class LoginDTO
    {
        public string Email{get;set;}
        public string Password{get;set;}
        public bool RememberMe{get;set;}

    }
}