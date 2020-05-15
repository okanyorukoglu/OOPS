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
                CompanyID = 1,
                Title="Dotnetci"
            },
            new Employee
            {
                Id = 2,
                Name = "Can",
                Surname = "Sever",
                CompanyID = 1,
                Title="Muhasebe"
            },
            new Employee
            {
                Id = 3,
                Name = "Semih",
                Surname = "Dinçay",
                CompanyID = 2,
                Title="Yazılım Geliştirme Elemanı"
            },
            new Employee
            {
                Id = 4,
                Name = "Emre",
                Surname = "Darbeci",
                CompanyID = 2,
                Title="Mühendis",
                UserID=4
            },
            new Employee
            {
                Id = 5,
                Name = "Hakan",
                Surname = "Mert",
                CompanyID = 1,
                Title = "Yönetici",
                UserID=2
            },
            new Employee
            {
                Id = 6,
                Name = "Aslı",
                Surname = "Koç",
                CompanyID = 1,
                Title = "Mühendis"
            },
            new Employee
            {
                Id = 7,
                Name = "Ayşe",
                Surname = "Koç",
                CompanyID = 2,
                Title = "çalışan",

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
                 UserName = "hakanmert",
                 EMail = "hakanmert@gmail.com",
                 Password = "1234",
                 RoleId = 1,
                 CompanyId=1,
                 
             },
            new User
            {
                Id = 3,
                UserName = "cansever",
                EMail = "cansever@gmail.com",
                Password = "1234",
                RoleId = 1,
                CompanyId=2

            },
            new User
            {
                Id = 4,
                UserName = "Emre",
                EMail = "emre@gmail.com",
                Password = "1234",
                RoleId = 2,
                CompanyId = 2

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
                    Name = "Employee"
                }
                );

        }
    }
}
