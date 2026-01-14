using A_Visit_To_Georgia.Models;

namespace A_Visit_To_Georgia.Repositories
{
    public interface IBokningRepository
    {
        IEnumerable<Bokningbord> GetAll();
        Bokningbord? GetById(int id);
        void Add(Bokningbord bokning);
        void Update(Bokningbord bokning);
        void Delete(Bokningbord bokning);
        void Save();
    }
}
