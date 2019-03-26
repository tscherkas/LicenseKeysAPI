using System;
using System.Collections.Generic;
using System.Text;
using LicensesDAL_EF.Entities;
using Microsoft.EntityFrameworkCore;


namespace LicensesDAL_EF
{
    public class LicenceContext: DbContext
    {
        public LicenceContext(DbContextOptions<LicenceContext> options) : base(options)
        {
        }

        public DbSet<License> licenses { get; set; }
    }
}
