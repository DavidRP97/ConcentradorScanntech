using Microsoft.EntityFrameworkCore;

namespace Concentrador_Scanntech_Repository.Context
{
    public class DbContextMigration
    {
        public static void EfMigration(AppDbContext _context) => _context.Database.Migrate();
        //public static void EfMigration(AppDbContext _context) => _context.Database.GetService<IMigrator>().Migrate(SelectScripMigration.Migration());
    }
}
