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
    /// Describes the duration of validity of a single punch.
    /// </summary>
    [DataContract(Name = "VT.ApiPlaneraResa.Web.V4.Models.JourneyDetails.PunchConfigurationDurationApiModel")]
    public partial class VTApiPlaneraResaWebV4ModelsJourneyDetailsPunchConfigurationDurationApiModel : IEquatable<VTApiPlaneraResaWebV4ModelsJourneyDetailsPunchConfigurationDurationApiModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        public VTApiPlaneraResaWebV4ModelsPunchConfigurationDurationUnitApiModel? Unit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VTApiPlaneraResaWebV4ModelsJourneyDetailsPunchConfigurationDurationApiModel" /> class.
        /// </summary>
        /// <param name="unit">unit.</param>
        /// <param name="amount">Duration of validity of a single punch..</param>
        public VTApiPlaneraResaWebV4ModelsJourneyDetailsPunchConfigurationDurationApiModel(VTApiPlaneraResaWebV4ModelsPunchConfigurationDurationUnitApiModel? unit = default(VTApiPlaneraResaWebV4ModelsPunchConfigurationDurationUnitApiModel?), int? amount = default(int?))
        {
            this.Unit = unit;
            this.Amount = amount;
        }

        /// <summary>
        /// Duration of validity of a single punch.
        /// </summary>
        /// <value>Duration of validity of a single punch.</value>
        [DataMember(Name = "amount", EmitDefaultValue = true)]
        public int? Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VTApiPlaneraResaWebV4ModelsJourneyDetailsPunchConfigurationDurationApiModel {\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as VTApiPlaneraResaWebV4ModelsJourneyDetailsPunchConfigurationDurationApiModel);
        }

        /// <summary>
        /// Returns true if VTApiPlaneraResaWebV4ModelsJourneyDetailsPunchConfigurationDurationApiModel instances are equal
        /// </summary>
        /// <param name="input">Instance of VTApiPlaneraResaWebV4ModelsJourneyDetailsPunchConfigurationDurationApiModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VTApiPlaneraResaWebV4ModelsJourneyDetailsPunchConfigurationDurationApiModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Unit == input.Unit ||
                    this.Unit.Equals(input.Unit)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                hashCode = (hashCode * 59) + this.Unit.GetHashCode();
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
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
