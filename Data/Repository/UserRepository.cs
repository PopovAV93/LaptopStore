using System.Linq;
using System.Threading.Tasks;
using LaptopStore.Data.Interfaces;
using LaptopStore.Data.Models;

namespace LaptopStore.Data.Repository
{
    public class UserRepository : IBaseRepository<User>
    {
        private readonly AppDBContent _db;

        public UserRepository(AppDBContent db)
        {
            _db = db;
        }

        public IQueryable<User> GetAll()
        {
            return _db.Users;
        }

        public async Task Delete(User entity)
        {
            _db.Users.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Create(User entity)
        {
            await _db.Users.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<User> Update(User entity)
        {
            _db.Users.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}