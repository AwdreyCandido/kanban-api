using Api.Data;
using Api.Interfaces;
using Api.Models;

namespace Api.Repositories
{
    public class MissionRepository : IMissionRepository
    {

        private readonly AppDbContext _context;
    
        public MissionRepository(AppDbContext context)
        {
            _context = context;
        }

        public void CreateMission(Mission task)
        {
            throw new NotImplementedException();
        }

        public void UpdateMission(int id, Mission task)
        {
            throw new NotImplementedException();
        }

        public void DeleteMission(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Mission>> GetAllMissions()
        {
            throw new NotImplementedException();
        }

        public Task<Mission> GetMission(int id)
        {
            throw new NotImplementedException();
        }


    }
}
