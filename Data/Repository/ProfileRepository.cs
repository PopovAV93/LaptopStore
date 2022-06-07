using System.Linq;
using System.Threading.Tasks;
using LaptopStore.Data.Interfaces;
using LaptopStore.Data.Models;

namespace LaptopStore.Data.Repository
{
    public class ProfileRepository : IBaseRepository<Profile>
    {
        private readonly AppDBContent _db;

        public ProfileRepository(AppDBContent db)
        {
            _db = db;
        }

        public async Task Create(Profile profile)
        {
            await _db.Profiles.AddAsync(profile);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Profile> GetAll()
        {
            return _db.Profiles;
        }
        public Task Delete(Profile entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<Profile> Update(Profile entity)
        {
            throw new System.NotImplementedException();
        }
    }
}