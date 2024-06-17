using Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class MissionController : BaseController
    {
        [HttpPost("create")]
        public void CreateMission() { }

        [HttpPut("update/{id}")]
        public void UpdateMission() { }

        [HttpDelete("delete/{id}")]
        public void DeleteMission() { }

        [HttpGet("{id}")]
        public void GetMission() { }

        [HttpGet]
        public void GetAllMissions() { }
    }
}
