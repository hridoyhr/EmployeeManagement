using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementPractice1.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                   new Employee
                   {
                       Id = 4,
                       Name = "Mark",
                       Department = Dept.QA,
                       Email = "mark@gamil.com"
                   }
                   
               );
        }
    }
}
