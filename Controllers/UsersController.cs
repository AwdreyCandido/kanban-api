using Api.DTOs;
using Api.Interfaces;
using Api.Models;
using Api.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class UsersController : BaseController
    {
        private readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser([FromRoute] int id) {
           try 
           {
                var user = await _userRepository.GetUser(id);
                return Ok(user);
           } 
           catch (Exception ex)
           {
                return BadRequest(ex.Message);
           }
        }

        [HttpPost("create")]
        public async Task<ActionResult> CreateUser(UserDTO user) {
            try 
            { 
                var createdUser = await _userRepository.CreateUser(user);
                return Ok(createdUser);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("update/{id}")]
        public async Task<ActionResult> UpdateUser([FromRoute] int id, UserDTO user) {
            try
            {
                var updatedUser = await _userRepository.UpdateUser(id, user);
                return Ok(updatedUser);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("delete/{id}")]
        public void DeleteUser([FromRoute] int id) { 
            _userRepository.DeleteUser(id);
        }

    }
}
