using DotLearn.Models;

namespace DotLearn.Interfaces
{
    public interface IUser
    {
        Task<User> ValidateUser(string username, string password);
        //Task<IEnumerable<User>> GetAllUsersAsync();
        //Task AddUserAsync(User user)
    }
}
