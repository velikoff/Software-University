using System;
using System.Collections.Generic;
using System.Linq;
using VehiclePark.Interfaces;
using VehiclePark.Vehicles;
using Wintellect.PowerCollections;

namespace vp_himineu
{

    public class VehiclePark : IVehiclePark
    {
        //private VehicleParkLayout vehicleParkLayout;
        //private VehicleParkData vehicleParkData;

        //public VehiclePark(int numberOfSectors, int placesPerSector)
        //{
        //    vehicleParkLayout = new VehicleParkLayout(numberOfSectors, placesPerSector);
        //    vehicleParkData = new VehicleParkData(numberOfSectors);
        //}
        public string InsertCar(Car car, int sector, int place, DateTime entranceTime)
        {
            //if (sector > vehicleParkLayout)
            //{
            //    return string.Format("There is no sector {0} in the Park", s);
            //}
            //if (sector > VehicleParkLayout.places_sec)
            //{
            //    return string.Format("There is no place {0} in sector {1}", p, s);
            //}
            //if (VehicleParkData.Park.ContainsKey(string.Format("({0},{1})", s, p)))
            //{
            //    return string.Format("The place ({0},{1}) is occupied", s, p);
            //}
            //if (VehicleParkData.números.ContainsKey(car.LicensePlate))
            //{
            //    return string.Format("There is already a vehicle with license plate {0} in the Park", car.LicensePlate);
            //}
            VehicleParkData.VehicleInPark[car] = string.Format("({0},{1})", sector, p);
            ;
            VehicleParkData.Park[string.Format("({0},{1})", s, p)] = car;
            VehicleParkData.números[car.LicensePlate] = car;
            VehicleParkData.timeInThePark[car] = t;
            VehicleParkData.Owner[car.Owner].Add(car);
            VehicleParkData.Count[s - 1]--;

            return string.Format("{0} parked successfully at place ({1},{2})", car.GetType().Name, s, p);
        }

        public static string InsertMotorbike(Motorbike motorbike, int sector, int p, DateTime t)
        {
            //if (sector > VehicleParkLayout.sector)
            //{
            //    return string.Format("There is no sector {0} in the Park", sector);
            //}
            //if (p > VehicleParkLayout.places_sec)
            //{
            //    return string.Format("There is no place {0} in sector {1}", p, sector);
            //}
            //if (VehicleParkData.Park.ContainsKey(string.Format("({0},{1})", sector, p)))
            //{
            //    return string.Format("The place ({0},{1}) is occupied", sector, p);
            //}
            //if (VehicleParkData.números.ContainsKey(motorbike.LicensePlate))
            //{
            //    return string.Format("There is already a vehicle with license plate {0} in the Park",
            //        motorbike.LicensePlate);
            //}
            //VehicleParkData.VehicleInPark[motorbike] = string.Format("({0},{1})", sector, p);
            //VehicleParkData.Park[string.Format("({0},{1})", sector, p)] = motorbike;
            //VehicleParkData.números[motorbike.LicensePlate] = motorbike;
            //VehicleParkData.timeInThePark[motorbike] = t;
            //VehicleParkData.Owner[motorbike.Owner].Add(motorbike);
            //VehicleParkData.Count[sector - 1]++;

            return string.Format("{0} parked successfully at place ({1},{2})", motorbike.GetType().Name, sector, p);
        }

        public string InsertTruck(Truck truck, int s, int p, DateTime t)
        {
            //if (s > VehicleParkLayout.sector)
            //{
            //    return string.Format("There is no sector {0} in the Park", s);
            //}
            //if (p > VehicleParkLayout.places_sec)
            //{
            //    return string.Format("There is no place {0} in sector {1}", p, s);
            //}
            //if (VehicleParkData.Park.ContainsKey(string.Format("({0},{1})", s, p)))
            //{
            //    return string.Format("The place ({0},{1}) is occupied", s, p);
            //}
            //if (VehicleParkData.números.ContainsKey(truck.LicensePlate))
            //{
            //    return string.Format("There is already a vehicle with license plate {0} in the Park", truck.LicensePlate);
            //}
            //VehicleParkData.VehicleInPark[truck] = string.Format("({0},{1})", s, p);
            //VehicleParkData.Park[string.Format("({0},{1})", s, p)] = truck;
            //VehicleParkData.números[truck.LicensePlate] = truck;
            //VehicleParkData.timeInThePark[truck] = t;
            //VehicleParkData.Owner[truck.Owner].Add(truck);

            return string.Format("{0} parked successfully at place ({1},{2})", truck.GetType().Name, s, p);
        }

        public string ExitVehicle(string l_pl, DateTime end, decimal money)
        {
            //var vehicle = (VehicleParkData.números.ContainsKey(l_pl)) ? VehicleParkData.números[l_pl] : null;
            //if (vehicle == null)
            //{
            //    return string.Format("There is no vehicle with license plate {0} in the Park", l_pl);
            //}

            //var start = VehicleParkData.timeInThePark[vehicle];
            //int endd = (int) Math.Round((end - start).TotalHours);
            //var ticket = new StringBuilder();
            //ticket.AppendLine(new string('*', 20)).AppendFormat("{0}", vehicle.ToString())
            //    .AppendLine().AppendFormat("at place {0}", VehicleParkData.VehicleInPark[vehicle])
            //    .AppendLine().AppendFormat("Rate: ${0:F2}", (vehicle.ReservedHour*vehicle.RegularRate))
            //    .AppendLine()
            //    .AppendFormat("Overtime rate: ${0:F2}",
            //        (endd > vehicle.ReservedHour ? (endd - vehicle.ReservedHour)*vehicle.OvertimeRate : 0))
            //    .AppendLine()
            //    .AppendLine(new string('-', 20))
            //    .AppendFormat("Total: ${0:F2}",
            //        (vehicle.ReservedHour*vehicle.RegularRate +
            //         (endd > vehicle.ReservedHour ? (endd - vehicle.ReservedHour)*vehicle.OvertimeRate : 0)))
            //    .AppendLine()
            //    .AppendFormat("Paid: ${0:F2}", money)
            //    .AppendLine()
            //    .AppendFormat("Change: ${0:F2}",
            //        money -
            //        ((vehicle.ReservedHour*vehicle.RegularRate) +
            //         (endd > vehicle.ReservedHour ? (endd - vehicle.ReservedHour)*vehicle.OvertimeRate : 0)))
            //    .AppendLine().Append(new string('*', 20));
            //DELETE
            //int sector = int.Parse( VehicleParkData.VehicleInPark[vehicle].Split(new[] {"(", ",", ")"},
            //            StringSplitOptions.RemoveEmptyEntries)[0]);
            //VehicleParkData.Park.Remove(VehicleParkData.VehicleInPark[vehicle]);
            //VehicleParkData.VehicleInPark.Remove(vehicle);
            //VehicleParkData.números.Remove(vehicle.LicensePlate);
            //VehicleParkData.timeInThePark.Remove(vehicle);
            //VehicleParkData.Owner.Remove(vehicle.Owner, vehicle);
            //VehicleParkData.Count[sector - 1]--;
            ////END OF DELETE
            //return ticket.ToString();
        }

        public string GetStatus()
        {
            var places = VehicleParkData.Count;
            //    .Select((sssss, iiiii) => string.Format
            //        ("Sector {0}: {1} / {2} ({2}% full)", iiiii + 1, sssss, VehicleParkLayout.places_sec,
            //            Math.Round((double) sssss/VehicleParkLayout.places_sec*100)));

            return string.Join(Environment.NewLine, places);
        }

        string IVehiclePark.FindVehicle(string licensePlate)
        {
            return FindVehicle(licensePlate);
        }

        public static string FindVehicle(string licensePlate)
        {
            //var vehicle = (VehicleParkData.números.ContainsKey(licensePlate)) ? VehicleParkData.números[licensePlate] : null;
            //if (vehicle == null)
            //{
            //    return string.Format("There is no vehicle with license plate {0} in the Park", licensePlate);
            //}
            //else
            //{
            //    return Input(new[] { vehicle });
            //}
        }

        public string FindVehiclesByOwner(string owner)
        {
            if (!VehicleParkData.Park.Values.Where(v => v.Owner == owner).Any())
            {
                return string.Format("No vehicles by {0}", owner);
            }

            else
            {
                var found = VehicleParkData.Park.Values.ToList();
                var res = found;
                foreach (var f in found)
                {
                    res = res.Where(v => v.Owner == owner).ToList();
                }
                return string.Join(Environment.NewLine, Input(res));
            }
        }

        private string Input(IEnumerable<IVehicle> vehicle)
        {
            return string.Join(Environment.NewLine,
                carros.Select(
                    vehicle =>
                        string.Format("{0}{1}Parked at {2}", vehicle.ToString(), Environment.NewLine,
                            VehicleParkData.VehicleInPark[vehicle])));
        }
    }
}

