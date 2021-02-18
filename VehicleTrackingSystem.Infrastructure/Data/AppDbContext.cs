using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Infrastructure.Identity;
using VehicleTrackingSystem.Domain.Common;
using VehicleTrackingSystem.Application.Common.Models;
using VehicleTrackingSystem.Domain.Entities;

namespace VehicleTrackingSystem.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>,
           UserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public AppDbContext(DbContextOptions<AppDbContext> options,
            ICurrentUserService currentUserService,
            IDateTime dateTime) : base(options)
        {
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }


        public DbSet<RequestLoggerEntity> LoggerEntities { get; set; }
        public DbSet<UrlAction> UrlActions { get; set; }

        //public DbSet<Customer> Customer { get; set; }
        //public DbSet<Device> Device { get; set; }
        //public DbSet<Driver> Driver { get; set; }
        //public DbSet<LogHistory> LogHistory { get; set; }
        //public DbSet<Payment> Payment { get; set; }
        //public DbSet<TripRequest> Trip { get; set; }
        //public DbSet<TripHistory> TripHistory { get; set; }
        public DbSet<Vehicle> VEHICLE { get; set; }
        public DbSet<Expense> EXPENSE { get; set; }
        public DbSet<ExpenseType> L_EXPENSE_TYPE { get; set; }
        public DbSet<ExpenseSubType> L_EXPENSE_SUB_TYPE { get; set; }
        public DbSet<Owner> OWNER { get; set; }
        public DbSet<VehicleLocation> VEHICLE_LOCATION { get; set; }
        public DbSet<BillPayment> BILL_PAYMENT { get; set; }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.CreateDate = _dateTime.Now;
                        break;

                    case EntityState.Deleted:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.CreateDate = _dateTime.Now;
                        break;

                    case EntityState.Unchanged:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.CreateDate = _dateTime.Now;
                        break;

                    case EntityState.Detached:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.CreateDate = _dateTime.Now;
                        break;

                    case EntityState.Modified:
                        entry.Entity.UpdateBy = _currentUserService.UserId;
                        entry.Entity.UpdateDate = _dateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);

            builder.Entity<UserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });
        }



    }
}
