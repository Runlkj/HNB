﻿using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ClinicNB.Authorization.Roles;
using ClinicNB.Authorization.Users;
using ClinicNB.MultiTenancy;

namespace ClinicNB.EntityFrameworkCore
{
    public class ClinicNBDbContext : AbpZeroDbContext<Tenant, Role, User, ClinicNBDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ClinicNBDbContext(DbContextOptions<ClinicNBDbContext> options)
            : base(options)
        {
        }
    }
}
