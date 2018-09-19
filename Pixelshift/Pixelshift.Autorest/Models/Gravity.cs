// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Pixelshift.Autorest.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for Gravity.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Gravity
    {
        [EnumMember(Value = "center")]
        Center,
        [EnumMember(Value = "centre")]
        Centre,
        [EnumMember(Value = "north")]
        North,
        [EnumMember(Value = "northeast")]
        Northeast,
        [EnumMember(Value = "east")]
        East,
        [EnumMember(Value = "southeast")]
        Southeast,
        [EnumMember(Value = "south")]
        South,
        [EnumMember(Value = "southwest")]
        Southwest,
        [EnumMember(Value = "west")]
        West,
        [EnumMember(Value = "northwest")]
        Northwest
    }
    internal static class GravityEnumExtension
    {
        internal static string ToSerializedValue(this Gravity? value)
        {
            return value == null ? null : ((Gravity)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this Gravity value)
        {
            switch( value )
            {
                case Gravity.Center:
                    return "center";
                case Gravity.Centre:
                    return "centre";
                case Gravity.North:
                    return "north";
                case Gravity.Northeast:
                    return "northeast";
                case Gravity.East:
                    return "east";
                case Gravity.Southeast:
                    return "southeast";
                case Gravity.South:
                    return "south";
                case Gravity.Southwest:
                    return "southwest";
                case Gravity.West:
                    return "west";
                case Gravity.Northwest:
                    return "northwest";
            }
            return null;
        }

        internal static Gravity? ParseGravity(this string value)
        {
            switch( value )
            {
                case "center":
                    return Gravity.Center;
                case "centre":
                    return Gravity.Centre;
                case "north":
                    return Gravity.North;
                case "northeast":
                    return Gravity.Northeast;
                case "east":
                    return Gravity.East;
                case "southeast":
                    return Gravity.Southeast;
                case "south":
                    return Gravity.South;
                case "southwest":
                    return Gravity.Southwest;
                case "west":
                    return Gravity.West;
                case "northwest":
                    return Gravity.Northwest;
            }
            return null;
        }
    }
}