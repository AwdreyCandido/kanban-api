using Api.Models;

namespace Api.Interfaces
{
    public interface IMissionRepository
    {
        public void CreateMission(Mission task);
        public void UpdateMission(int id, Mission task);
        public void DeleteMission(int id);
        public Mission GetMission(int id);
        public List<Mission> GetAllMissions();
    }
}
