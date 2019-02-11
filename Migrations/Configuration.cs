namespace ContactService.Migrations
{
    using ContactService.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContactService.Models.ContactServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ContactService.Models.ContactServiceContext";
        }

        protected override void Seed(ContactService.Models.ContactServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Contacts.AddOrUpdate(x => x.Id,
    new Contact() { Id = 1, Name = "Jane Austen" , Email = "jane@gmail.com", Message ="Initial Create", InsertionDate = DateTime.Now},
    new Contact() { Id = 2, Name = "Charles Dickens", Email = "dickens@hotmail.com", Message = "Initial Create", InsertionDate = DateTime.Now },
    new Contact() { Id = 3, Name = "Miguel de Cervantes", Email = "miguel@outlook.com", Message = "Initial Create", InsertionDate = DateTime.Now }
    );
        }
    }
}
