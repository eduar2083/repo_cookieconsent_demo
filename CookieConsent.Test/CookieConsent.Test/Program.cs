WebApplication.CreateBuilder(args)
    .ConfigureWebAppServices()
    .ConfigureWebApppMiddlewares()
    .Run();