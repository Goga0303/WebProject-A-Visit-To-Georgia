using A_Visit_To_Georgia.Models;
using Microsoft.EntityFrameworkCore;

namespace A_Visit_To_Georgia.Repositories
{
    public class BokningRepository : IBokningRepository
    {
        private readonly BokningbordDbContext _context;

        public BokningRepository(BokningbordDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Bokningbord> GetAll()
        {
            return _context.Bokningar
                .AsNoTracking()
                .OrderByDescending(b => b.Id)
                .ToList();
        }

        public Bokningbord? GetById(int id)
        {
            return _context.Bokningar.Find(id);
        }

        public void Add(Bokningbord bokning)
        {
            _context.Bokningar.Add(bokning);
        }

        public void Update(Bokningbord bokning)
        {
            _context.Bokningar.Update(bokning);
        }

        public void Delete(Bokningbord bokning)
        {
            _context.Bokningar.Remove(bokning);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}