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
    /// The different kinds of detailed information that could be included in a get departure details request.
    /// </summary>
    /// <value>The different kinds of detailed information that could be included in a get departure details request.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VTApiPlaneraResaWebV4ModelsDepartureDetailsIncludeType
    {
        /// <summary>
        /// Enum Servicejourneycalls for value: servicejourneycalls
        /// </summary>
        [EnumMember(Value = "servicejourneycalls")]
        Servicejourneycalls = 1,

        /// <summary>
        /// Enum Servicejourneycoordinates for value: servicejourneycoordinates
        /// </summary>
        [EnumMember(Value = "servicejourneycoordinates")]
        Servicejourneycoordinates = 2,

        /// <summary>
        /// Enum Occupancy for value: occupancy
        /// </summary>
        [EnumMember(Value = "occupancy")]
        Occupancy = 3
    }

}
