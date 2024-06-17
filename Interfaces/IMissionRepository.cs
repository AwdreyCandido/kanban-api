using Api.Models;

namespace Api.Interfaces
{
    public interface IMissionRepository
    {
        void CreateMission(Mission task);
        void UpdateMission(int id, Mission task);
        void DeleteMission(int id);
        Task<Mission> GetMission(int id);
        Task<List<Mission>> GetAllMissions();
    }
}
