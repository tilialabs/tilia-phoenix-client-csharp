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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = TiliaLabs.Phoenix.Client.SwaggerDateConverter;

namespace TiliaLabs.Phoenix.Model
{
    /// <summary>
    /// Tiling method
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(GapTiling), TypeEnum.Gap)]
    [JsonSubtypes.KnownSubType(typeof(OverlapTiling), TypeEnum.Overlap)]
    public abstract class TilingMethod :  IEquatable<TilingMethod>, IValidatableObject
    {
        /// <summary>
        /// Tiling method type.  &#x27;Gap&#x27; for tile gap rule and &#x27;Overlap&#x27; for tile overlap rule type
        /// </summary>
        /// <value>Tiling method type.  &#x27;Gap&#x27; for tile gap rule and &#x27;Overlap&#x27; for tile overlap rule type</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            /// <summary>
            /// Enum Gap for value: Gap
            /// </summary>
            [EnumMember(Value = "Gap")]
            Gap = 2,
            /// <summary>
            /// Enum Overlap for value: Overlap
            /// </summary>
            [EnumMember(Value = "Overlap")]
            Overlap = 3        }
        /// <summary>
        /// Tiling method type.  &#x27;Gap&#x27; for tile gap rule and &#x27;Overlap&#x27; for tile overlap rule type
        /// </summary>
        /// <value>Tiling method type.  &#x27;Gap&#x27; for tile gap rule and &#x27;Overlap&#x27; for tile overlap rule type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public virtual TypeEnum Type { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TilingMethod {\n");
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
            return this.Equals(input as TilingMethod);
        }

        /// <summary>
        /// Returns true if TilingMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of TilingMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TilingMethod input)
        {
            if (input == null)
                return false;

            return 
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
