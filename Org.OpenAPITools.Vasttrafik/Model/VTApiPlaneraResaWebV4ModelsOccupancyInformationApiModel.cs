/*
 * Planera Resa
 *
 * Sök och planera resor med Västtrafik
 *
 * The version of the OpenAPI document: v4
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Contains information about occupancy.
    /// </summary>
    [DataContract(Name = "VT.ApiPlaneraResa.Web.V4.Models.OccupancyInformationApiModel")]
    public partial class VTApiPlaneraResaWebV4ModelsOccupancyInformationApiModel : IEquatable<VTApiPlaneraResaWebV4ModelsOccupancyInformationApiModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public VTApiPlaneraResaWebV4ModelsOccupancyLevel? Level { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public VTApiPlaneraResaWebV4ModelsOccupancyInformationSource? Source { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VTApiPlaneraResaWebV4ModelsOccupancyInformationApiModel" /> class.
        /// </summary>
        /// <param name="level">level.</param>
        /// <param name="source">source.</param>
        public VTApiPlaneraResaWebV4ModelsOccupancyInformationApiModel(VTApiPlaneraResaWebV4ModelsOccupancyLevel? level = default(VTApiPlaneraResaWebV4ModelsOccupancyLevel?), VTApiPlaneraResaWebV4ModelsOccupancyInformationSource? source = default(VTApiPlaneraResaWebV4ModelsOccupancyInformationSource?))
        {
            this.Level = level;
            this.Source = source;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VTApiPlaneraResaWebV4ModelsOccupancyInformationApiModel {\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VTApiPlaneraResaWebV4ModelsOccupancyInformationApiModel);
        }

        /// <summary>
        /// Returns true if VTApiPlaneraResaWebV4ModelsOccupancyInformationApiModel instances are equal
        /// </summary>
        /// <param name="input">Instance of VTApiPlaneraResaWebV4ModelsOccupancyInformationApiModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VTApiPlaneraResaWebV4ModelsOccupancyInformationApiModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Level == input.Level ||
                    this.Level.Equals(input.Level)
                ) && 
                (
                    this.Source == input.Source ||
                    this.Source.Equals(input.Source)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Level.GetHashCode();
                hashCode = (hashCode * 59) + this.Source.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}