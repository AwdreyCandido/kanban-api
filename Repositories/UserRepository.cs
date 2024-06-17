using Api.Data;
using Api.Interfaces;
using Api.Models;

namespace Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async void CreateUser(User user)
        {
           // user = new User { Id = 1, Name = "Nome", Email = "email@email.com", Missions = []};
            
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(int id, User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(int id)
        {
            throw new NotImplementedException();
        }

    }
}
