using Microsoft.EntityFrameworkCore;
using OOPS.Model.CompanyModels;
using OOPS.Model.EmployeeModel;
using OOPS.Model.ProjectBaseModel;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DAL
{
    public class OOPSEntites : DbContext
    {
        public OOPSEntites(DbContextOptions<OOPSEntites> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }

        #region StaticEntities
        public DbSet<AccessType> AccessTypes { get; set; }
        public DbSet<BankAccountType> BankAccountTypes { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<ContractType> ContractTypes { get; set; }
        public DbSet<DisabilitySituation> DisabilitySituations { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<EducationStatus> EducationStatuses { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<PermitType> PermitTypes { get; set; }
        public DbSet<VisaType> VisaTypes { get; set; }
        #endregion





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

    }
}
