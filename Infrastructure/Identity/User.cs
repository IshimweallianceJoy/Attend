using Domain.ValueObject;
using Microsoft.AspNetCore.Identity;
namespace Infrastructure.Identity
{
    public class User:IdentityUser<int>
    {
        public string FirstName {get;set;}
        public string LastName{get;set;}

        public DateTime DateAdded{get;set;}
        public string UserAdded{get;set;}
        public IdentityStatus Status{get;set;}

    }
}