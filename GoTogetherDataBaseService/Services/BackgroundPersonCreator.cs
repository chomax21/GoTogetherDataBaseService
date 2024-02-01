using GoTogetherAppMain.Services;
using GoTogetherDataBaseService.Data.AppContext;

namespace GoTogetherDataBaseService.Services
{
    //public class BackgroundPersonCreator : BackgroundService
    //{
    //    private readonly ILogger _logger;
    //    private readonly GoTogetherContext _context;
    //    private readonly IServiceProvider _provider;

    //    public BackgroundPersonCreator(ILogger logger,
    //                                   GoTogetherContext context,
    //                                   IServiceProvider provider)
    //    {
    //          _logger = logger;
    //          _context = context;
    //         _provider = provider;
    //    }
    //    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    //    {
    //        while (!stoppingToken.IsCancellationRequested)
    //        {
    //            using (IServiceScope scope = _provider.CreateScope())
    //            {
    //                //var scopedProvider = scope.ServiceProvider;
    //                var personCreator = scope.ServiceProvider.GetRequiredService<UserCreatorService>();
    //                personCreator.UserCreate();


    //            }
                

    //        }
    //    }
    //}
}
 