using Microsoft.EntityFrameworkCore;
using OOPS.Model.CompanyModels;
using OOPS.Model.EmployeeModel;
using OOPS.Model.ProjectBaseModel;
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

        public DbSet<User> User { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserCompany> userCompanies { get; set; }

    }
}
