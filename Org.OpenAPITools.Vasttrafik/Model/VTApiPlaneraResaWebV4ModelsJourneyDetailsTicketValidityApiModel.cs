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
    /// Information about ticket validity.
    /// </summary>
    [DataContract(Name = "VT.ApiPlaneraResa.Web.V4.Models.JourneyDetails.TicketValidityApiModel")]
    public partial class VTApiPlaneraResaWebV4ModelsJourneyDetailsTicketValidityApiModel : IEquatable<VTApiPlaneraResaWebV4ModelsJourneyDetailsTicketValidityApiModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VTApiPlaneraResaWebV4ModelsJourneyDetailsTicketValidityApiModel" /> class.
        /// </summary>
        /// <param name="id">The ticket id..</param>
        /// <param name="isValidForJourney">Indicates if the ticket is valid for the journey..</param>
        public VTApiPlaneraResaWebV4ModelsJourneyDetailsTicketValidityApiModel(string id = default(string), bool? isValidForJourney = default(bool?))
        {
            this.Id = id;
            this.IsValidForJourney = isValidForJourney;
        }

        /// <summary>
        /// The ticket id.
        /// </summary>
        /// <value>The ticket id.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Indicates if the ticket is valid for the journey.
        /// </summary>
        /// <value>Indicates if the ticket is valid for the journey.</value>
        [DataMember(Name = "isValidForJourney", EmitDefaultValue = true)]
        public bool? IsValidForJourney { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VTApiPlaneraResaWebV4ModelsJourneyDetailsTicketValidityApiModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsValidForJourney: ").Append(IsValidForJourney).Append("\n");
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
            return this.Equals(input as VTApiPlaneraResaWebV4ModelsJourneyDetailsTicketValidityApiModel);
        }

        /// <summary>
        /// Returns true if VTApiPlaneraResaWebV4ModelsJourneyDetailsTicketValidityApiModel instances are equal
        /// </summary>
        /// <param name="input">Instance of VTApiPlaneraResaWebV4ModelsJourneyDetailsTicketValidityApiModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VTApiPlaneraResaWebV4ModelsJourneyDetailsTicketValidityApiModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsValidForJourney == input.IsValidForJourney ||
                    (this.IsValidForJourney != null &&
                    this.IsValidForJourney.Equals(input.IsValidForJourney))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.IsValidForJourney != null)
                {
                    hashCode = (hashCode * 59) + this.IsValidForJourney.GetHashCode();
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