using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudentRestApi.Models;

namespace StudentRestApi.Services
{
    public static class DatabaseManagementService 
    {
        public static void MigrationInitialization(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                serviceScope.ServiceProvider.GetService<StudentContext>().Database.Migrate();
            }
        }
    }
}