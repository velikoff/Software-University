using System;
using System.Collections.Generic;
using VehiclePark.Interfaces;
using Wintellect.PowerCollections;

namespace vp_himineu
{
    public static class VehicleParkData
    {
        //public VehicleParkData(int numberOfSectors)
        //{
        //    VehicleInPark = new Dictionary<IVehicle, string>(); 
        //    Park = new Dictionary<string, IVehicle>(); 
        //    números = new Dictionary<string, IVehicle>(); 
        //    TimeInThePark = new Dictionary<IVehicle, DateTime>();
        //    Owner = new MultiDictionary<string, IVehicle>(false); 
        //    Count = new int[numberOfSectors];
        //}
        public static  Dictionary<IVehicle, string> VehicleInPark { get; set; }

        public static Dictionary<string, IVehicle> Park { get; set; }

        public static Dictionary<string, IVehicle> números { get; set; }

        public static Dictionary<IVehicle, DateTime> TimeInThePark { get; set; }

        public static MultiDictionary<string, IVehicle> Owner { get; set; }

        public static int[] Count { get; set; } // make it list
    }
}
