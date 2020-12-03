using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace HummanResourcesManagement.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            EmployeeDBContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<EmployeeDBContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee
                    {
                        Name = "Mai Xuân Lập",
                        Date = "15-04-2001",
                        Address = "Ha noi",
                        Img = "https://www.elleman.vn/wp-content/uploads/2019/10/29/sinh-nhat-tim-cook-7.jpg"
                    },
                    new Employee
                    {
                        Name = "NGUYỄN VĂN A",
                        Date = "05-02-1985",
                        Address = "BẮC NINH",
                        Img = "https://www.elleman.vn/wp-content/uploads/2019/10/29/sinh-nhat-tim-cook-7.jpg"
                    },
                    new Employee
                    {
                        Name = "NGYỄN VĂN B",
                        Date = "24-06-1987",
                        Address = "THANH HOA",
                        Img = "https://www.elleman.vn/wp-content/uploads/2019/10/29/sinh-nhat-tim-cook-7.jpg"
                    }
                    ,
                    new Employee
                    {
                        Name = "NGUYỄN VĂN C",
                        Date = "2-5-1955",
                        Address = "HỒ CHÍ MINH",
                        Img = "https://www.elleman.vn/wp-content/uploads/2019/10/29/sinh-nhat-tim-cook-7.jpg"
                    },
                    new Employee
                    {
                        Name = "NGYỄN VĂN D",
                        Date = "14-4-2001",
                        Address = "THANH HOA",
                        Img = "https://www.elleman.vn/wp-content/uploads/2019/10/29/sinh-nhat-tim-cook-7.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
