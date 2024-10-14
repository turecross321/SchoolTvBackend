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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Information about a call on the trip leg.
    /// </summary>
    [DataContract(Name = "VT.ApiPlaneraResa.Web.V4.Models.Journeys.CallApiModel")]
    public partial class VTApiPlaneraResaWebV4ModelsJourneysCallApiModel : IEquatable<VTApiPlaneraResaWebV4ModelsJourneysCallApiModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VTApiPlaneraResaWebV4ModelsJourneysCallApiModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VTApiPlaneraResaWebV4ModelsJourneysCallApiModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VTApiPlaneraResaWebV4ModelsJourneysCallApiModel" /> class.
        /// </summary>
        /// <param name="stopPoint">stopPoint (required).</param>
        /// <param name="plannedTime">The planned time of the call in RFC 3339 format. (required).</param>
        /// <param name="estimatedTime">The estimated time of the call in RFC 3339 format..</param>
        /// <param name="notes">An ordered list (most important first) of notes related to the call..</param>
        public VTApiPlaneraResaWebV4ModelsJourneysCallApiModel(VTApiPlaneraResaWebV4ModelsJourneysStopPointApiModel stopPoint = default(VTApiPlaneraResaWebV4ModelsJourneysStopPointApiModel), string plannedTime = default(string), string estimatedTime = default(string), List<VTApiPlaneraResaWebV4ModelsNoteApiModel> notes = default(List<VTApiPlaneraResaWebV4ModelsNoteApiModel>))
        {
            // to ensure "stopPoint" is required (not null)
            if (stopPoint == null)
            {
                throw new ArgumentNullException("stopPoint is a required property for VTApiPlaneraResaWebV4ModelsJourneysCallApiModel and cannot be null");
            }
            this.StopPoint = stopPoint;
            // to ensure "plannedTime" is required (not null)
            if (plannedTime == null)
            {
                throw new ArgumentNullException("plannedTime is a required property for VTApiPlaneraResaWebV4ModelsJourneysCallApiModel and cannot be null");
            }
            this.PlannedTime = plannedTime;
            this.EstimatedTime = estimatedTime;
            this.Notes = notes;
        }

        /// <summary>
        /// Gets or Sets StopPoint
        /// </summary>
        [DataMember(Name = "stopPoint", IsRequired = true, EmitDefaultValue = true)]
        public VTApiPlaneraResaWebV4ModelsJourneysStopPointApiModel StopPoint { get; set; }

        /// <summary>
        /// The planned time of the call in RFC 3339 format.
        /// </summary>
        /// <value>The planned time of the call in RFC 3339 format.</value>
        [DataMember(Name = "plannedTime", IsRequired = true, EmitDefaultValue = true)]
        public string PlannedTime { get; set; }

        /// <summary>
        /// The estimated time of the call in RFC 3339 format.
        /// </summary>
        /// <value>The estimated time of the call in RFC 3339 format.</value>
        [DataMember(Name = "estimatedTime", EmitDefaultValue = true)]
        public string EstimatedTime { get; set; }

        /// <summary>
        /// The best known time of the call in RFC 3339 format. Is EstimatedTime if exists, otherwise PlannedTime.
        /// </summary>
        /// <value>The best known time of the call in RFC 3339 format. Is EstimatedTime if exists, otherwise PlannedTime.</value>
        [DataMember(Name = "estimatedOtherwisePlannedTime", EmitDefaultValue = true)]
        public string EstimatedOtherwisePlannedTime { get; private set; }

        /// <summary>
        /// Returns false as EstimatedOtherwisePlannedTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEstimatedOtherwisePlannedTime()
        {
            return false;
        }
        /// <summary>
        /// An ordered list (most important first) of notes related to the call.
        /// </summary>
        /// <value>An ordered list (most important first) of notes related to the call.</value>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public List<VTApiPlaneraResaWebV4ModelsNoteApiModel> Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VTApiPlaneraResaWebV4ModelsJourneysCallApiModel {\n");
            sb.Append("  StopPoint: ").Append(StopPoint).Append("\n");
            sb.Append("  PlannedTime: ").Append(PlannedTime).Append("\n");
            sb.Append("  EstimatedTime: ").Append(EstimatedTime).Append("\n");
            sb.Append("  EstimatedOtherwisePlannedTime: ").Append(EstimatedOtherwisePlannedTime).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(input as VTApiPlaneraResaWebV4ModelsJourneysCallApiModel);
        }

        /// <summary>
        /// Returns true if VTApiPlaneraResaWebV4ModelsJourneysCallApiModel instances are equal
        /// </summary>
        /// <param name="input">Instance of VTApiPlaneraResaWebV4ModelsJourneysCallApiModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VTApiPlaneraResaWebV4ModelsJourneysCallApiModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StopPoint == input.StopPoint ||
                    (this.StopPoint != null &&
                    this.StopPoint.Equals(input.StopPoint))
                ) && 
                (
                    this.PlannedTime == input.PlannedTime ||
                    (this.PlannedTime != null &&
                    this.PlannedTime.Equals(input.PlannedTime))
                ) && 
                (
                    this.EstimatedTime == input.EstimatedTime ||
                    (this.EstimatedTime != null &&
                    this.EstimatedTime.Equals(input.EstimatedTime))
                ) && 
                (
                    this.EstimatedOtherwisePlannedTime == input.EstimatedOtherwisePlannedTime ||
                    (this.EstimatedOtherwisePlannedTime != null &&
                    this.EstimatedOtherwisePlannedTime.Equals(input.EstimatedOtherwisePlannedTime))
                ) && 
                (
                    this.Notes == input.Notes ||
                    this.Notes != null &&
                    input.Notes != null &&
                    this.Notes.SequenceEqual(input.Notes)
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
                if (this.StopPoint != null)
                {
                    hashCode = (hashCode * 59) + this.StopPoint.GetHashCode();
                }
                if (this.PlannedTime != null)
                {
                    hashCode = (hashCode * 59) + this.PlannedTime.GetHashCode();
                }
                if (this.EstimatedTime != null)
                {
                    hashCode = (hashCode * 59) + this.EstimatedTime.GetHashCode();
                }
                if (this.EstimatedOtherwisePlannedTime != null)
                {
                    hashCode = (hashCode * 59) + this.EstimatedOtherwisePlannedTime.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
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
            // PlannedTime (string) minLength
            if (this.PlannedTime != null && this.PlannedTime.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PlannedTime, length must be greater than 1.", new [] { "PlannedTime" });
            }

            yield break;
        }
    }

}
