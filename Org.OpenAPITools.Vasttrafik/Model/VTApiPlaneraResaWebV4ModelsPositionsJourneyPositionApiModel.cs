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
using System.ComponentModel.DataAnnotations;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel
    /// </summary>
    [DataContract(Name = "VT.ApiPlaneraResa.Web.V4.Models.Positions.JourneyPositionApiModel")]
    public partial class VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel : IEquatable<VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel" /> class.
        /// </summary>
        /// <param name="detailsReference">Journey reference.</param>
        /// <param name="line">line.</param>
        /// <param name="notes">Journey notes.</param>
        /// <param name="name">Journey name.</param>
        /// <param name="direction">Journey direction.</param>
        /// <param name="directionDetails">directionDetails.</param>
        /// <param name="latitude">Current latitude of journey.</param>
        /// <param name="longitude">Current longitude of journey.</param>
        public VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel(string detailsReference = default(string), VTApiPlaneraResaWebV4ModelsPositionsLineDetailsApiModel line = default(VTApiPlaneraResaWebV4ModelsPositionsLineDetailsApiModel), List<VTApiPlaneraResaWebV4ModelsNoteApiModel> notes = default(List<VTApiPlaneraResaWebV4ModelsNoteApiModel>), string name = default(string), string direction = default(string), VTApiPlaneraResaWebV4ModelsDirectionDetailsApiModel directionDetails = default(VTApiPlaneraResaWebV4ModelsDirectionDetailsApiModel), double? latitude = default(double?), double? longitude = default(double?))
        {
            this.DetailsReference = detailsReference;
            this.Line = line;
            this.Notes = notes;
            this.Name = name;
            this.Direction = direction;
            this.DirectionDetails = directionDetails;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        /// <summary>
        /// Journey reference
        /// </summary>
        /// <value>Journey reference</value>
        [DataMember(Name = "detailsReference", EmitDefaultValue = true)]
        public string DetailsReference { get; set; }

        /// <summary>
        /// Gets or Sets Line
        /// </summary>
        [DataMember(Name = "line", EmitDefaultValue = false)]
        public VTApiPlaneraResaWebV4ModelsPositionsLineDetailsApiModel Line { get; set; }

        /// <summary>
        /// Journey notes
        /// </summary>
        /// <value>Journey notes</value>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public List<VTApiPlaneraResaWebV4ModelsNoteApiModel> Notes { get; set; }

        /// <summary>
        /// Journey name
        /// </summary>
        /// <value>Journey name</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Journey direction
        /// </summary>
        /// <value>Journey direction</value>
        [DataMember(Name = "direction", EmitDefaultValue = true)]
        public string Direction { get; set; }

        /// <summary>
        /// Gets or Sets DirectionDetails
        /// </summary>
        [DataMember(Name = "directionDetails", EmitDefaultValue = false)]
        public VTApiPlaneraResaWebV4ModelsDirectionDetailsApiModel DirectionDetails { get; set; }

        /// <summary>
        /// Current latitude of journey
        /// </summary>
        /// <value>Current latitude of journey</value>
        [DataMember(Name = "latitude", EmitDefaultValue = true)]
        public double? Latitude { get; set; }

        /// <summary>
        /// Current longitude of journey
        /// </summary>
        /// <value>Current longitude of journey</value>
        [DataMember(Name = "longitude", EmitDefaultValue = true)]
        public double? Longitude { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel {\n");
            sb.Append("  DetailsReference: ").Append(DetailsReference).Append("\n");
            sb.Append("  Line: ").Append(Line).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  DirectionDetails: ").Append(DirectionDetails).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
            return this.Equals(input as VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel);
        }

        /// <summary>
        /// Returns true if VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel instances are equal
        /// </summary>
        /// <param name="input">Instance of VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VTApiPlaneraResaWebV4ModelsPositionsJourneyPositionApiModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DetailsReference == input.DetailsReference ||
                    (this.DetailsReference != null &&
                    this.DetailsReference.Equals(input.DetailsReference))
                ) && 
                (
                    this.Line == input.Line ||
                    (this.Line != null &&
                    this.Line.Equals(input.Line))
                ) && 
                (
                    this.Notes == input.Notes ||
                    this.Notes != null &&
                    input.Notes != null &&
                    this.Notes.SequenceEqual(input.Notes)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.DirectionDetails == input.DirectionDetails ||
                    (this.DirectionDetails != null &&
                    this.DirectionDetails.Equals(input.DirectionDetails))
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
                if (this.DetailsReference != null)
                {
                    hashCode = (hashCode * 59) + this.DetailsReference.GetHashCode();
                }
                if (this.Line != null)
                {
                    hashCode = (hashCode * 59) + this.Line.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Direction != null)
                {
                    hashCode = (hashCode * 59) + this.Direction.GetHashCode();
                }
                if (this.DirectionDetails != null)
                {
                    hashCode = (hashCode * 59) + this.DirectionDetails.GetHashCode();
                }
                if (this.Latitude != null)
                {
                    hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                }
                if (this.Longitude != null)
                {
                    hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
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
