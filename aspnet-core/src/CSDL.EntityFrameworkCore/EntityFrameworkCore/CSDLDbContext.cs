using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CSDL.Authorization.Roles;
using CSDL.Authorization.Users;
using CSDL.MultiTenancy;

namespace CSDL.EntityFrameworkCore
{
    public class CSDLDbContext : AbpZeroDbContext<Tenant, Role, User, CSDLDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CSDLDbContext(DbContextOptions<CSDLDbContext> options)
            : base(options)
        {
        }
    }
}
