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
    /// Information about an endpoint on an access link.
    /// </summary>
    [DataContract(Name = "VT.ApiPlaneraResa.Web.V4.Models.Journeys.LinkEndpointApiModel")]
    public partial class VTApiPlaneraResaWebV4ModelsJourneysLinkEndpointApiModel : IEquatable<VTApiPlaneraResaWebV4ModelsJourneysLinkEndpointApiModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LocationType
        /// </summary>
        [DataMember(Name = "locationType", IsRequired = true, EmitDefaultValue = true)]
        public VTApiPlaneraResaWebV4ModelsLocationType LocationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VTApiPlaneraResaWebV4ModelsJourneysLinkEndpointApiModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VTApiPlaneraResaWebV4ModelsJourneysLinkEndpointApiModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VTApiPlaneraResaWebV4ModelsJourneysLinkEndpointApiModel" /> class.
        /// </summary>
        /// <param name="gid">The 16-digit Västtrafik gid..</param>
        /// <param name="name">The location name. (required).</param>
        /// <param name="locationType">locationType (required).</param>
        /// <param name="latitude">The WGS84 latitude of the location..</param>
        /// <param name="longitude">The WGS84 longitude of the location..</param>
        /// <param name="plannedTime">The planned time in RFC 3339 format. (required).</param>
        /// <param name="estimatedTime">The estimated time in RFC 3339 format..</param>
        /// <param name="notes">An ordered list (most important first) of notes related to the end point..</param>
        public VTApiPlaneraResaWebV4ModelsJourneysLinkEndpointApiModel(string gid = default(string), string name = default(string), VTApiPlaneraResaWebV4ModelsLocationType locationType = default(VTApiPlaneraResaWebV4ModelsLocationType), double? latitude = default(double?), double? longitude = default(double?), string plannedTime = default(string), string estimatedTime = default(string), List<VTApiPlaneraResaWebV4ModelsNoteApiModel> notes = default(List<VTApiPlaneraResaWebV4ModelsNoteApiModel>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for VTApiPlaneraResaWebV4ModelsJourneysLinkEndpointApiModel and cannot be null");
            }
            this.Name = name;
            this.LocationType = locationType;
            // to ensure "plannedTime" is required (not null)
            if (plannedTime == null)
            {
                throw new ArgumentNullException("plannedTime is a required property for VTApiPlaneraResaWebV4ModelsJourneysLinkEndpointApiModel and cannot be null");
            }
            this.PlannedTime = plannedTime;
            this.Gid = gid;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.EstimatedTime = estimatedTime;
            this.Notes = notes;
        }

        /// <summary>
        /// The 16-digit Västtrafik gid.
        /// </summary>
        /// <value>The 16-digit Västtrafik gid.</value>
        [DataMember(Name = "gid", EmitDefaultValue = true)]
        public string Gid { get; set; }

        /// <summary>
        /// The location name.
        /// </summary>
        /// <value>The location name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The WGS84 latitude of the location.
        /// </summary>
        /// <value>The WGS84 latitude of the location.</value>
        [DataMember(Name = "latitude", EmitDefaultValue = true)]
        public double? Latitude { get; set; }

        /// <summary>
        /// The WGS84 longitude of the location.
        /// </summary>
        /// <value>The WGS84 longitude of the location.</value>
        [DataMember(Name = "longitude", EmitDefaultValue = true)]
        public double? Longitude { get; set; }

        /// <summary>
        /// The planned time in RFC 3339 format.
        /// </summary>
        /// <value>The planned time in RFC 3339 format.</value>
        [DataMember(Name = "plannedTime", IsRequired = true, EmitDefaultValue = true)]
        public string PlannedTime { get; set; }

        /// <summary>
        /// The estimated time in RFC 3339 format.
        /// </summary>
        /// <value>The estimated time in RFC 3339 format.</value>
        [DataMember(Name = "estimatedTime", EmitDefaultValue = true)]
        public string EstimatedTime { get; set; }

        /// <summary>
        /// The best known time of the link in RFC 3339 format. Is EstimatedTime if exists, otherwise PlannedTime.
        /// </summary>
        /// <value>The best known time of the link in RFC 3339 format. Is EstimatedTime if exists, otherwise PlannedTime.</value>
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
        /// An ordered list (most important first) of notes related to the end point.
        /// </summary>
        /// <value>An ordered list (most important first) of notes related to the end point.</value>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public List<VTApiPlaneraResaWebV4ModelsNoteApiModel> Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VTApiPlaneraResaWebV4ModelsJourneysLinkEndpointApiModel {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LocationType: ").Append(LocationType).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
            return this.Equals(input as VTApiPlaneraResaWebV4ModelsJourneysLinkEndpointApiModel);
        }

        /// <summary>
        /// Returns true if VTApiPlaneraResaWebV4ModelsJourneysLinkEndpointApiModel instances are equal
        /// </summary>
        /// <param name="input">Instance of VTApiPlaneraResaWebV4ModelsJourneysLinkEndpointApiModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VTApiPlaneraResaWebV4ModelsJourneysLinkEndpointApiModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Gid == input.Gid ||
                    (this.Gid != null &&
                    this.Gid.Equals(input.Gid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LocationType == input.LocationType ||
                    this.LocationType.Equals(input.LocationType)
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
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
                if (this.Gid != null)
                {
                    hashCode = (hashCode * 59) + this.Gid.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LocationType.GetHashCode();
                if (this.Latitude != null)
                {
                    hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                }
                if (this.Longitude != null)
                {
                    hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
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
            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // PlannedTime (string) minLength
            if (this.PlannedTime != null && this.PlannedTime.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PlannedTime, length must be greater than 1.", new [] { "PlannedTime" });
            }

            yield break;
        }
    }

}
