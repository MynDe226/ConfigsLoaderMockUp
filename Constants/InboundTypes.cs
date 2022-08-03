using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigsLoaderMockUp.Constants
{
    public static class InboundTypes
    {
        public const string Random = "random";
        public const string Optimized = "optimized";

        public static string[] InboundTypesArray { get; } =
        {
            Random,
            Optimized
        };

        public static bool IsValid(string status)
        {
            return InboundTypesArray.Any(e => e == status);
        }
    }
}