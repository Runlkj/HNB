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
        public DbSet<CaseInfo> CaseInfo { get; set; }
        public DbSet<ChineseInfo> ChineseInfo { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<PinInfo> PinInfo { get; set; }
        public DbSet<MestInfo> MestInfo { get; set; }
        public DbSet<GetMoney> GetMoney { get; set; }
        public DbSet<OrderType> OrderType { get; set; }
        public DbSet<DeptInfo> DeptInfo { get; set; }
        public DbSet<JobInfo> JobInfo { get; set; }
        public DbSet<JobRole> JobRole { get; set; }
        public DbSet<RoleInfo> RoleInfo { get; set; }
    }
}
