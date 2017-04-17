namespace RentACar.Models
{
    public enum Type
    {
        Car = 0,
        Motor = 1
    }
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string VehicleBrand { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleAge { get; set; }
        public string LicensePlate { get; set; }
        public double RentPrice { get; set; }
        public Type VehicleType { get; set; }
        public bool IsRented { get; set; }
        public bool IsDeleted { get; set; }


    }
}