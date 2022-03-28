using Microsoft.EntityFrameworkCore;

namespace Concentrador_Scanntech_Repository.Context
{
    public class DbContextMigration
    {
        public static void EfMigration(MySqlDbContext _context) => _context.Database.Migrate();
    }
}
