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
    /// Tile edge
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
        public partial class TileEdge :  IEquatable<TileEdge>, IValidatableObject
    {
        /// <summary>
        /// Tiling edge type.  &#x27;GapEdge&#x27; for gaps and &#x27;OverlapEdge&#x27; for overlap edge type
        /// </summary>
        /// <value>Tiling edge type.  &#x27;GapEdge&#x27; for gaps and &#x27;OverlapEdge&#x27; for overlap edge type</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum GapEdge for value: GapEdge
            /// </summary>
            [EnumMember(Value = "GapEdge")]
            GapEdge = 1,
            /// <summary>
            /// Enum OverlapEdge for value: OverlapEdge
            /// </summary>
            [EnumMember(Value = "OverlapEdge")]
            OverlapEdge = 2        }
        /// <summary>
        /// Tiling edge type.  &#x27;GapEdge&#x27; for gaps and &#x27;OverlapEdge&#x27; for overlap edge type
        /// </summary>
        /// <value>Tiling edge type.  &#x27;GapEdge&#x27; for gaps and &#x27;OverlapEdge&#x27; for overlap edge type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TileEdge" /> class.
        /// </summary>
        /// <param name="type">Tiling edge type.  &#x27;GapEdge&#x27; for gaps and &#x27;OverlapEdge&#x27; for overlap edge type (required).</param>
        public TileEdge(TypeEnum type = default(TypeEnum))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for TileEdge and cannot be null");
            }
            else
            {
                this.Type = type;
            }
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TileEdge {\n");
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
            return this.Equals(input as TileEdge);
        }

        /// <summary>
        /// Returns true if TileEdge instances are equal
        /// </summary>
        /// <param name="input">Instance of TileEdge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TileEdge input)
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