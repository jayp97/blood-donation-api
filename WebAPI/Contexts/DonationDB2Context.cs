
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Contexts
{
    public class DonationDB2Context : DbContext
    {
        public DbSet<DCandidate> DCandidates { get; set; }

        public DonationDB2Context(DbContextOptions<DonationDB2Context> options) : base(options)
        {

        }
    }
}
