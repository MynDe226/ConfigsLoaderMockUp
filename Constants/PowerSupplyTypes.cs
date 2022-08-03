using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigsLoaderMockUp.Constants
{
    public static class PowerSupplyTypes
    {
        public const string Big = "big";
        public const string Normal = "normal";

        public static string[] SupplyTypesArray { get; } =
        {
            Big,
            Normal
        };

        public static bool IsValid(string status)
        {
            return SupplyTypesArray.Any(e => e == status);
        }
    }
}
