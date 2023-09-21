using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Business.Genericos;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class VehiclesController : Controller
    {
        public IActionResult Index()
        {
            var model = new VehiclesModel();

            foreach (var vehicle in Business.Genericos.Vehicle.Vehicles)
            {
                model.Vehicles.Add(new VehicleModel() {
                    Id = vehicle.Id,
                    VehicleType = vehicle.VehicleType,
                    VehicleBrand = vehicle.VehicleBrand,
                    VehicleName = vehicle.VehicleName,
                    SelectedYear = vehicle.SelectedYear,
                    LicensePlate = vehicle.LicensePlate,
                    });
            }

            // Redireciona para o arquivo Index.cshtml na pasta Vehicles
            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(VehicleModel vehicleModel)
        {
            var vehicleRegistration = new Business.Genericos.Vehicle()
            {
                VehicleType =  vehicleModel.VehicleType,
                VehicleBrand = vehicleModel.VehicleBrand,
                VehicleName = vehicleModel.VehicleName,
                SelectedYear = vehicleModel.SelectedYear,
                LicensePlate = vehicleModel.LicensePlate,
            };

            Business.Genericos.Vehicle.Vehicles.Add(vehicleRegistration);
            return RedirectToAction("Index");
        }

        public IActionResult Update(long id)
        {
            var vehicleRegistration = Vehicle.Vehicles.FirstOrDefault(x => x.Id == id);
            if (vehicleRegistration == null)
            {
                throw new Exception("Veículo não existe!");
            }

            var model = new VehicleModel();
            model.Id = id;
            model.VehicleType = vehicleRegistration.VehicleType;
            model.VehicleBrand = vehicleRegistration.VehicleBrand;
            model.VehicleName = vehicleRegistration.VehicleName;
            model.SelectedYear = vehicleRegistration.SelectedYear;
            model.LicensePlate = vehicleRegistration.LicensePlate;

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(VehicleModel vehicleModel)
        {
            var vehicleRegistration = Vehicle.Vehicles.FirstOrDefault(x => x.Id == vehicleModel.Id);
            if (vehicleRegistration == null)
            {
                throw new Exception("Esse veículo não existe!");
            }

            vehicleRegistration.VehicleType = vehicleModel.VehicleType;
            vehicleRegistration.VehicleBrand = vehicleModel.VehicleBrand;
            vehicleRegistration.VehicleName = vehicleModel.VehicleName;
            vehicleRegistration.SelectedYear = vehicleModel.SelectedYear;
            vehicleRegistration.LicensePlate = vehicleModel.LicensePlate;

            return RedirectToAction("Index"); 
        }

        public IActionResult Delete(long id)
        {
            var vehicleRegistration = Vehicle.Vehicles.FirstOrDefault(x => x.Id == id);
            if (vehicleRegistration == null)
            {
                throw new Exception("Esse veículo não existe!");
            }

            var model = new VehicleModel();
            model.Id = id;
            model.VehicleType = vehicleRegistration.VehicleType;
            model.VehicleBrand = vehicleRegistration.VehicleBrand;
            model.VehicleName = vehicleRegistration.VehicleName;
            model.SelectedYear = vehicleRegistration.SelectedYear;
            model.LicensePlate = vehicleRegistration.LicensePlate;

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(VehicleModel vehicleModel)
        {
            var vehicleRegistration = Vehicle.Vehicles.FirstOrDefault(x => x.Id == vehicleModel.Id);
            if (vehicleRegistration == null)
            {
                throw new Exception("Esse veículo não existe!");
            }

            Vehicle.Vehicles.Remove(vehicleRegistration);

            return RedirectToAction("Index");
        }
    }
}