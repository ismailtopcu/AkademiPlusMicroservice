using AkademiPlusMicroservice.Services.Payment.DAL;
using Microsoft.EntityFrameworkCore;

namespace AkademiPlusMicroservice.Services.Payment.Context
{
    public class PaymentContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost,1433; database=PaymentDb;user=sa;password=123456Aa*;");
        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
