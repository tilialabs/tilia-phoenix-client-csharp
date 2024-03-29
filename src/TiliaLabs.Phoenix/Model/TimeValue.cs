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
    /// Time value
    /// </summary>
    [DataContract]
        public partial class TimeValue :  IEquatable<TimeValue>, IValidatableObject
    {
        /// <summary>
        /// Units
        /// </summary>
        /// <value>Units</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum UnitsEnum
        {
            /// <summary>
            /// Enum Milliseconds for value: Milliseconds
            /// </summary>
            [EnumMember(Value = "Milliseconds")]
            Milliseconds = 1,
            /// <summary>
            /// Enum Seconds for value: Seconds
            /// </summary>
            [EnumMember(Value = "Seconds")]
            Seconds = 2,
            /// <summary>
            /// Enum Minutes for value: Minutes
            /// </summary>
            [EnumMember(Value = "Minutes")]
            Minutes = 3,
            /// <summary>
            /// Enum Hours for value: Hours
            /// </summary>
            [EnumMember(Value = "Hours")]
            Hours = 4,
            /// <summary>
            /// Enum Days for value: Days
            /// </summary>
            [EnumMember(Value = "Days")]
            Days = 5        }
        /// <summary>
        /// Units
        /// </summary>
        /// <value>Units</value>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public UnitsEnum Units { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeValue" /> class.
        /// </summary>
        /// <param name="units">Units (required).</param>
        /// <param name="value">Value (required).</param>
        public TimeValue(UnitsEnum units = default(UnitsEnum), double? value = default(double?))
        {
            // to ensure "units" is required (not null)
            if (units == null)
            {
                throw new InvalidDataException("units is a required property for TimeValue and cannot be null");
            }
            else
            {
                this.Units = units;
            }
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for TimeValue and cannot be null");
            }
            else
            {
                this.Value = value;
            }
        }
        

        /// <summary>
        /// Value
        /// </summary>
        /// <value>Value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeValue {\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as TimeValue);
        }

        /// <summary>
        /// Returns true if TimeValue instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Units == input.Units ||
                    (this.Units != null &&
                    this.Units.Equals(input.Units))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Units != null)
                    hashCode = hashCode * 59 + this.Units.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
