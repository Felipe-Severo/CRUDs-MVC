using WebApplicationMVC.Business.Genericos;

namespace WebApplicationMVC.Models
{
    public class VehicleModel
    {
        public long Id { get; set; }
        public VehicleType VehicleType { get; set; }
        public VehicleBrand VehicleBrand { get; set; }
        public string VehicleName { get; set; } = string.Empty;
        public int SelectedYear { get; set; }
        public string LicensePlate { get; set; } = string.Empty;
    }
}