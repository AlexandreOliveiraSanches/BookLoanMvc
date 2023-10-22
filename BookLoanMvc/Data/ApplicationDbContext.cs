using BookLoanMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace BookLoanMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<LoansModel> Loans { get; set; }

    }
}
