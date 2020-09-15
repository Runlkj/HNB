using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ClinicNB.Authorization.Roles;
using ClinicNB.Authorization.Users;
using ClinicNB.MultiTenancy;
using ClinicNB.Entitys;

namespace ClinicNB.EntityFrameworkCore
{
    public class ClinicNBDbContext : AbpZeroDbContext<Tenant, Role, User, ClinicNBDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ClinicNBDbContext(DbContextOptions<ClinicNBDbContext> options)
            : base(options)
        {
        }
        public DbSet<AA> AA { get; set; }
        public DbSet<JobInfo> JobInfo { get; set; }
        public DbSet<JobRole> JobRole { get; set; }
        public DbSet<RoleInfo> RoleInfo { get; set; }
    }
}
