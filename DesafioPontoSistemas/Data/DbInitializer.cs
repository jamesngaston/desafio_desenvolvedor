using System;
using System.Linq;
using System.Collections.Generic;
using DesafioPontoSistemas.Models;

namespace DesafioPontoSistemas.Data
{
    public class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
            new User{Name = "Fulano da Silva", Age = 30, Email = "fulano@email.com"},
            new User{Name = "Ciclano Souza", Age = 25, Email = "ciclano@email.com"},
            new User{Name = "Beltrano Santos", Age = 48, Email = "beltrano@email.com"},
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }

            context.SaveChanges();
        }
    }
}
