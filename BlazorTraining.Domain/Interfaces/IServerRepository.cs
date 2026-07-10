using BlazorTraining.Domain.Models;
using BlazorTraining.Domain.ViewModels;

namespace BlazorTraining.Domain.Interfaces
{
    public interface IServerRepository
    {
        Task<Server> Get(int id);
        Task<Server> Get(string id);
        Task<List<Server>> GetAll();
        Task<List<Server>> GetAll(string regionName);
        Task<List<string>> GetServerRegionNames();
        IQueryable<Server> Query();
        void Update(Server obj);
        void Create(CreateServerViewModel obj);
        void Delete(Server obj);
        Task<int> Save();
    }
}
