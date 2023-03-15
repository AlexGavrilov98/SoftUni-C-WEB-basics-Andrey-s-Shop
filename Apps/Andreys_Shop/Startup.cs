namespace Andreys.App
{
    using System.Collections.Generic;
    using Andreys.Data;
    using Andreys.Services;
    using SUS.HTTP;
    using SUS.MvcFramework;

    public class Startup : IMvcApplication
    {

        public void Configure(List<Route> routeTable)
        {
            using (var db = new AndreysDbContext())
            {
                db.Database.EnsureCreated();
            }
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.Add<IUsersService, UsersService>();
        }
    }
}
