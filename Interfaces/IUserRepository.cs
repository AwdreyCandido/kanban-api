using Api.Models;

namespace Api.Interfaces
{
    public interface IUserRepository
    {
        public void CreateUser(User user);
        public void UpdateUser(int id, User user);
        public void DeleteUser(int id);
        public User GetUser(int id);
    }
}
