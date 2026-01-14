using A_Visit_To_Georgia.Models;

namespace A_Visit_To_Georgia.Repositories
{
    public interface IMenuItemRepository
    {
        IEnumerable<MenuItem> GetAll();
        MenuItem? GetById(int id);
        void Add(MenuItem item);
        void Update(MenuItem item);
        void Delete(MenuItem item);
        void Save();
    }
}