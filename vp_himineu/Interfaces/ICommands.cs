using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePark.Interfaces
{
    public interface ICommands
    {
        string Name { get; }
        IDictionary<string, string> CommandParameters { get; }
    }
}
