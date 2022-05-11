using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Solution.DO.Objects;
namespace Solution.DAL.EF
{
   public class SolutionDBContext : DbContext
    {
        public SolutionDBContext(DbContextOptions<SolutionDBContext> options) : base(options)
        {

        }

        public DbSet<DragonBall> DragonBall { get; set; }
        public DbSet<Transformers> Transformers { get; set; }

    }
}
