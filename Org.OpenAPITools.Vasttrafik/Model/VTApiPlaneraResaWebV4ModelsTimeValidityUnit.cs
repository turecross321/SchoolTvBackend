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
    /// Different types of unit that specifies the amount of the Amount property.
    /// </summary>
    /// <value>Different types of unit that specifies the amount of the Amount property.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VTApiPlaneraResaWebV4ModelsTimeValidityUnit
    {
        /// <summary>
        /// Enum Unknown for value: unknown
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,

        /// <summary>
        /// Enum Minutes for value: minutes
        /// </summary>
        [EnumMember(Value = "minutes")]
        Minutes,

        /// <summary>
        /// Enum Hours for value: hours
        /// </summary>
        [EnumMember(Value = "hours")]
        Hours,

        /// <summary>
        /// Enum Days for value: days
        /// </summary>
        [EnumMember(Value = "days")]
        Days,

        /// <summary>
        /// Enum Year for value: year
        /// </summary>
        [EnumMember(Value = "year")]
        Year,

        /// <summary>
        /// Enum Semester for value: semester
        /// </summary>
        [EnumMember(Value = "semester")]
        Semester,

        /// <summary>
        /// Enum Schoolyear for value: schoolyear
        /// </summary>
        [EnumMember(Value = "schoolyear")]
        Schoolyear,

        /// <summary>
        /// Enum Unlimited for value: unlimited
        /// </summary>
        [EnumMember(Value = "unlimited")]
        Unlimited
    }

}