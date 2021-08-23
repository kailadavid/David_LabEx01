using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using David_LabEx01.Authorization.Roles;
using David_LabEx01.Authorization.Users;
using David_LabEx01.MultiTenancy;

namespace David_LabEx01.EntityFrameworkCore
{
    public class David_LabEx01DbContext : AbpZeroDbContext<Tenant, Role, User, David_LabEx01DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public David_LabEx01DbContext(DbContextOptions<David_LabEx01DbContext> options)
            : base(options)
        {
        }
    }
}
