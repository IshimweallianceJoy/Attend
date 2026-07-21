using Domain.Entities;
namespace Application.Services.ClassServices
{
    public interface IClassService
    {
        public List<Classs>GetClassses();
        public void AddClass(Classs classs);
        public Classs? GetClasssById(int id);
        public void UpdateClass(Classs classs);
    }
}