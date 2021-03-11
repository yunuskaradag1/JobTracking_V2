using JobTracking.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Data
{
  public class MainDbContext : IdentityDbContext<JobTrackingUser, JobTrackingRole, int>
    {
        public MainDbContext(DbContextOptions options)
           : base(options)
        {

        }





        public DbSet<User> User { get; set; }
        public DbSet<Activity> Activity { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Claim> Claim { get; set; }
        public DbSet<ClaimGroup> ClaimGroup { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyDepartment> CompanyDepartment { get; set; }
        public DbSet<CompanyUser> CompanyUser { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Note> Note { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<ProjectVersion> ProjectVersion { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RoleClaim> RoleClaim { get; set; }
        public DbSet<Shift> Shift { get; set; }
        public DbSet<Task> Task { get; set; }
        public DbSet<TaskDetail> TaskDetail { get; set; }
        public DbSet<TaskStatus> TaskStatus { get; set; }
        public DbSet<ToDo> ToDo { get; set; }
        public DbSet<Town> Town { get; set; }
        public DbSet<UserDocument> UserDocument { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<WorkTypeDefinition> WorkTypeDefinition { get; set; }


    }
}
