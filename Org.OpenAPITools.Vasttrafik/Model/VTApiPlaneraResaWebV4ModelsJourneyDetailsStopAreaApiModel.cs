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
    /// VTApiPlaneraResaWebV4ModelsJourneyDetailsStopAreaApiModel
    /// </summary>
    [DataContract(Name = "VT.ApiPlaneraResa.Web.V4.Models.JourneyDetails.StopAreaApiModel")]
    public partial class VTApiPlaneraResaWebV4ModelsJourneyDetailsStopAreaApiModel : IEquatable<VTApiPlaneraResaWebV4ModelsJourneyDetailsStopAreaApiModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VTApiPlaneraResaWebV4ModelsJourneyDetailsStopAreaApiModel" /> class.
        /// </summary>
        /// <param name="gid">The 16-digit Västtrafik gid of the stop area..</param>
        /// <param name="name">The stop area name..</param>
        /// <param name="latitude">The latitude of the stop point..</param>
        /// <param name="longitude">The longitude of the stop point..</param>
        /// <param name="tariffZone1">tariffZone1.</param>
        /// <param name="tariffZone2">tariffZone2.</param>
        public VTApiPlaneraResaWebV4ModelsJourneyDetailsStopAreaApiModel(string gid = default(string), string name = default(string), double latitude = default(double), double longitude = default(double), VTApiPlaneraResaWebV4ModelsJourneyDetailsTariffZoneApiModel tariffZone1 = default(VTApiPlaneraResaWebV4ModelsJourneyDetailsTariffZoneApiModel), VTApiPlaneraResaWebV4ModelsJourneyDetailsTariffZoneApiModel tariffZone2 = default(VTApiPlaneraResaWebV4ModelsJourneyDetailsTariffZoneApiModel))
        {
            this.Gid = gid;
            this.Name = name;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.TariffZone1 = tariffZone1;
            this.TariffZone2 = tariffZone2;
        }

        /// <summary>
        /// The 16-digit Västtrafik gid of the stop area.
        /// </summary>
        /// <value>The 16-digit Västtrafik gid of the stop area.</value>
        [DataMember(Name = "gid", EmitDefaultValue = true)]
        public string Gid { get; set; }

        /// <summary>
        /// The stop area name.
        /// </summary>
        /// <value>The stop area name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The latitude of the stop point.
        /// </summary>
        /// <value>The latitude of the stop point.</value>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public double Latitude { get; set; }

        /// <summary>
        /// The longitude of the stop point.
        /// </summary>
        /// <value>The longitude of the stop point.</value>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or Sets TariffZone1
        /// </summary>
        [DataMember(Name = "tariffZone1", EmitDefaultValue = false)]
        public VTApiPlaneraResaWebV4ModelsJourneyDetailsTariffZoneApiModel TariffZone1 { get; set; }

        /// <summary>
        /// Gets or Sets TariffZone2
        /// </summary>
        [DataMember(Name = "tariffZone2", EmitDefaultValue = false)]
        public VTApiPlaneraResaWebV4ModelsJourneyDetailsTariffZoneApiModel TariffZone2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VTApiPlaneraResaWebV4ModelsJourneyDetailsStopAreaApiModel {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  TariffZone1: ").Append(TariffZone1).Append("\n");
            sb.Append("  TariffZone2: ").Append(TariffZone2).Append("\n");
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
            return this.Equals(input as VTApiPlaneraResaWebV4ModelsJourneyDetailsStopAreaApiModel);
        }

        /// <summary>
        /// Returns true if VTApiPlaneraResaWebV4ModelsJourneyDetailsStopAreaApiModel instances are equal
        /// </summary>
        /// <param name="input">Instance of VTApiPlaneraResaWebV4ModelsJourneyDetailsStopAreaApiModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VTApiPlaneraResaWebV4ModelsJourneyDetailsStopAreaApiModel input)
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
                    this.Latitude == input.Latitude ||
                    this.Latitude.Equals(input.Latitude)
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    this.Longitude.Equals(input.Longitude)
                ) && 
                (
                    this.TariffZone1 == input.TariffZone1 ||
                    (this.TariffZone1 != null &&
                    this.TariffZone1.Equals(input.TariffZone1))
                ) && 
                (
                    this.TariffZone2 == input.TariffZone2 ||
                    (this.TariffZone2 != null &&
                    this.TariffZone2.Equals(input.TariffZone2))
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
                hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                if (this.TariffZone1 != null)
                {
                    hashCode = (hashCode * 59) + this.TariffZone1.GetHashCode();
                }
                if (this.TariffZone2 != null)
                {
                    hashCode = (hashCode * 59) + this.TariffZone2.GetHashCode();
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
