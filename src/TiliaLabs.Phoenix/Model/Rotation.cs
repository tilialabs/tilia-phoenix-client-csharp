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
    /// Rotation settings
    /// </summary>
    [DataContract]
        public partial class Rotation :  IEquatable<Rotation>, IValidatableObject
    {
        /// <summary>
        /// Rotation type setting
        /// </summary>
        /// <value>Rotation type setting</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum RotationTypeEnum
        {
            /// <summary>
            /// Enum Any for value: Any
            /// </summary>
            [EnumMember(Value = "Any")]
            Any = 1,
            /// <summary>
            /// Enum Orthogonal for value: Orthogonal
            /// </summary>
            [EnumMember(Value = "Orthogonal")]
            Orthogonal = 2,
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 3,
            /// <summary>
            /// Enum Custom for value: Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom = 4        }
        /// <summary>
        /// Rotation type setting
        /// </summary>
        /// <value>Rotation type setting</value>
        [DataMember(Name="rotation-type", EmitDefaultValue=false)]
        public RotationTypeEnum? RotationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rotation" /> class.
        /// </summary>
        /// <param name="rotationType">Rotation type setting.</param>
        /// <param name="customValues">Custom rotation values.</param>
        public Rotation(RotationTypeEnum? rotationType = default(RotationTypeEnum?), List<int?> customValues = default(List<int?>))
        {
            this.RotationType = rotationType;
            this.CustomValues = customValues;
        }
        

        /// <summary>
        /// Custom rotation values
        /// </summary>
        /// <value>Custom rotation values</value>
        [DataMember(Name="custom-values", EmitDefaultValue=false)]
        public List<int?> CustomValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rotation {\n");
            sb.Append("  RotationType: ").Append(RotationType).Append("\n");
            sb.Append("  CustomValues: ").Append(CustomValues).Append("\n");
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
            return this.Equals(input as Rotation);
        }

        /// <summary>
        /// Returns true if Rotation instances are equal
        /// </summary>
        /// <param name="input">Instance of Rotation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rotation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RotationType == input.RotationType ||
                    (this.RotationType != null &&
                    this.RotationType.Equals(input.RotationType))
                ) && 
                (
                    this.CustomValues == input.CustomValues ||
                    this.CustomValues != null &&
                    input.CustomValues != null &&
                    this.CustomValues.SequenceEqual(input.CustomValues)
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
                if (this.RotationType != null)
                    hashCode = hashCode * 59 + this.RotationType.GetHashCode();
                if (this.CustomValues != null)
                    hashCode = hashCode * 59 + this.CustomValues.GetHashCode();
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
