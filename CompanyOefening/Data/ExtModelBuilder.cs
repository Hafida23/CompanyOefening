using CompanyOefening.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyOefening.Data
{
    public static class ExtModelBuilder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
               
                .HasData(new Department
                {
                    DepartmentID =1,
                    Name="IT",
                    
                },
                new Department
                {
                    DepartmentID = 2,
                    Name = "HR",

                },
                 new Department
                 {
                     DepartmentID = 3,
                     Name = "Marketing",

                 }
                );
            modelBuilder.Entity<Employee>()
                .HasData(new Employee
                {
                    EmployeeID = 1,
                    Name ="Kenan Kurda",
                    DepartmentId=1,
                    ProjectId=1,
                },
                new Employee
                {
                    EmployeeID = 2,
                    Name = "Peral De Smet",
                    DepartmentId=2,
                    ProjectId=2,
                }
                );
            modelBuilder.Entity<Project>()
                .HasData(new Project
                {
                    ProjectID = 1,
                    Name = ".Net Developer",
                },
                new Project
                {
                    ProjectID=2,
                    Name="Java Developer",
                }
                ); 

        }

    }
}
