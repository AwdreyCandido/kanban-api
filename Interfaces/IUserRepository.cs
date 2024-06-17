using Api.Models;

namespace Api.Interfaces
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        void UpdateUser(int id, User user);
        void DeleteUser(int id);
        Task<User> GetUser(int id);
    }
}
