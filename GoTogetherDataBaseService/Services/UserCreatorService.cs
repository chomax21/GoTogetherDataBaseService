using Go;
using GoTogetherDataBaseService.Data.Models;
using GoTogetherDataBaseService.Services;
using Grpc.Core;

namespace GoTogetherAppMain.Services
{
    public class UserCreatorService : UserCreator.UserCreatorBase
    {
        private readonly PersonCreator _creator;

        public UserCreatorService(PersonCreator personCreator)
        {
               _creator = personCreator;
        }
        public async override Task<GoResponce> UserCreate(GoRequest request, ServerCallContext? context)
        {
            User user = new();
            user.Name = request.Name;
            user.Email = request.Email;
            user.Age = request.Age;
            var result = await _creator.CreateUserAsync(user);
            if (result)
                return new GoResponce() { Name = request.Name, Email = request.Email, Done = true };
            return new GoResponce() { Name = request.Name, Email = request.Email, Done = false };
        } 
    }
}
