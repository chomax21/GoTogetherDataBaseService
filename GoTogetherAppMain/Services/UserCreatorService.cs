using Go;
using Grpc.Core;

namespace GoTogetherAppMain.Services
{
    public class UserCreatorService : UserCreator.UserCreatorBase
    {
        public override Task<GoResponce> UserCreate(GoRequest request, ServerCallContext context = default)
        {
            return Task.FromResult(new GoResponce() { Name = request.Name, Email = request.Email});
        } 
    }
}
