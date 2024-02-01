using Go;
using GoTogetherAppMain.Models;
using Grpc.Core;
using Grpc.Net.Client;

namespace GoTogetherAppMain.Services
{
    public class UserCreatorService
    {
        public async Task<GoResponce> CreateUserAsync(UserViewModel user)
        {
            if (user is null)
                throw new ArgumentNullException(nameof(user));

            using var channel = GrpcChannel.ForAddress("https://localhost:7056");
            var client = new UserCreator.UserCreatorClient(channel);
            var userResponce = await client.UserCreateAsync(new GoRequest { Name = user.Name, Email = user.Email});

            if (userResponce.Done)
                return userResponce;
            else
                throw new RpcException(new Status(StatusCode.DataLoss, "gRPC not found message"));
        }
    }
}
