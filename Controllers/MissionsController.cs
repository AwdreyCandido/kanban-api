using Api.DTOs;
using Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class MissionsController : BaseController
    {
        [HttpPost("create")]
        public ActionResult CreateMission(MissionDTO mission) { 
            return Ok(mission);
        }

        [HttpPut("update/{id}")]
        public ActionResult UpdateMission([FromRoute] int id) {
            return Ok(id);
        }

        [HttpDelete("delete/{id}")]
        public void DeleteMission() { }

        [HttpGet("{id}")]
        public void GetMission() { }

        [HttpGet]
        public void GetAllMissions() { }
    }
}
