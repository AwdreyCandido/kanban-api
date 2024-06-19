using Api.Data;
using Api.DTOs;
using Api.Interfaces;
using Api.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _context.Users
                .Include(u => u.Missions)
                .FirstOrDefaultAsync(u => u.Id == id);

            return user;
        }

        public async Task<User> CreateUser(UserDTO user)
        {
            // VALIDATION

            var newUser = new User
            {
                Name = user.Name,
                Email = user.Email
            };

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return newUser;
        }


        public async Task<User> UpdateUser(int id, UserDTO updateUser)
        {
            var user = await _context.Users.FindAsync(id);

            user.Name = updateUser.Name;
            user.Email = updateUser.Email;

            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return user;
        }


        public async void DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

    }
}
