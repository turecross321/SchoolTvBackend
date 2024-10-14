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
    /// A subset of TransportMode
    /// </summary>
    /// <value>A subset of TransportMode</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VTApiPlaneraResaWebV4ModelsJourneyTransportSubMode
    {
        /// <summary>
        /// Enum Vasttagen for value: vasttagen
        /// </summary>
        [EnumMember(Value = "vasttagen")]
        Vasttagen = 1,

        /// <summary>
        /// Enum Longdistancetrain for value: longdistancetrain
        /// </summary>
        [EnumMember(Value = "longdistancetrain")]
        Longdistancetrain = 2,

        /// <summary>
        /// Enum Regionaltrain for value: regionaltrain
        /// </summary>
        [EnumMember(Value = "regionaltrain")]
        Regionaltrain = 3
    }

}
