using GoTogetherDataBaseService.Data.Models;

namespace GoTogetherDataBaseService.Interfaces
{
    public interface IPersonCreator<T>
    {
        Task<T> GetUserAsync(int id);
        public Task<bool> DeleteUserAsync(int id);
        public Task<bool> CreateUserAsync(T user);
        public Task<bool> UpdateUserAsync(T user);

    }
}
