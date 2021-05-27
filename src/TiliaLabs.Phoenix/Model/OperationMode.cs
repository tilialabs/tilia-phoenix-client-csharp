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
    /// Operation Mode
    /// </summary>
    [DataContract]
        public partial class OperationMode :  IEquatable<OperationMode>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum OperationMode for value: OperationMode
            /// </summary>
            [EnumMember(Value = "OperationMode")]
            OperationMode = 1,
            /// <summary>
            /// Enum MediaRule for value: MediaRule
            /// </summary>
            [EnumMember(Value = "MediaRule")]
            MediaRule = 2,
            /// <summary>
            /// Enum PressMediaRule for value: PressMediaRule
            /// </summary>
            [EnumMember(Value = "PressMediaRule")]
            PressMediaRule = 3,
            /// <summary>
            /// Enum DctRuleValue for value: DctRuleValue
            /// </summary>
            [EnumMember(Value = "DctRuleValue")]
            DctRuleValue = 4,
            /// <summary>
            /// Enum SteelRule for value: SteelRule
            /// </summary>
            [EnumMember(Value = "SteelRule")]
            SteelRule = 5        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationMode" /> class.
        /// </summary>
        /// <param name="inkCost">inkCost (required).</param>
        /// <param name="speed">speed (required).</param>
        /// <param name="type">type (required).</param>
        public OperationMode(InkCost inkCost = default(InkCost), Speed speed = default(Speed), TypeEnum type = default(TypeEnum))
        {
            // to ensure "inkCost" is required (not null)
            if (inkCost == null)
            {
                throw new InvalidDataException("inkCost is a required property for OperationMode and cannot be null");
            }
            else
            {
                this.InkCost = inkCost;
            }
            // to ensure "speed" is required (not null)
            if (speed == null)
            {
                throw new InvalidDataException("speed is a required property for OperationMode and cannot be null");
            }
            else
            {
                this.Speed = speed;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for OperationMode and cannot be null");
            }
            else
            {
                this.Type = type;
            }
        }
        
        /// <summary>
        /// Gets or Sets InkCost
        /// </summary>
        [DataMember(Name="ink-cost", EmitDefaultValue=false)]
        public InkCost InkCost { get; set; }

        /// <summary>
        /// Gets or Sets Speed
        /// </summary>
        [DataMember(Name="speed", EmitDefaultValue=false)]
        public Speed Speed { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationMode {\n");
            sb.Append("  InkCost: ").Append(InkCost).Append("\n");
            sb.Append("  Speed: ").Append(Speed).Append("\n");
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
            return this.Equals(input as OperationMode);
        }

        /// <summary>
        /// Returns true if OperationMode instances are equal
        /// </summary>
        /// <param name="input">Instance of OperationMode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperationMode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InkCost == input.InkCost ||
                    (this.InkCost != null &&
                    this.InkCost.Equals(input.InkCost))
                ) && 
                (
                    this.Speed == input.Speed ||
                    (this.Speed != null &&
                    this.Speed.Equals(input.Speed))
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
                if (this.InkCost != null)
                    hashCode = hashCode * 59 + this.InkCost.GetHashCode();
                if (this.Speed != null)
                    hashCode = hashCode * 59 + this.Speed.GetHashCode();
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