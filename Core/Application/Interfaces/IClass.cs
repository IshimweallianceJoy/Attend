using Domain.Entities;
namespace Application.Interfaces 
{
    public interface IClass
    {
        public List<Classs>GetClassses();
        public void AddClass(Classs classs);
        public Classs? GetClasssById(int id);
    }
}












