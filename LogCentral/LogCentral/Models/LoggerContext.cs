using LogCentral.Models;
using Microsoft.EntityFrameworkCore;

namespace LoggerCentral.Models
{
    public class LoggerContext : DbContext
    {
        public LoggerContext(DbContextOptions<LoggerContext> options)
            : base(options)
        {
        }

        public DbSet<LogEntry> LogEntries { get; set; }
    }
}