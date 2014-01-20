using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izlemag.Data;
using System.Data.Entity;

namespace Izlemag.DataAccess
{
    public class ApplicationUser : IdentityUser
    {
    }

    public class DbContext : IdentityDbContext<ApplicationUser>
    {
        public DbContext() 
            : base("name=izlemag")
        {

        }

        public DbSet<Episode> Episodes { get; set; }
        public static DbSet<Season> Seasons { get; set; }
        public static DbSet<Tag> Tags { get; set; }
        public static DbSet<TvShow> TvShows { get; set; }
    }
}
