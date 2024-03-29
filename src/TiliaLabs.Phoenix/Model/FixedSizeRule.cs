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
    /// Fixed size tiling rule
    /// </summary>
    [DataContract]
    public partial class FixedSizeRule : TilingRule, IEquatable<FixedSizeRule>, IValidatableObject
    {
        /// <summary>
        /// Tiling rule type.  &#x27;FixedNumber&#x27; for fixed number rule, &#x27;FixedSize&#x27; for fixed size rule and &#x27;VariableSizes&#x27; for variable sizes rule
        /// </summary>
        /// <value>Tiling rule type.  &#x27;FixedNumber&#x27; for fixed number rule, &#x27;FixedSize&#x27; for fixed size rule and &#x27;VariableSizes&#x27; for variable sizes rule</value>
        public override TypeEnum Type { get; } = TypeEnum.FixedSize;
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedSizeRule" /> class.
        /// </summary>
        /// <param name="size">Fixed size used to create tiles in the given dimension (required).</param>
        public FixedSizeRule(double? size = default(double?))
        {
            // to ensure "size" is required (not null)
            if (size == null)
            {
                throw new InvalidDataException("size is a required property for FixedSizeRule and cannot be null");
            }
            else
            {
                this.Size = size;
            }
        }
        
        /// <summary>
        /// Fixed size used to create tiles in the given dimension
        /// </summary>
        /// <value>Fixed size used to create tiles in the given dimension</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public double? Size { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FixedSizeRule {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FixedSizeRule);
        }

        /// <summary>
        /// Returns true if FixedSizeRule instances are equal
        /// </summary>
        /// <param name="input">Instance of FixedSizeRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FixedSizeRule input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                int hashCode = base.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
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
