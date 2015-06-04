using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclePark.Vehicles;


namespace VehiclePark.Interfaces
{
   public interface IVehiclePark
    {
        string InsertCar(Car car, int sector, int placeNumber, DateTime startTime);
        string InsertMotorbike(Motorbike motorbike, int sector, int placeNumber, DateTime startTime);
        string InsertTruck(Truck truck, int sector, int placeNumber, DateTime startTime);
        string ExitVehicle(string licensePlate, DateTime endTime, decimal amountPaid);
        string GetStatus();
        string FindVehicle(string licensePlate);
        string FindVehiclesByOwner(string owner);
    }
}
