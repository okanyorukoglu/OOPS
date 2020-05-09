using Microsoft.EntityFrameworkCore;
using OOPS.Model.CompanyModels;
using OOPS.Model.EmployeeModel;
using OOPS.Model.ProjectBaseModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOPS.DAL
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {         
            modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 1,
                Name = "Muharrem",
                Surname = "Kirkit",
                CompanyID = 1
            },
            new Employee
            {
                Id = 2,
                Name = "Can",
                Surname = "Sever",
                CompanyID = 1
            },
            new Employee
            {
                Id = 3,
                Name = "Semih",
                Surname = "Dinçay",
                CompanyID = 2
            },
            new Employee
            {
                Id = 4,
                Name = "Emre",
                Surname = "Darbeci",
                CompanyID = 2
            },
            new Employee
            {
                Id = 5,
                Name = "Hakan",
                Surname = "Mert",
                CompanyID = 1
            }
            );

            modelBuilder.Entity<Company>().HasData(
             new Company
             {
                 Id = 1,
                 CompanyName = "Adidas",

             },
            new Company
            {
                Id = 2,
                CompanyName = "Nike",

            }
             );

            modelBuilder.Entity<User>().HasData(
             new User
             {
                 Id = 2,
                 FullName = "Hakan Mert",
                 UserName = "hakanmert",
                 EMail = "hakanmert@gmail.com",
                 Password = "1234",
                 EmployeeId = 5

             },
            new User
            {
                Id = 3,
                FullName = "Can Sever",
                UserName = "cansever",
                EMail = "cansever@gmail.com",
                Password = "1234",
                EmployeeId = 2
            }
             );

            modelBuilder.Entity<UserCompany>().HasData(
             new UserCompany
             {
                 Id = 1,
                 UserId = 3,
                 CompanyId = 1,
                 RoleId = 1
             },
            new UserCompany
            {
                Id = 2,
                UserId = 2,
                CompanyId = 2,
                RoleId = 1
            }
             );

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    Name = "Admin"
                },
                new Role
                {
                    Id = 2,
                    Name = "Çalışan"
                }
                );
        }
    }
}
