using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using livraria.Context;
using Microsoft.EntityFrameworkCore;

namespace livraria.Services
{
    public static class DatabaseManagementService
    {
        public static void MigrationInitialization(this IApplicationBuilder app)
		{
			using (var serviceScope = app.ApplicationServices.CreateScope())
			{
				var serviceDb = serviceScope.ServiceProvider
					.GetService<AppDbContext>();

				serviceDb.Database.Migrate();
			}
		}
    }
}