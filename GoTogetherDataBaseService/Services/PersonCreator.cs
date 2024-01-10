using GoTogetherDataBaseService.Data.AppContext;
using GoTogetherDataBaseService.Data.Models;
using GoTogetherDataBaseService.Exсeptions;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GoTogetherDataBaseService.Services
{
    public class PersonCreator
    {
        private readonly GoTogetherContext _context;

        public PersonCreator(GoTogetherContext context)
        {
            _context = context;
        }
        public async Task<User> GetUserAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null) return user;
            throw new NotFoundUserException("Пользователь с идентификатором {0} не найден!", id);
        }
        public async Task<bool> DeleteUserAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user!);
                await _context.SaveChangesAsync();
                return true;
            }
            throw new NotFoundUserException("Пользователь с идентификатором {0} не найден!", id);
        }
        public async Task<bool> CreateUserAsync(User user)
        {
            var usersInBase = _context.Users.FirstOrDefault(x => x.Email == user.Email);
            //var usersInBase1 = _context.Users.Include(x => x.Email);
            if (usersInBase != null)
            {
                return false;
            }
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            var usersInBase = await _context.Users.FindAsync(user.Id);
            if (usersInBase != null)
            {
                await Task.Run(() =>
                {
                    //_context.Update(user);
                    _context.Entry(user).State = EntityState.Modified;
                    return true;
                });
            }
            throw new NotFoundUserException("Пользователь с идентификатором {0} не найден!", user.Id);
        }

        
    }
}
