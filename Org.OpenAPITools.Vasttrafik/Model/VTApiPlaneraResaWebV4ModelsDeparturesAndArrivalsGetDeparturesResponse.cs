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
    /// The response to a get departures request, includes the results and pagination information.
    /// </summary>
    [DataContract(Name = "VT.ApiPlaneraResa.Web.V4.Models.DeparturesAndArrivals.GetDeparturesResponse")]
    public partial class VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsGetDeparturesResponse : IEquatable<VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsGetDeparturesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsGetDeparturesResponse" /> class.
        /// </summary>
        /// <param name="results">The results..</param>
        /// <param name="pagination">pagination.</param>
        /// <param name="links">links.</param>
        public VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsGetDeparturesResponse(List<VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsDepartureApiModel> results = default(List<VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsDepartureApiModel>), VTApiPlaneraResaWebV4ModelsPaginationProperties pagination = default(VTApiPlaneraResaWebV4ModelsPaginationProperties), VTApiPlaneraResaWebV4ModelsPaginationLinks links = default(VTApiPlaneraResaWebV4ModelsPaginationLinks))
        {
            this.Results = results;
            this.Pagination = pagination;
            this.Links = links;
        }

        /// <summary>
        /// The results.
        /// </summary>
        /// <value>The results.</value>
        [DataMember(Name = "results", EmitDefaultValue = true)]
        public List<VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsDepartureApiModel> Results { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name = "pagination", EmitDefaultValue = false)]
        public VTApiPlaneraResaWebV4ModelsPaginationProperties Pagination { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public VTApiPlaneraResaWebV4ModelsPaginationLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsGetDeparturesResponse {\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsGetDeparturesResponse);
        }

        /// <summary>
        /// Returns true if VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsGetDeparturesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsGetDeparturesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VTApiPlaneraResaWebV4ModelsDeparturesAndArrivalsGetDeparturesResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
                }
                if (this.Pagination != null)
                {
                    hashCode = (hashCode * 59) + this.Pagination.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
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
