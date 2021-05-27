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
    /// Setup Layouts
    /// </summary>
    [DataContract]
        public partial class SetupLayouts :  IEquatable<SetupLayouts>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Setup for value: Setup
            /// </summary>
            [EnumMember(Value = "Setup")]
            Setup = 1,
            /// <summary>
            /// Enum SetupLayouts for value: SetupLayouts
            /// </summary>
            [EnumMember(Value = "SetupLayouts")]
            SetupLayouts = 2,
            /// <summary>
            /// Enum GcSetup for value: GcSetup
            /// </summary>
            [EnumMember(Value = "GcSetup")]
            GcSetup = 3,
            /// <summary>
            /// Enum FdcSetup for value: FdcSetup
            /// </summary>
            [EnumMember(Value = "FdcSetup")]
            FdcSetup = 4        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetupLayouts" /> class.
        /// </summary>
        /// <param name="time">time (required).</param>
        /// <param name="layouts">Setup Layouts (required).</param>
        /// <param name="type">type (required).</param>
        public SetupLayouts(TimeValue time = default(TimeValue), int? layouts = default(int?), TypeEnum type = default(TypeEnum))
        {
            // to ensure "time" is required (not null)
            if (time == null)
            {
                throw new InvalidDataException("time is a required property for SetupLayouts and cannot be null");
            }
            else
            {
                this.Time = time;
            }
            // to ensure "layouts" is required (not null)
            if (layouts == null)
            {
                throw new InvalidDataException("layouts is a required property for SetupLayouts and cannot be null");
            }
            else
            {
                this.Layouts = layouts;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for SetupLayouts and cannot be null");
            }
            else
            {
                this.Type = type;
            }
        }
        
        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public TimeValue Time { get; set; }

        /// <summary>
        /// Setup Layouts
        /// </summary>
        /// <value>Setup Layouts</value>
        [DataMember(Name="layouts", EmitDefaultValue=false)]
        public int? Layouts { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetupLayouts {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Layouts: ").Append(Layouts).Append("\n");
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
            return this.Equals(input as SetupLayouts);
        }

        /// <summary>
        /// Returns true if SetupLayouts instances are equal
        /// </summary>
        /// <param name="input">Instance of SetupLayouts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetupLayouts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Layouts == input.Layouts ||
                    (this.Layouts != null &&
                    this.Layouts.Equals(input.Layouts))
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Layouts != null)
                    hashCode = hashCode * 59 + this.Layouts.GetHashCode();
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