namespace Crm.Data.Migrations.Migrations
{
<<<<<<< HEAD
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Crm.Data.CrmContext>
=======
	using System.Data.Entity.Migrations;
	using Entities;

	internal sealed class Configuration : DbMigrationsConfiguration<Crm.Data.CrmContext>
>>>>>>> 7af9fb1ea3b1a3e81293ef60abbc90bb0747ed25
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

<<<<<<< HEAD
        protected override void Seed(Crm.Data.CrmContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
=======
        protected override void Seed(CrmContext context)
        {
			context.Users.AddOrUpdate(
				user => user.Login,
				new User { Login = "Administrator" }
			);
        }
    }
}
>>>>>>> 7af9fb1ea3b1a3e81293ef60abbc90bb0747ed25
