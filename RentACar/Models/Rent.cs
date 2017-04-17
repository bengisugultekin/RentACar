using System;

namespace RentACar.Models
{
    public class Rent
    {
        public int ID { get; set; }
        public string Customer { get; set; }
        public DateTime RentDate { get; set; }
        public int RentDay { get; set; }

        public double PricePerDay { get; set; }

        public double TotalPrice
        {
            get
            {
                return PricePerDay * RentDay;
            }

        }

        public int VehicleID { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}