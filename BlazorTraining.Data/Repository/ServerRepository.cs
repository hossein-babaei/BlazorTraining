using BlazorTraining.Data.Context;
using BlazorTraining.Domain.Interfaces;
using BlazorTraining.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorTraining.Data.Repository
{
    public class ServerRepository : IServerRepository
    {
        private readonly ApplicationDbContext db;

        public ServerRepository(ApplicationDbContext context) => db = context;

        public IQueryable<Server> Query()
        {
            return db.Server.AsQueryable();
        }

        public void Create(Server obj)
        {
            db.Add(obj);
        }

        public void Delete(Server obj)
        {
            db.Remove(obj);
        }

        public async Task<Server> Get(int id)
        {
            return await db.Server.FirstOrDefaultAsync(a => a.Id.Equals(id));
        }

        public async Task<Server> Get(string id)
        {
            return await db.Server.FirstOrDefaultAsync(a => a.RowId.Equals(id));
        }

        public async Task<int> Save()
        {
            return await db.SaveChangesAsync();
        }

        public void Update(Server obj)
        {
            db.Server.Update(obj);
        }

        public async Task<List<Server>> GetAll()
        {
            return await db.Server.AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
        }
    }
}
