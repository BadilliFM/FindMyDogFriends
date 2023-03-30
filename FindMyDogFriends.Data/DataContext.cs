using FindMyDogFriends.Data.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyDogFriends.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options) { }
    DbSet<Dogpark> dogparks { get; set; }
    DbSet<User> users { get; set; }
    DbSet<Dog> dogs { get; set; }
    DbSet<Account> Acounts { get; set; }
    DbSet<SuperUser> superUsers { get; set; }
    DbSet<Technician> Technicians { get; set; }
}
