using Api.Data;
using Api.DTOs;
using Api.Enums;
using Api.Interfaces;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public class MissionRepository : IMissionRepository
    {

        private readonly AppDbContext _context;
    
        public MissionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Mission> GetMission(int id)
        {
            var mission  = await _context.Missions.FindAsync(id);

            if(mission == null)
            {
                throw new KeyNotFoundException("Mission doesn't exist!");
            }

            return mission;
        }

        public async Task CreateMission(MissionDTO mission)
        {
            // MORE VALIDATION
            var newMission = new Mission
            {
                Title = mission.Title,
                Description = mission.Description,
                UserId = mission.UserId,
                Status = (Status)mission.Status,
            };

            _context.Missions.Add(newMission);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMission(int id, MissionDTO mission)
        {
            var newMission = await _context.Missions.FindAsync(id);

            if(newMission != null)
            {
                throw new KeyNotFoundException("Mission not found!");
            }

            newMission.Title = mission.Title;
            newMission.Description = mission.Description;
            newMission.Status = (Status)mission.Status;
            newMission.UpdatedAt = DateTime.Now;


            // _context.Missions.Entry(newMission).State = EntityState.Modified;
            _context.Missions.Update(newMission);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteMission(int id)
        {
            var mission = await _context.Missions.FindAsync(id);

            if (mission == null)
            {
                throw new KeyNotFoundException("Mission not found!");
            }

            _context.Missions.Remove(mission);
            await _context.SaveChangesAsync();
        }

    }
}
