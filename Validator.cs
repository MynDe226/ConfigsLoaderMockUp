using ConfigsLoaderMockUp.Constants;

namespace ConfigsLoaderMockUp
{
    public static class Validator
    {
        public static int ValidateIntValues(string name, string value)
        {
            var  r = int.TryParse(value, out int result);
            if (r)
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid value of " + name + ", value: " + value);
                return -1;
            }
        }

        public static string ValidateInboundValues(string name, string value)
        {
            if (InboundTypes.IsValid(value))
            {
                return value;
            } else
            {
                Console.WriteLine("Invalid value of " + name + ", value: " + value);
                return "Error";
            }
        }

        public static string ValidateSupplyValues(string name, string value)
        {
            if (PowerSupplyTypes.IsValid(value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Invalid value of " + name + ", value: " + value);
                return "Error";
            }
        }

        public static TimeOnly ValidateTime(string name, string value)
        {
            var result = TimeOnly.TryParseExact(value, "hh:mm:ss", out TimeOnly time);
            if (result)
            {
                return time;
            } else
            {
                Console.WriteLine("Invalid value of " + name + ", value: " + value);
                return new TimeOnly();
            }
        }
    }
}
