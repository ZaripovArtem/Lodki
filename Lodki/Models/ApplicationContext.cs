using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lodki.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Production> Productions { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                modelBuilder.Entity<Client>().HasData(
                    new Client[]
                    {
                        new Client {Id = 1, Name = "Димон", Surname = "Валиев", Patronomic = "Скоречников" , Address = "Малышеского 59", Phone = "79393378499"}
                    });

                modelBuilder.Entity<Order>().HasData(
                    new Order[]
                    {
                        new Order {Id = 1, DatePlacement = DateTime.Now, DateExecution = DateTime.Now},
                        new Order {Id = 2, DatePlacement = DateTime.Now, DateExecution = DateTime.Now}
                    });

                modelBuilder.Entity<Employee>().HasData(
                    new Employee[]
                    {
                        new Employee {Id = 1, Name = "Димон", Surname = "Валиев", Patronomic = "Скоречников" , Post = "Cherkash", Phone = "79393378499"},
                        new Employee {Id = 2, Name = "Лимон", Surname = "Малиев", Patronomic = "Коречников" , Post = "Cherkash", Phone = "79393378499"},
                        new Employee {Id = 3, Name = "Кимон", Surname = "Ананалиев", Patronomic = "Жиречников" , Post = "Cherkash", Phone = "79393378499"},
                        new Employee {Id = 4, Name = "Вимон", Surname = "Мисалиев", Patronomic = "Ручаречников" , Post = "Cherkash", Phone = "79393378499"},
                    });
                modelBuilder.Entity<Product>().HasData(
                      new Product[]
                      {
                                new Product {Id = 1, Mark = "Конопатая", Price  = 5500},
                                new Product {Id = 2, Mark = "Малышня", Price  = 5599}
                      });
                modelBuilder.Entity<Production>().HasData(
                       new Production[]
                       {
                                new Production {Id = 1, Name = "Конопатая", Description  = "2002 год, Итальянская - сборка , кожа."},
                                new Production {Id = 2, Name = "Конопатая", Description  = "2002 год, Итальянская - сборка , кожа."},
                       });
                modelBuilder.Entity<Supplier>().HasData(
                      new Supplier[]
                      {
                                new Supplier {Id = 1, Name = "Конопатая", City  = "Мариуполь", Phone = "89093088410", Post = "Директор"    },
                                 new Supplier {Id = 2, Name = "Конопатая", City  = "Киев", Phone = "89093088411", Post = "Директор"    },
                      });
        }
    
    }
}
