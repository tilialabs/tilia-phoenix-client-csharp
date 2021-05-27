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
    /// Variable sizes tiling rule
    /// </summary>
    [DataContract]
        public partial class VariableSizesRule :  IEquatable<VariableSizesRule>, IValidatableObject
    {
        /// <summary>
        /// Tiling rule type.  &#x27;FixedNumber&#x27; for fixed number rule, &#x27;FixedSize&#x27; for fixed size rule and &#x27;VariableSizes&#x27; for variable sizes rule
        /// </summary>
        /// <value>Tiling rule type.  &#x27;FixedNumber&#x27; for fixed number rule, &#x27;FixedSize&#x27; for fixed size rule and &#x27;VariableSizes&#x27; for variable sizes rule</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            /// <summary>
            /// Enum FixedNumber for value: Fixed Number
            /// </summary>
            [EnumMember(Value = "Fixed Number")]
            FixedNumber = 2,
            /// <summary>
            /// Enum FixedSize for value: Fixed Size
            /// </summary>
            [EnumMember(Value = "Fixed Size")]
            FixedSize = 3,
            /// <summary>
            /// Enum VariableSizes for value: Variable Sizes
            /// </summary>
            [EnumMember(Value = "Variable Sizes")]
            VariableSizes = 4        }
        /// <summary>
        /// Tiling rule type.  &#x27;FixedNumber&#x27; for fixed number rule, &#x27;FixedSize&#x27; for fixed size rule and &#x27;VariableSizes&#x27; for variable sizes rule
        /// </summary>
        /// <value>Tiling rule type.  &#x27;FixedNumber&#x27; for fixed number rule, &#x27;FixedSize&#x27; for fixed size rule and &#x27;VariableSizes&#x27; for variable sizes rule</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableSizesRule" /> class.
        /// </summary>
        /// <param name="sizes">Custom sizes to use to create tiles in the given dimension (required).</param>
        /// <param name="type">Tiling rule type.  &#x27;FixedNumber&#x27; for fixed number rule, &#x27;FixedSize&#x27; for fixed size rule and &#x27;VariableSizes&#x27; for variable sizes rule (required).</param>
        public VariableSizesRule(List<double?> sizes = default(List<double?>), TypeEnum type = default(TypeEnum))
        {
            // to ensure "sizes" is required (not null)
            if (sizes == null)
            {
                throw new InvalidDataException("sizes is a required property for VariableSizesRule and cannot be null");
            }
            else
            {
                this.Sizes = sizes;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for VariableSizesRule and cannot be null");
            }
            else
            {
                this.Type = type;
            }
        }
        
        /// <summary>
        /// Custom sizes to use to create tiles in the given dimension
        /// </summary>
        /// <value>Custom sizes to use to create tiles in the given dimension</value>
        [DataMember(Name="sizes", EmitDefaultValue=false)]
        public List<double?> Sizes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableSizesRule {\n");
            sb.Append("  Sizes: ").Append(Sizes).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as VariableSizesRule);
        }

        /// <summary>
        /// Returns true if VariableSizesRule instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableSizesRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableSizesRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sizes == input.Sizes ||
                    this.Sizes != null &&
                    input.Sizes != null &&
                    this.Sizes.SequenceEqual(input.Sizes)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Sizes != null)
                    hashCode = hashCode * 59 + this.Sizes.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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