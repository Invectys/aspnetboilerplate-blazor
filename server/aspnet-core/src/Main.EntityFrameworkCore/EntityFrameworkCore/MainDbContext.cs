using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Main.Authorization.Roles;
using Main.Authorization.Users;
using Main.MultiTenancy;

namespace Main.EntityFrameworkCore
{
    public class MainDbContext : AbpZeroDbContext<Tenant, Role, User, MainDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MainDbContext(DbContextOptions<MainDbContext> options)
            : base(options)
        {
        }
    }
}
