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
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// VTApiPlaneraResaWebV4ModelsJourneyDetailsStopPointApiModel
    /// </summary>
    [DataContract(Name = "VT.ApiPlaneraResa.Web.V4.Models.JourneyDetails.StopPointApiModel")]
    public partial class VTApiPlaneraResaWebV4ModelsJourneyDetailsStopPointApiModel : IEquatable<VTApiPlaneraResaWebV4ModelsJourneyDetailsStopPointApiModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VTApiPlaneraResaWebV4ModelsJourneyDetailsStopPointApiModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VTApiPlaneraResaWebV4ModelsJourneyDetailsStopPointApiModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VTApiPlaneraResaWebV4ModelsJourneyDetailsStopPointApiModel" /> class.
        /// </summary>
        /// <param name="gid">The 16-digit Västtrafik gid of the stop point. (required).</param>
        /// <param name="name">The stop point name. (required).</param>
        /// <param name="platform">The platform of the stop point..</param>
        /// <param name="latitude">The latitude coordinate of the stop point..</param>
        /// <param name="longitude">The longitude coordinate of the stop point..</param>
        /// <param name="stopArea">stopArea.</param>
        public VTApiPlaneraResaWebV4ModelsJourneyDetailsStopPointApiModel(string gid = default(string), string name = default(string), string platform = default(string), double? latitude = default(double?), double? longitude = default(double?), VTApiPlaneraResaWebV4ModelsJourneyDetailsStopAreaApiModel stopArea = default(VTApiPlaneraResaWebV4ModelsJourneyDetailsStopAreaApiModel))
        {
            // to ensure "gid" is required (not null)
            if (gid == null)
            {
                throw new ArgumentNullException("gid is a required property for VTApiPlaneraResaWebV4ModelsJourneyDetailsStopPointApiModel and cannot be null");
            }
            this.Gid = gid;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for VTApiPlaneraResaWebV4ModelsJourneyDetailsStopPointApiModel and cannot be null");
            }
            this.Name = name;
            this.Platform = platform;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.StopArea = stopArea;
        }

        /// <summary>
        /// The 16-digit Västtrafik gid of the stop point.
        /// </summary>
        /// <value>The 16-digit Västtrafik gid of the stop point.</value>
        [DataMember(Name = "gid", IsRequired = true, EmitDefaultValue = true)]
        public string Gid { get; set; }

        /// <summary>
        /// The stop point name.
        /// </summary>
        /// <value>The stop point name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The platform of the stop point.
        /// </summary>
        /// <value>The platform of the stop point.</value>
        [DataMember(Name = "platform", EmitDefaultValue = true)]
        public string Platform { get; set; }

        /// <summary>
        /// The latitude coordinate of the stop point.
        /// </summary>
        /// <value>The latitude coordinate of the stop point.</value>
        [DataMember(Name = "latitude", EmitDefaultValue = true)]
        public double? Latitude { get; set; }

        /// <summary>
        /// The longitude coordinate of the stop point.
        /// </summary>
        /// <value>The longitude coordinate of the stop point.</value>
        [DataMember(Name = "longitude", EmitDefaultValue = true)]
        public double? Longitude { get; set; }

        /// <summary>
        /// Gets or Sets StopArea
        /// </summary>
        [DataMember(Name = "stopArea", EmitDefaultValue = false)]
        public VTApiPlaneraResaWebV4ModelsJourneyDetailsStopAreaApiModel StopArea { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VTApiPlaneraResaWebV4ModelsJourneyDetailsStopPointApiModel {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  StopArea: ").Append(StopArea).Append("\n");
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
            return this.Equals(input as VTApiPlaneraResaWebV4ModelsJourneyDetailsStopPointApiModel);
        }

        /// <summary>
        /// Returns true if VTApiPlaneraResaWebV4ModelsJourneyDetailsStopPointApiModel instances are equal
        /// </summary>
        /// <param name="input">Instance of VTApiPlaneraResaWebV4ModelsJourneyDetailsStopPointApiModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VTApiPlaneraResaWebV4ModelsJourneyDetailsStopPointApiModel input)
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
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
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
                    this.StopArea == input.StopArea ||
                    (this.StopArea != null &&
                    this.StopArea.Equals(input.StopArea))
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
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                }
                if (this.Latitude != null)
                {
                    hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                }
                if (this.Longitude != null)
                {
                    hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                }
                if (this.StopArea != null)
                {
                    hashCode = (hashCode * 59) + this.StopArea.GetHashCode();
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
            // Gid (string) minLength
            if (this.Gid != null && this.Gid.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Gid, length must be greater than 1.", new [] { "Gid" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
