using Api.DTOs;
using Api.Models;

namespace Api.Interfaces
{
    public interface IUserRepository
    {
        Task<User> CreateUser(UserDTO user);
        Task<User> UpdateUser(int id, UserDTO user);
        void DeleteUser(int id);
        Task<User> GetUser(int id);
    }
}
