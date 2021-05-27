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
    /// Speed
    /// </summary>
    [DataContract]
        public partial class Speed :  IEquatable<Speed>, IValidatableObject
    {
        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Fixed for value: Fixed
            /// </summary>
            [EnumMember(Value = "Fixed")]
            Fixed = 1,
            /// <summary>
            /// Enum Stepped for value: Stepped
            /// </summary>
            [EnumMember(Value = "Stepped")]
            Stepped = 2        }
        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Speed" /> class.
        /// </summary>
        /// <param name="type">Type (required).</param>
        /// <param name="speedUnits">speedUnits (required).</param>
        /// <param name="fixedSpeed">Fixed Speed (required).</param>
        /// <param name="steppedSpeed">steppedSpeed.</param>
        public Speed(TypeEnum type = default(TypeEnum), SpeedUnits speedUnits = default(SpeedUnits), double? fixedSpeed = default(double?), SteppedSpeed steppedSpeed = default(SteppedSpeed))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Speed and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "speedUnits" is required (not null)
            if (speedUnits == null)
            {
                throw new InvalidDataException("speedUnits is a required property for Speed and cannot be null");
            }
            else
            {
                this.SpeedUnits = speedUnits;
            }
            // to ensure "fixedSpeed" is required (not null)
            if (fixedSpeed == null)
            {
                throw new InvalidDataException("fixedSpeed is a required property for Speed and cannot be null");
            }
            else
            {
                this.FixedSpeed = fixedSpeed;
            }
            this.SteppedSpeed = steppedSpeed;
        }
        

        /// <summary>
        /// Gets or Sets SpeedUnits
        /// </summary>
        [DataMember(Name="speed-units", EmitDefaultValue=false)]
        public SpeedUnits SpeedUnits { get; set; }

        /// <summary>
        /// Fixed Speed
        /// </summary>
        /// <value>Fixed Speed</value>
        [DataMember(Name="fixed-speed", EmitDefaultValue=false)]
        public double? FixedSpeed { get; set; }

        /// <summary>
        /// Gets or Sets SteppedSpeed
        /// </summary>
        [DataMember(Name="stepped-speed", EmitDefaultValue=false)]
        public SteppedSpeed SteppedSpeed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Speed {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SpeedUnits: ").Append(SpeedUnits).Append("\n");
            sb.Append("  FixedSpeed: ").Append(FixedSpeed).Append("\n");
            sb.Append("  SteppedSpeed: ").Append(SteppedSpeed).Append("\n");
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
            return this.Equals(input as Speed);
        }

        /// <summary>
        /// Returns true if Speed instances are equal
        /// </summary>
        /// <param name="input">Instance of Speed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Speed input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SpeedUnits == input.SpeedUnits ||
                    (this.SpeedUnits != null &&
                    this.SpeedUnits.Equals(input.SpeedUnits))
                ) && 
                (
                    this.FixedSpeed == input.FixedSpeed ||
                    (this.FixedSpeed != null &&
                    this.FixedSpeed.Equals(input.FixedSpeed))
                ) && 
                (
                    this.SteppedSpeed == input.SteppedSpeed ||
                    (this.SteppedSpeed != null &&
                    this.SteppedSpeed.Equals(input.SteppedSpeed))
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
                if (this.SpeedUnits != null)
                    hashCode = hashCode * 59 + this.SpeedUnits.GetHashCode();
                if (this.FixedSpeed != null)
                    hashCode = hashCode * 59 + this.FixedSpeed.GetHashCode();
                if (this.SteppedSpeed != null)
                    hashCode = hashCode * 59 + this.SteppedSpeed.GetHashCode();
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
