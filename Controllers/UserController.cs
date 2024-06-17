using Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class UserController : BaseController
    {
        
        [HttpGet("{id}")]
        public void GetUser() { }

        [HttpPost]
        public void CreateUser() { }

        [HttpPut("{id}")]
        public void UpdateUser() { }

        [HttpDelete("{id}")]
        public void DeleteUser() { }

    }
}
