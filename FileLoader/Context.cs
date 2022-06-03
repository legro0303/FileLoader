using FileLoader.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.IO;

namespace FileLoader
{
    public class Context : DbContext
    {
        public DbSet<FileModel> Files { get; set; }
        public Context(DbContextOptions options):base(options) {
            Database.EnsureCreated();
        }
    }
}
