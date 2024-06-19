using Api.DTOs;
using Api.Interfaces;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class MissionsController : BaseController
    {
        private readonly IMissionRepository _missionRepository;

        public MissionsController(IMissionRepository missionRepository)
        {
            _missionRepository = missionRepository;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateMission([FromBody] MissionDTO mission)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _missionRepository.CreateMission(mission);
                return Ok(mission);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateMission([FromRoute] int id, MissionDTO mission)
        {
            try
            {
                _missionRepository.UpdateMission(id, mission);
                return Ok(mission);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteMission([FromRoute] int id)
        {
            try
            {
                _missionRepository.DeleteMission(id);
                return Ok($"Deleted mission of id {id}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Mission>> GetMission([FromRoute] int id)
        {

            try
            {
                var mission = await _missionRepository.GetMission(id);
                return Ok(mission);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
