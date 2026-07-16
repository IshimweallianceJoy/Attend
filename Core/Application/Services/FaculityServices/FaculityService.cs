using Domain.Entities;
using Application.Interfaces;
namespace Application.Services.FaculityServices
{
    public class FaculityService:IFaculityService
    {
         private readonly IFaculity _faculity;

        public FaculityService(IFaculity faculities)
        {
            _faculity=faculities;
        }
        public List<Faculity> GetFaculities()
        {
            return _faculity.GetFaculities();
        }
    }
}