using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using CampTiger.Models;
using CampTiger.Data;

namespace CampTiger.Data {
  public class DbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext> {
    public ApplicationDbContext CreateDbContext(string[] args) {
      var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
      var connStr = ConfigurationHelper.GetCurrentSettings("ConnectionStrings:DefaultConnection");
      optionsBuilder.UseMySql(connStr);
      return new ApplicationDbContext(optionsBuilder.Options);
    }
  }
}