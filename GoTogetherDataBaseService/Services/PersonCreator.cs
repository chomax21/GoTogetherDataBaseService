using GoTogetherDataBaseService.Data.AppContext;
using GoTogetherDataBaseService.Data.Models;
using GoTogetherDataBaseService.Exсeptions;
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
        public User GetUser(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);
            if (user != null) return user!;
            throw new NotFoundUserException("Пользователь с идентификатором не найден!", id);
        }
        public bool DeleteUser(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                _context.Users.Remove(user!);
                _context.SaveChanges();
                return true;
            }
            throw new NotFoundUserException("Пользователь с идентификатором не найден!", id);
        }
        public async Task<bool> CreateUser(User user)
        {
            var usersInBase = _context.Users.FirstOrDefault(x => x.Email == user.Email);
            if (usersInBase != null)
            {
                return false;
            }
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateUser(User user)
        {
            var usersInBase = _context.Users.FirstOrDefault(x => x.Id == user.Id);
            if (usersInBase != null)
            {
                await Task.Run(() =>
                {
                    _context.Update(user);
                    _context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    return true;
                });
            }
            throw new NotFoundUserException("Пользователь с идентификатором не найден!", user.Id);
        }
    }
}
