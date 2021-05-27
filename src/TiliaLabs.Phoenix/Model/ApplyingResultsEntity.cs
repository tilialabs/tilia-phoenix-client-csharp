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
    /// Actions to apply after Imposition AI results are applied to the job
    /// </summary>
    [DataContract]
        public partial class ApplyingResultsEntity :  IEquatable<ApplyingResultsEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyingResultsEntity" /> class.
        /// </summary>
        /// <param name="splitOverlapsOnApply">Split bleed overlaps on apply.</param>
        /// <param name="groupProductsOnApply">Group products on apply.</param>
        /// <param name="ensureMarginsPlacement">Ensure margins placement.</param>
        public ApplyingResultsEntity(bool? splitOverlapsOnApply = default(bool?), bool? groupProductsOnApply = default(bool?), bool? ensureMarginsPlacement = default(bool?))
        {
            this.SplitOverlapsOnApply = splitOverlapsOnApply;
            this.GroupProductsOnApply = groupProductsOnApply;
            this.EnsureMarginsPlacement = ensureMarginsPlacement;
        }
        
        /// <summary>
        /// Split bleed overlaps on apply
        /// </summary>
        /// <value>Split bleed overlaps on apply</value>
        [DataMember(Name="split-overlaps-on-apply", EmitDefaultValue=false)]
        public bool? SplitOverlapsOnApply { get; set; }

        /// <summary>
        /// Group products on apply
        /// </summary>
        /// <value>Group products on apply</value>
        [DataMember(Name="group-products-on-apply", EmitDefaultValue=false)]
        public bool? GroupProductsOnApply { get; set; }

        /// <summary>
        /// Ensure margins placement
        /// </summary>
        /// <value>Ensure margins placement</value>
        [DataMember(Name="ensure-margins-placement", EmitDefaultValue=false)]
        public bool? EnsureMarginsPlacement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyingResultsEntity {\n");
            sb.Append("  SplitOverlapsOnApply: ").Append(SplitOverlapsOnApply).Append("\n");
            sb.Append("  GroupProductsOnApply: ").Append(GroupProductsOnApply).Append("\n");
            sb.Append("  EnsureMarginsPlacement: ").Append(EnsureMarginsPlacement).Append("\n");
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
            return this.Equals(input as ApplyingResultsEntity);
        }

        /// <summary>
        /// Returns true if ApplyingResultsEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplyingResultsEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplyingResultsEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SplitOverlapsOnApply == input.SplitOverlapsOnApply ||
                    (this.SplitOverlapsOnApply != null &&
                    this.SplitOverlapsOnApply.Equals(input.SplitOverlapsOnApply))
                ) && 
                (
                    this.GroupProductsOnApply == input.GroupProductsOnApply ||
                    (this.GroupProductsOnApply != null &&
                    this.GroupProductsOnApply.Equals(input.GroupProductsOnApply))
                ) && 
                (
                    this.EnsureMarginsPlacement == input.EnsureMarginsPlacement ||
                    (this.EnsureMarginsPlacement != null &&
                    this.EnsureMarginsPlacement.Equals(input.EnsureMarginsPlacement))
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
                if (this.SplitOverlapsOnApply != null)
                    hashCode = hashCode * 59 + this.SplitOverlapsOnApply.GetHashCode();
                if (this.GroupProductsOnApply != null)
                    hashCode = hashCode * 59 + this.GroupProductsOnApply.GetHashCode();
                if (this.EnsureMarginsPlacement != null)
                    hashCode = hashCode * 59 + this.EnsureMarginsPlacement.GetHashCode();
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
