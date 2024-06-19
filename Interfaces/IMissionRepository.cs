using Api.DTOs;
using Api.Models;

namespace Api.Interfaces
{
    public interface IMissionRepository
    {
        Task CreateMission(MissionDTO task);
        Task UpdateMission(int id, MissionDTO task);
        Task DeleteMission(int id);
        Task<Mission> GetMission(int id);

        // Task<List<MissionDTO>> GetAllMissions();
    }
}
