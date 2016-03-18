using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DreamJob.Models
{
    // DBcontext class : handles all interaction with the MySQL DB
    public class DBEntities : DbContext
    {
        public DBEntities() : base(nameOrConnectionString: "LocalDBconnection") { }
        public DbSet<Article> Article { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Favoris> Favoris { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Utilisateurs_has_tags> Utilisateurs_has_tags { get; set; }

    }
}