using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationMVC.Business.Genericos
{
    public enum VehicleType
    {
        Moto = 0,
        Carro = 1,
        Onibus = 2,
        Caminhão = 3,
    }

    public enum VehicleBrand
    {
        Audi = 0,
        BMW = 1,
        Chevrolet = 2,
        Chrysler = 3,
        Citroen = 4,
        Dodge = 5,
        Ferrari = 6,
        Fiat = 7,
        Ford = 8,
        Honda = 9,
        Hyundai = 10,
        Jaguar = 11,
        Jeep = 12,
        Kia = 13,
        Lamborghini = 14,
        LandRover = 15,
        Mazda = 16,
        MercedesBenz = 17,
        Mini = 18,
        Nissan = 19,
        Peugeot = 20,
        Porsche = 21,
        Renault = 22,
        RollsRoyce = 23,
        Subaru = 24,
        Tesla = 25,
        Toyota = 26,
        Volkswagen = 27,
        Volvo = 28
    }

   

    public static class VehicleYear
    {
        public static List<int> AnosDisponiveis = Enumerable.Range(1985, 39).Reverse().ToList();
    }




    public class Vehicle
    {
        public long Id { get; set; }
        public VehicleType VehicleType { get; set; }
        public VehicleBrand VehicleBrand { get; set; }
        public string VehicleName { get; set; }
        public int SelectedYear { get; set; }
        public string LicensePlate { get; set; } = string.Empty;

       

        private static long _currentId = 0;

        public static List<Vehicle> Vehicles = new List<Vehicle>()
        {
            new Vehicle()
            {
                VehicleType = VehicleType.Carro,
                VehicleBrand = VehicleBrand.Volkswagen,
                VehicleName = "Fusca",
                SelectedYear = VehicleYear.AnosDisponiveis[32],
                LicensePlate = "MKJ-0D52",
            }
        };

        public Vehicle()
        {
            Id = ++_currentId;
        }
    }
}
