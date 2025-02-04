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
    /// The severity of a message.
    /// </summary>
    /// <value>The severity of a message.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VTApiPlaneraResaWebV4ModelsSeverity
    {
        /// <summary>
        /// Enum Unknown for value: unknown
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,

        /// <summary>
        /// Enum Low for value: low
        /// </summary>
        [EnumMember(Value = "low")]
        Low,

        /// <summary>
        /// Enum Normal for value: normal
        /// </summary>
        [EnumMember(Value = "normal")]
        Normal,

        /// <summary>
        /// Enum High for value: high
        /// </summary>
        [EnumMember(Value = "high")]
        High
    }

}
