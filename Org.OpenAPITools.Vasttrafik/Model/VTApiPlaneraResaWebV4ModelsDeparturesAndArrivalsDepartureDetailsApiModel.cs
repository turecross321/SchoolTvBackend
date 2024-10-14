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
    /// VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsDepartureDetailsApiModel
    /// </summary>
    [DataContract(Name = "VT.ApiPlaneraResa.Web.V4.Models.DeparturesAndArrivals.DepartureDetailsApiModel")]
    public partial class VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsDepartureDetailsApiModel : IEquatable<VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsDepartureDetailsApiModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsDepartureDetailsApiModel" /> class.
        /// </summary>
        /// <param name="serviceJourneys">serviceJourneys.</param>
        /// <param name="occupancy">occupancy.</param>
        public VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsDepartureDetailsApiModel(List<VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsServiceJourneyDetailsApiModel> serviceJourneys = default(List<VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsServiceJourneyDetailsApiModel>), VTApiPlaneraResaWebV4ModelsOccupancyInformationApiModel occupancy = default(VTApiPlaneraResaWebV4ModelsOccupancyInformationApiModel))
        {
            this.ServiceJourneys = serviceJourneys;
            this.Occupancy = occupancy;
        }

        /// <summary>
        /// Gets or Sets ServiceJourneys
        /// </summary>
        [DataMember(Name = "serviceJourneys", EmitDefaultValue = true)]
        public List<VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsServiceJourneyDetailsApiModel> ServiceJourneys { get; set; }

        /// <summary>
        /// Gets or Sets Occupancy
        /// </summary>
        [DataMember(Name = "occupancy", EmitDefaultValue = false)]
        public VTApiPlaneraResaWebV4ModelsOccupancyInformationApiModel Occupancy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsDepartureDetailsApiModel {\n");
            sb.Append("  ServiceJourneys: ").Append(ServiceJourneys).Append("\n");
            sb.Append("  Occupancy: ").Append(Occupancy).Append("\n");
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
            return this.Equals(input as VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsDepartureDetailsApiModel);
        }

        /// <summary>
        /// Returns true if VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsDepartureDetailsApiModel instances are equal
        /// </summary>
        /// <param name="input">Instance of VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsDepartureDetailsApiModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsDepartureDetailsApiModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ServiceJourneys == input.ServiceJourneys ||
                    this.ServiceJourneys != null &&
                    input.ServiceJourneys != null &&
                    this.ServiceJourneys.SequenceEqual(input.ServiceJourneys)
                ) && 
                (
                    this.Occupancy == input.Occupancy ||
                    (this.Occupancy != null &&
                    this.Occupancy.Equals(input.Occupancy))
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
                if (this.ServiceJourneys != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceJourneys.GetHashCode();
                }
                if (this.Occupancy != null)
                {
                    hashCode = (hashCode * 59) + this.Occupancy.GetHashCode();
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
