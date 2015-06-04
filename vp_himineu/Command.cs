using System;
using System.Collections.Generic;
using VehiclePark.Interfaces;
using VehiclePark.Vehicles;
using System.Web.Script.Serialization;

namespace Comandos
{   class exec
    {
        public class Command : ICommands
        {

            public string Name { get; set; }

            public IDictionary<string, string> CommandParameters { get; set; }

            //VehiclePark VehiclePark { get; set; }

            public Command(string str)
            {
                Name = str.Substring(0, str.IndexOf(' '));
                CommandParameters = new JavaScriptSerializer()
                    .Deserialize<Dictionary<string, string>>(str.Substring(str.IndexOf(' ') + 1));
            }
        }
        
        public string Commands(ICommands c)
        {
            if (c.Name != "SetupPark")
            {
                return "The vehicle Park has not been set up";
            }
           // if (c.Name != "SetupPark" && VehiclePark == null) return "The vehicle Park has not been set up";
            switch (c.Name)
            {
                case "SetupPark":
                    
                    VehiclePark vehiclePark = new VehiclePark(c.CommandParameters["sector"]+1,c.CommandParameters["placesPerSector"]);
                    return "Vehicle Park created";
                case "Park":
                    switch (c.CommandParameters["type"])
                    {
                        case "car": 
                            return InsertCar( new Car(c.CommandParameters["licensePlate"], 
                                c.CommandParameters["owner"], 
                                int.Parse(c.CommandParameters["hours"])), 
                                int.Parse(c.CommandParameters["sector"]), 
                                int.Parse(c.CommandParameters["place"]), DateTime.Parse(c.CommandParameters["time"], null, System.Globalization.DateTimeStyles.RoundtripKind));//why round trip kind??
                        case "motorbike":
                            return VehiclePark.InsertMotorbike(new Motorbike(c.CommandParameters["licensePlate"], 
                                c.CommandParameters["owner"], 
                                int.Parse(c.CommandParameters["hours"])), 
                                int.Parse(c.CommandParameters["sector"]), 
                                int.Parse(c.CommandParameters["place"]), 
                                DateTime.Parse(c.CommandParameters["time"], 
                                null, 
                                System.Globalization.DateTimeStyles.RoundtripKind));

                        case "truck": 
                            return VehiclePark.InsertTruck(new Truck(c.CommandParameters["licensePlate"], 
                                c.CommandParameters["owner"], 
                                int.Parse(c.CommandParameters["hours"])), 
                                int.Parse(c.CommandParameters["sector"]), 
                                int.Parse(c.CommandParameters["place"]), 
                                DateTime.Parse(c.CommandParameters["time"], 
                                null, 
                                System.Globalization.DateTimeStyles.RoundtripKind));
                    }
                    break;

                case "Exit": return VehiclePark.ExitVehicle(c.CommandParameters["licensePlate"], 
                    DateTime.Parse(c.CommandParameters["time"], 
                    null, System.Globalization.DateTimeStyles.RoundtripKind), 
                    decimal.Parse(c.CommandParameters["money"]));
                case "Status": 
                    return VehiclePark.GetStatus();
                case "FindVehicle":
                    return VehiclePark.FindVehicle(c.CommandParameters["licensePlate"]);
                case "VehiclesByOwner": 
                    return VehiclePark.FindVehiclesByOwner(c.CommandParameters["owner"]);
                default: throw new IndexOutOfRangeException("Invalid command.");
            }      
            return "";
        }
    }
}