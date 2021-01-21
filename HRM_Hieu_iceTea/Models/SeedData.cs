using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM_Hieu_iceTea.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employees()
                    {
                        Name = "Nguyễn Đình Hiếu",
                        Project = "A",
                        Phone = "0",
                        Address = "A",
                    },
                    new Employees()
                    {
                        Name = "Thanh Tú",
                        Project = "B",
                        Phone = "1",
                        Address = "B",
                    },
                    new Employees()
                    {
                        Name = "Quang Huy",
                        Project = "C",
                        Phone = "2",
                        Address = "C",
                    },
                    new Employees()
                    {
                        Name = "Phạm Tuân",
                        Project = "D",
                        Phone = "3",
                        Address = "D",
                    },
                    new Employees()
                    {
                        Name = "Nguyễn Văn Z",
                        Project = "E",
                        Phone = "4",
                        Address = "E",
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
