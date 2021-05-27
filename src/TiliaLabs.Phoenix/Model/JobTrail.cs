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
    /// Job trail
    /// </summary>
    [DataContract]
        public partial class JobTrail :  IEquatable<JobTrail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTrail" /> class.
        /// </summary>
        /// <param name="layouts">Trail layouts.</param>
        /// <param name="stats">stats (required).</param>
        /// <param name="jobs">Ordered list of jobs being performed in this trail.</param>
        public JobTrail(List<LayoutRange> layouts = default(List<LayoutRange>), TrailStats stats = default(TrailStats), List<JobInfo> jobs = default(List<JobInfo>))
        {
            // to ensure "stats" is required (not null)
            if (stats == null)
            {
                throw new InvalidDataException("stats is a required property for JobTrail and cannot be null");
            }
            else
            {
                this.Stats = stats;
            }
            this.Layouts = layouts;
            this.Jobs = jobs;
        }
        
        /// <summary>
        /// Unique ID
        /// </summary>
        /// <value>Unique ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// Trail layouts
        /// </summary>
        /// <value>Trail layouts</value>
        [DataMember(Name="layouts", EmitDefaultValue=false)]
        public List<LayoutRange> Layouts { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public TrailStats Stats { get; set; }

        /// <summary>
        /// Ordered list of jobs being performed in this trail
        /// </summary>
        /// <value>Ordered list of jobs being performed in this trail</value>
        [DataMember(Name="jobs", EmitDefaultValue=false)]
        public List<JobInfo> Jobs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobTrail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Layouts: ").Append(Layouts).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  Jobs: ").Append(Jobs).Append("\n");
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
            return this.Equals(input as JobTrail);
        }

        /// <summary>
        /// Returns true if JobTrail instances are equal
        /// </summary>
        /// <param name="input">Instance of JobTrail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobTrail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Layouts == input.Layouts ||
                    this.Layouts != null &&
                    input.Layouts != null &&
                    this.Layouts.SequenceEqual(input.Layouts)
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
                ) && 
                (
                    this.Jobs == input.Jobs ||
                    this.Jobs != null &&
                    input.Jobs != null &&
                    this.Jobs.SequenceEqual(input.Jobs)
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Layouts != null)
                    hashCode = hashCode * 59 + this.Layouts.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.Jobs != null)
                    hashCode = hashCode * 59 + this.Jobs.GetHashCode();
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
