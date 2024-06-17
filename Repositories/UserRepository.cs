using Api.Interfaces;
using Api.Models;

namespace Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        // Injetar dependência do Banco de dados
        public UserRepository()
        {
        }

        public void CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(int id, User user)
        {
            throw new NotImplementedException();
        }
    }
}
