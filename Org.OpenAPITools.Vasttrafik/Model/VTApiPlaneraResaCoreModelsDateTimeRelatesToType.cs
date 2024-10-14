/*
 * Planera Resa
 *
 * Sök och planera resor med Västtrafik
 *
 * The version of the OpenAPI document: v4
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Defines VT.ApiPlaneraResa.Core.Models.DateTimeRelatesToType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VTApiPlaneraResaCoreModelsDateTimeRelatesToType
    {
        /// <summary>
        /// Enum Departure for value: departure
        /// </summary>
        [EnumMember(Value = "departure")]
        Departure = 1,

        /// <summary>
        /// Enum Arrival for value: arrival
        /// </summary>
        [EnumMember(Value = "arrival")]
        Arrival = 2
    }

}
