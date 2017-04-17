namespace RentACar.Models
{
    using System.Data.Entity;

    public class RentACarDBContext : DbContext
    {

        public RentACarDBContext()
            : base("name=RentACarDB")
        {
        }

        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<Rent> Rent { get; set; }
    }


}