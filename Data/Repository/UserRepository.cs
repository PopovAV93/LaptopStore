using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaptopStore.Data.Interfaces;
using LaptopStore.Data.Models;
using LaptopStore.Data.Response;
using LaptopStore.ViewModels;

namespace LaptopStore.Data.Repository
{
    public class UserRepository : IUsers
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

        public async Task Delete(User user)
        {
            _db.Users.Remove(user);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            User user = _db.Users.Single(x => x.id == id);
            _db.Users.Remove(user);
            await _db.SaveChangesAsync();
        }

        public async Task Create(User user)
        {
            await _db.Users.AddAsync(user);
            await _db.SaveChangesAsync();
        }

        public async Task<User> Update(User user)
        {
            _db.Users.Update(user);
            await _db.SaveChangesAsync();

            return user;
        }
    }
}