/* 
 * tilia Phoenix API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 7.0.6
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = TiliaLabs.Phoenix.Client.SwaggerDateConverter;

namespace TiliaLabs.Phoenix.Model
{
    /// <summary>
    /// Trail-level aggregate stats
    /// </summary>
    [DataContract]
        public partial class TrailStats :  IEquatable<TrailStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrailStats" /> class.
        /// </summary>
        /// <param name="time">time (required).</param>
        /// <param name="cost">cost (required).</param>
        /// <param name="processStats">Per-process stats.</param>
        /// <param name="totalLayouts">Total number of layouts needed including ordered run lengths, setup layouts, and waste layouts.</param>
        /// <param name="setupLayouts">Total number of setup layouts.</param>
        /// <param name="wasteLayouts">Total number of waste layouts during processing.</param>
        public TrailStats(TimeInfo time = default(TimeInfo), CostInfo cost = default(CostInfo), List<ProcessStats> processStats = default(List<ProcessStats>), int? totalLayouts = default(int?), int? setupLayouts = default(int?), int? wasteLayouts = default(int?))
        {
            // to ensure "time" is required (not null)
            if (time == null)
            {
                throw new InvalidDataException("time is a required property for TrailStats and cannot be null");
            }
            else
            {
                this.Time = time;
            }
            // to ensure "cost" is required (not null)
            if (cost == null)
            {
                throw new InvalidDataException("cost is a required property for TrailStats and cannot be null");
            }
            else
            {
                this.Cost = cost;
            }
            this.ProcessStats = processStats;
            this.TotalLayouts = totalLayouts;
            this.SetupLayouts = setupLayouts;
            this.WasteLayouts = wasteLayouts;
        }
        
        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public TimeInfo Time { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public CostInfo Cost { get; set; }

        /// <summary>
        /// Per-process stats
        /// </summary>
        /// <value>Per-process stats</value>
        [DataMember(Name="process-stats", EmitDefaultValue=false)]
        public List<ProcessStats> ProcessStats { get; set; }

        /// <summary>
        /// Total number of layouts needed including ordered run lengths, setup layouts, and waste layouts
        /// </summary>
        /// <value>Total number of layouts needed including ordered run lengths, setup layouts, and waste layouts</value>
        [DataMember(Name="total-layouts", EmitDefaultValue=false)]
        public int? TotalLayouts { get; set; }

        /// <summary>
        /// Total number of setup layouts
        /// </summary>
        /// <value>Total number of setup layouts</value>
        [DataMember(Name="setup-layouts", EmitDefaultValue=false)]
        public int? SetupLayouts { get; set; }

        /// <summary>
        /// Total number of waste layouts during processing
        /// </summary>
        /// <value>Total number of waste layouts during processing</value>
        [DataMember(Name="waste-layouts", EmitDefaultValue=false)]
        public int? WasteLayouts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrailStats {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  ProcessStats: ").Append(ProcessStats).Append("\n");
            sb.Append("  TotalLayouts: ").Append(TotalLayouts).Append("\n");
            sb.Append("  SetupLayouts: ").Append(SetupLayouts).Append("\n");
            sb.Append("  WasteLayouts: ").Append(WasteLayouts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrailStats);
        }

        /// <summary>
        /// Returns true if TrailStats instances are equal
        /// </summary>
        /// <param name="input">Instance of TrailStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrailStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.ProcessStats == input.ProcessStats ||
                    this.ProcessStats != null &&
                    input.ProcessStats != null &&
                    this.ProcessStats.SequenceEqual(input.ProcessStats)
                ) && 
                (
                    this.TotalLayouts == input.TotalLayouts ||
                    (this.TotalLayouts != null &&
                    this.TotalLayouts.Equals(input.TotalLayouts))
                ) && 
                (
                    this.SetupLayouts == input.SetupLayouts ||
                    (this.SetupLayouts != null &&
                    this.SetupLayouts.Equals(input.SetupLayouts))
                ) && 
                (
                    this.WasteLayouts == input.WasteLayouts ||
                    (this.WasteLayouts != null &&
                    this.WasteLayouts.Equals(input.WasteLayouts))
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.ProcessStats != null)
                    hashCode = hashCode * 59 + this.ProcessStats.GetHashCode();
                if (this.TotalLayouts != null)
                    hashCode = hashCode * 59 + this.TotalLayouts.GetHashCode();
                if (this.SetupLayouts != null)
                    hashCode = hashCode * 59 + this.SetupLayouts.GetHashCode();
                if (this.WasteLayouts != null)
                    hashCode = hashCode * 59 + this.WasteLayouts.GetHashCode();
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
