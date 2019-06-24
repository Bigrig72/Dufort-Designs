using Microsoft.EntityFrameworkCore;
using ReganDufort.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReganDufort.Data
{
    public class PortfolioDBContext: DbContext
    {
        public PortfolioDBContext(DbContextOptions<PortfolioDBContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contact { get; set; }
    }
}
