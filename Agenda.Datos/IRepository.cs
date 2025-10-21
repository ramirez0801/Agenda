
namespace Agenda.Datos
{
    public interface IRepository<T>
    {
        void Add(T c);
        void Update(T c);
        void Delete(int id);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
