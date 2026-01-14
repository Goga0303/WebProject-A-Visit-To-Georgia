using A_Visit_To_Georgia.Models;
using Microsoft.EntityFrameworkCore;

namespace A_Visit_To_Georgia.Repositories
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly BokningbordDbContext _context;

        public MenuItemRepository(BokningbordDbContext context)
        {
            _context = context;
        }

        public IEnumerable<MenuItem> GetAll()
        {
            return _context.MenuItems
                .AsNoTracking()
                .OrderBy(m => m.Kategori)
                .ThenBy(m => m.Namn)
                .ToList();
        }

        public MenuItem? GetById(int id)
        {
            return _context.MenuItems.Find(id);
        }

        public void Add(MenuItem item)
        {
            _context.MenuItems.Add(item);
        }

        public void Update(MenuItem item)
        {
            _context.MenuItems.Update(item);
        }

        public void Delete(MenuItem item)
        {
            _context.MenuItems.Remove(item);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}