/*
 * Planera Resa
 *
 * Sök och planera resor med Västtrafik
 *
 * The version of the OpenAPI document: v4
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Information about a walk, bike or car link from last public transport trip leg to destination.
    /// </summary>
    [DataContract(Name = "VT.ApiPlaneraResa.Web.V4.Models.JourneyDetails.ArrivalAccessLinkApiModel")]
    public partial class VTApiPlaneraResaWebV4ModelsJourneyDetailsArrivalAccessLinkApiModel : IEquatable<VTApiPlaneraResaWebV4ModelsJourneyDetailsArrivalAccessLinkApiModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TransportMode
        /// </summary>
        [DataMember(Name = "transportMode", EmitDefaultValue = false)]
        public VTApiPlaneraResaWebV4ModelsTransportMode? TransportMode { get; set; }

        /// <summary>
        /// Gets or Sets TransportSubMode
        /// </summary>
        [DataMember(Name = "transportSubMode", EmitDefaultValue = false)]
        public VTApiPlaneraResaWebV4ModelsTransportSubMode? TransportSubMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VTApiPlaneraResaWebV4ModelsJourneyDetailsArrivalAccessLinkApiModel" /> class.
        /// </summary>
        /// <param name="transportMode">transportMode.</param>
        /// <param name="transportSubMode">transportSubMode.</param>
        /// <param name="origin">origin.</param>
        /// <param name="destination">destination.</param>
        /// <param name="notes">An ordered list (most important first) of notes related to the access link..</param>
        /// <param name="distanceInMeters">Distance in meters..</param>
        /// <param name="plannedDepartureTime">The planned departure time in RFC 3339 format..</param>
        /// <param name="plannedArrivalTime">The planned arrival time in RFC 3339 format..</param>
        /// <param name="plannedDurationInMinutes">The planned duration in minutes..</param>
        /// <param name="estimatedDepartureTime">The estimated departure time in RFC 3339 format, if available..</param>
        /// <param name="estimatedArrivalTime">The estimated arrival time in RFC 3339 format, if available..</param>
        /// <param name="estimatedDurationInMinutes">The estimated duration in minutes, if available..</param>
        /// <param name="estimatedNumberOfSteps">Number of steps based on the distance and an estimated step length of 0.65 meters..</param>
        /// <param name="linkCoordinates">The coordinates for the link..</param>
        /// <param name="segments">The segments that make up this link..</param>
        public VTApiPlaneraResaWebV4ModelsJourneyDetailsArrivalAccessLinkApiModel(VTApiPlaneraResaWebV4ModelsTransportMode? transportMode = default(VTApiPlaneraResaWebV4ModelsTransportMode?), VTApiPlaneraResaWebV4ModelsTransportSubMode? transportSubMode = default(VTApiPlaneraResaWebV4ModelsTransportSubMode?), VTApiPlaneraResaWebV4ModelsJourneyDetailsCallApiModel origin = default(VTApiPlaneraResaWebV4ModelsJourneyDetailsCallApiModel), VTApiPlaneraResaWebV4ModelsJourneyDetailsLinkEndpointApiModel destination = default(VTApiPlaneraResaWebV4ModelsJourneyDetailsLinkEndpointApiModel), List<VTApiPlaneraResaWebV4ModelsNoteApiModel> notes = default(List<VTApiPlaneraResaWebV4ModelsNoteApiModel>), int? distanceInMeters = default(int?), string plannedDepartureTime = default(string), string plannedArrivalTime = default(string), int? plannedDurationInMinutes = default(int?), string estimatedDepartureTime = default(string), string estimatedArrivalTime = default(string), int? estimatedDurationInMinutes = default(int?), int? estimatedNumberOfSteps = default(int?), List<VTApiPlaneraResaWebV4ModelsCoordinateApiModel> linkCoordinates = default(List<VTApiPlaneraResaWebV4ModelsCoordinateApiModel>), List<VTApiPlaneraResaWebV4ModelsJourneyDetailsLinkSegmentApiModel> segments = default(List<VTApiPlaneraResaWebV4ModelsJourneyDetailsLinkSegmentApiModel>))
        {
            this.TransportMode = transportMode;
            this.TransportSubMode = transportSubMode;
            this.Origin = origin;
            this.Destination = destination;
            this.Notes = notes;
            this.DistanceInMeters = distanceInMeters;
            this.PlannedDepartureTime = plannedDepartureTime;
            this.PlannedArrivalTime = plannedArrivalTime;
            this.PlannedDurationInMinutes = plannedDurationInMinutes;
            this.EstimatedDepartureTime = estimatedDepartureTime;
            this.EstimatedArrivalTime = estimatedArrivalTime;
            this.EstimatedDurationInMinutes = estimatedDurationInMinutes;
            this.EstimatedNumberOfSteps = estimatedNumberOfSteps;
            this.LinkCoordinates = linkCoordinates;
            this.Segments = segments;
        }

        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [DataMember(Name = "origin", EmitDefaultValue = false)]
        public VTApiPlaneraResaWebV4ModelsJourneyDetailsCallApiModel Origin { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name = "destination", EmitDefaultValue = false)]
        public VTApiPlaneraResaWebV4ModelsJourneyDetailsLinkEndpointApiModel Destination { get; set; }

        /// <summary>
        /// An ordered list (most important first) of notes related to the access link.
        /// </summary>
        /// <value>An ordered list (most important first) of notes related to the access link.</value>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public List<VTApiPlaneraResaWebV4ModelsNoteApiModel> Notes { get; set; }

        /// <summary>
        /// Distance in meters.
        /// </summary>
        /// <value>Distance in meters.</value>
        [DataMember(Name = "distanceInMeters", EmitDefaultValue = true)]
        public int? DistanceInMeters { get; set; }

        /// <summary>
        /// The planned departure time in RFC 3339 format.
        /// </summary>
        /// <value>The planned departure time in RFC 3339 format.</value>
        [DataMember(Name = "plannedDepartureTime", EmitDefaultValue = true)]
        public string PlannedDepartureTime { get; set; }

        /// <summary>
        /// The planned arrival time in RFC 3339 format.
        /// </summary>
        /// <value>The planned arrival time in RFC 3339 format.</value>
        [DataMember(Name = "plannedArrivalTime", EmitDefaultValue = true)]
        public string PlannedArrivalTime { get; set; }

        /// <summary>
        /// The planned duration in minutes.
        /// </summary>
        /// <value>The planned duration in minutes.</value>
        [DataMember(Name = "plannedDurationInMinutes", EmitDefaultValue = true)]
        public int? PlannedDurationInMinutes { get; set; }

        /// <summary>
        /// The estimated departure time in RFC 3339 format, if available.
        /// </summary>
        /// <value>The estimated departure time in RFC 3339 format, if available.</value>
        [DataMember(Name = "estimatedDepartureTime", EmitDefaultValue = true)]
        public string EstimatedDepartureTime { get; set; }

        /// <summary>
        /// The estimated arrival time in RFC 3339 format, if available.
        /// </summary>
        /// <value>The estimated arrival time in RFC 3339 format, if available.</value>
        [DataMember(Name = "estimatedArrivalTime", EmitDefaultValue = true)]
        public string EstimatedArrivalTime { get; set; }

        /// <summary>
        /// The estimated duration in minutes, if available.
        /// </summary>
        /// <value>The estimated duration in minutes, if available.</value>
        [DataMember(Name = "estimatedDurationInMinutes", EmitDefaultValue = true)]
        public int? EstimatedDurationInMinutes { get; set; }

        /// <summary>
        /// Number of steps based on the distance and an estimated step length of 0.65 meters.
        /// </summary>
        /// <value>Number of steps based on the distance and an estimated step length of 0.65 meters.</value>
        [DataMember(Name = "estimatedNumberOfSteps", EmitDefaultValue = true)]
        public int? EstimatedNumberOfSteps { get; set; }

        /// <summary>
        /// The coordinates for the link.
        /// </summary>
        /// <value>The coordinates for the link.</value>
        [DataMember(Name = "linkCoordinates", EmitDefaultValue = true)]
        public List<VTApiPlaneraResaWebV4ModelsCoordinateApiModel> LinkCoordinates { get; set; }

        /// <summary>
        /// The segments that make up this link.
        /// </summary>
        /// <value>The segments that make up this link.</value>
        [DataMember(Name = "segments", EmitDefaultValue = true)]
        public List<VTApiPlaneraResaWebV4ModelsJourneyDetailsLinkSegmentApiModel> Segments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VTApiPlaneraResaWebV4ModelsJourneyDetailsArrivalAccessLinkApiModel {\n");
            sb.Append("  TransportMode: ").Append(TransportMode).Append("\n");
            sb.Append("  TransportSubMode: ").Append(TransportSubMode).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  DistanceInMeters: ").Append(DistanceInMeters).Append("\n");
            sb.Append("  PlannedDepartureTime: ").Append(PlannedDepartureTime).Append("\n");
            sb.Append("  PlannedArrivalTime: ").Append(PlannedArrivalTime).Append("\n");
            sb.Append("  PlannedDurationInMinutes: ").Append(PlannedDurationInMinutes).Append("\n");
            sb.Append("  EstimatedDepartureTime: ").Append(EstimatedDepartureTime).Append("\n");
            sb.Append("  EstimatedArrivalTime: ").Append(EstimatedArrivalTime).Append("\n");
            sb.Append("  EstimatedDurationInMinutes: ").Append(EstimatedDurationInMinutes).Append("\n");
            sb.Append("  EstimatedNumberOfSteps: ").Append(EstimatedNumberOfSteps).Append("\n");
            sb.Append("  LinkCoordinates: ").Append(LinkCoordinates).Append("\n");
            sb.Append("  Segments: ").Append(Segments).Append("\n");
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
            return this.Equals(input as VTApiPlaneraResaWebV4ModelsJourneyDetailsArrivalAccessLinkApiModel);
        }

        /// <summary>
        /// Returns true if VTApiPlaneraResaWebV4ModelsJourneyDetailsArrivalAccessLinkApiModel instances are equal
        /// </summary>
        /// <param name="input">Instance of VTApiPlaneraResaWebV4ModelsJourneyDetailsArrivalAccessLinkApiModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VTApiPlaneraResaWebV4ModelsJourneyDetailsArrivalAccessLinkApiModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransportMode == input.TransportMode ||
                    this.TransportMode.Equals(input.TransportMode)
                ) && 
                (
                    this.TransportSubMode == input.TransportSubMode ||
                    this.TransportSubMode.Equals(input.TransportSubMode)
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Notes == input.Notes ||
                    this.Notes != null &&
                    input.Notes != null &&
                    this.Notes.SequenceEqual(input.Notes)
                ) && 
                (
                    this.DistanceInMeters == input.DistanceInMeters ||
                    (this.DistanceInMeters != null &&
                    this.DistanceInMeters.Equals(input.DistanceInMeters))
                ) && 
                (
                    this.PlannedDepartureTime == input.PlannedDepartureTime ||
                    (this.PlannedDepartureTime != null &&
                    this.PlannedDepartureTime.Equals(input.PlannedDepartureTime))
                ) && 
                (
                    this.PlannedArrivalTime == input.PlannedArrivalTime ||
                    (this.PlannedArrivalTime != null &&
                    this.PlannedArrivalTime.Equals(input.PlannedArrivalTime))
                ) && 
                (
                    this.PlannedDurationInMinutes == input.PlannedDurationInMinutes ||
                    (this.PlannedDurationInMinutes != null &&
                    this.PlannedDurationInMinutes.Equals(input.PlannedDurationInMinutes))
                ) && 
                (
                    this.EstimatedDepartureTime == input.EstimatedDepartureTime ||
                    (this.EstimatedDepartureTime != null &&
                    this.EstimatedDepartureTime.Equals(input.EstimatedDepartureTime))
                ) && 
                (
                    this.EstimatedArrivalTime == input.EstimatedArrivalTime ||
                    (this.EstimatedArrivalTime != null &&
                    this.EstimatedArrivalTime.Equals(input.EstimatedArrivalTime))
                ) && 
                (
                    this.EstimatedDurationInMinutes == input.EstimatedDurationInMinutes ||
                    (this.EstimatedDurationInMinutes != null &&
                    this.EstimatedDurationInMinutes.Equals(input.EstimatedDurationInMinutes))
                ) && 
                (
                    this.EstimatedNumberOfSteps == input.EstimatedNumberOfSteps ||
                    (this.EstimatedNumberOfSteps != null &&
                    this.EstimatedNumberOfSteps.Equals(input.EstimatedNumberOfSteps))
                ) && 
                (
                    this.LinkCoordinates == input.LinkCoordinates ||
                    this.LinkCoordinates != null &&
                    input.LinkCoordinates != null &&
                    this.LinkCoordinates.SequenceEqual(input.LinkCoordinates)
                ) && 
                (
                    this.Segments == input.Segments ||
                    this.Segments != null &&
                    input.Segments != null &&
                    this.Segments.SequenceEqual(input.Segments)
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
                hashCode = (hashCode * 59) + this.TransportMode.GetHashCode();
                hashCode = (hashCode * 59) + this.TransportSubMode.GetHashCode();
                if (this.Origin != null)
                {
                    hashCode = (hashCode * 59) + this.Origin.GetHashCode();
                }
                if (this.Destination != null)
                {
                    hashCode = (hashCode * 59) + this.Destination.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.DistanceInMeters != null)
                {
                    hashCode = (hashCode * 59) + this.DistanceInMeters.GetHashCode();
                }
                if (this.PlannedDepartureTime != null)
                {
                    hashCode = (hashCode * 59) + this.PlannedDepartureTime.GetHashCode();
                }
                if (this.PlannedArrivalTime != null)
                {
                    hashCode = (hashCode * 59) + this.PlannedArrivalTime.GetHashCode();
                }
                if (this.PlannedDurationInMinutes != null)
                {
                    hashCode = (hashCode * 59) + this.PlannedDurationInMinutes.GetHashCode();
                }
                if (this.EstimatedDepartureTime != null)
                {
                    hashCode = (hashCode * 59) + this.EstimatedDepartureTime.GetHashCode();
                }
                if (this.EstimatedArrivalTime != null)
                {
                    hashCode = (hashCode * 59) + this.EstimatedArrivalTime.GetHashCode();
                }
                if (this.EstimatedDurationInMinutes != null)
                {
                    hashCode = (hashCode * 59) + this.EstimatedDurationInMinutes.GetHashCode();
                }
                if (this.EstimatedNumberOfSteps != null)
                {
                    hashCode = (hashCode * 59) + this.EstimatedNumberOfSteps.GetHashCode();
                }
                if (this.LinkCoordinates != null)
                {
                    hashCode = (hashCode * 59) + this.LinkCoordinates.GetHashCode();
                }
                if (this.Segments != null)
                {
                    hashCode = (hashCode * 59) + this.Segments.GetHashCode();
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
