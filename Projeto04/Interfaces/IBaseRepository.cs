using Projeto04.Entities.Projeto04.Entities;

namespace Projeto04.Interfaces
{
    internal interface IbaseRepository<T>
    {
        void Add(T obg);
        void Update(T obj);
        void Delete(T obj);
        List<Empresa> GetAll();
        T? GetById(Guid id);
    }
}
