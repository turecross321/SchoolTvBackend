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
    /// Different types of products.
    /// </summary>
    /// <value>Different types of products.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VTApiPlaneraResaWebV4ModelsProductTypeEnum
    {
        /// <summary>
        /// Enum Single for value: single
        /// </summary>
        [EnumMember(Value = "single")]
        Single = 1,

        /// <summary>
        /// Enum Period for value: period
        /// </summary>
        [EnumMember(Value = "period")]
        Period = 2,

        /// <summary>
        /// Enum Shortterm for value: shortterm
        /// </summary>
        [EnumMember(Value = "shortterm")]
        Shortterm = 3,

        /// <summary>
        /// Enum School for value: school
        /// </summary>
        [EnumMember(Value = "school")]
        School = 4,

        /// <summary>
        /// Enum Event for value: event
        /// </summary>
        [EnumMember(Value = "event")]
        Event = 5,

        /// <summary>
        /// Enum Flex for value: flex
        /// </summary>
        [EnumMember(Value = "flex")]
        Flex = 6,

        /// <summary>
        /// Enum Seasonal for value: seasonal
        /// </summary>
        [EnumMember(Value = "seasonal")]
        Seasonal = 7
    }

}
