using Api.Interfaces;
using Api.Models;

namespace Api.Repositories
{
    public class MissionRepository : IMissionRepository
    {
        // Injetar dependência do Banco de dados
        public MissionRepository()
        {
        }

        public void CreateMission(Mission task)
        {
            throw new NotImplementedException();
        }

        public void DeleteMission(int id)
        {
            throw new NotImplementedException();
        }

        public List<Mission> GetAllMissions()
        {
            throw new NotImplementedException();
        }

        public Mission GetMission(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateMission(int id, Mission task)
        {
            throw new NotImplementedException();
        }
    }
}
