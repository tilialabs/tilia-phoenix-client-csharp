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
    /// Trim settings
    /// </summary>
    [DataContract]
        public partial class Trim :  IEquatable<Trim>, IValidatableObject
    {
        /// <summary>
        /// Lip type
        /// </summary>
        /// <value>Lip type</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum LipTypeEnum
        {
            /// <summary>
            /// Enum Auto for value: Auto
            /// </summary>
            [EnumMember(Value = "Auto")]
            Auto = 1,
            /// <summary>
            /// Enum Front for value: Front
            /// </summary>
            [EnumMember(Value = "Front")]
            Front = 2,
            /// <summary>
            /// Enum Back for value: Back
            /// </summary>
            [EnumMember(Value = "Back")]
            Back = 3        }
        /// <summary>
        /// Lip type
        /// </summary>
        /// <value>Lip type</value>
        [DataMember(Name="lip-type", EmitDefaultValue=false)]
        public LipTypeEnum? LipType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Trim" /> class.
        /// </summary>
        /// <param name="spineTrim">Spine trim.</param>
        /// <param name="jogTrim">Jog trim.</param>
        /// <param name="faceTrim">Face trim.</param>
        /// <param name="nonJogTrim">Non-jog trim.</param>
        /// <param name="lipType">Lip type.</param>
        /// <param name="lip">Lip.</param>
        public Trim(string spineTrim = default(string), string jogTrim = default(string), string faceTrim = default(string), string nonJogTrim = default(string), LipTypeEnum? lipType = default(LipTypeEnum?), string lip = default(string))
        {
            this.SpineTrim = spineTrim;
            this.JogTrim = jogTrim;
            this.FaceTrim = faceTrim;
            this.NonJogTrim = nonJogTrim;
            this.LipType = lipType;
            this.Lip = lip;
        }
        
        /// <summary>
        /// Spine trim
        /// </summary>
        /// <value>Spine trim</value>
        [DataMember(Name="spine-trim", EmitDefaultValue=false)]
        public string SpineTrim { get; set; }

        /// <summary>
        /// Jog trim
        /// </summary>
        /// <value>Jog trim</value>
        [DataMember(Name="jog-trim", EmitDefaultValue=false)]
        public string JogTrim { get; set; }

        /// <summary>
        /// Face trim
        /// </summary>
        /// <value>Face trim</value>
        [DataMember(Name="face-trim", EmitDefaultValue=false)]
        public string FaceTrim { get; set; }

        /// <summary>
        /// Non-jog trim
        /// </summary>
        /// <value>Non-jog trim</value>
        [DataMember(Name="non-jog-trim", EmitDefaultValue=false)]
        public string NonJogTrim { get; set; }


        /// <summary>
        /// Lip
        /// </summary>
        /// <value>Lip</value>
        [DataMember(Name="lip", EmitDefaultValue=false)]
        public string Lip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Trim {\n");
            sb.Append("  SpineTrim: ").Append(SpineTrim).Append("\n");
            sb.Append("  JogTrim: ").Append(JogTrim).Append("\n");
            sb.Append("  FaceTrim: ").Append(FaceTrim).Append("\n");
            sb.Append("  NonJogTrim: ").Append(NonJogTrim).Append("\n");
            sb.Append("  LipType: ").Append(LipType).Append("\n");
            sb.Append("  Lip: ").Append(Lip).Append("\n");
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
            return this.Equals(input as Trim);
        }

        /// <summary>
        /// Returns true if Trim instances are equal
        /// </summary>
        /// <param name="input">Instance of Trim to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Trim input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SpineTrim == input.SpineTrim ||
                    (this.SpineTrim != null &&
                    this.SpineTrim.Equals(input.SpineTrim))
                ) && 
                (
                    this.JogTrim == input.JogTrim ||
                    (this.JogTrim != null &&
                    this.JogTrim.Equals(input.JogTrim))
                ) && 
                (
                    this.FaceTrim == input.FaceTrim ||
                    (this.FaceTrim != null &&
                    this.FaceTrim.Equals(input.FaceTrim))
                ) && 
                (
                    this.NonJogTrim == input.NonJogTrim ||
                    (this.NonJogTrim != null &&
                    this.NonJogTrim.Equals(input.NonJogTrim))
                ) && 
                (
                    this.LipType == input.LipType ||
                    (this.LipType != null &&
                    this.LipType.Equals(input.LipType))
                ) && 
                (
                    this.Lip == input.Lip ||
                    (this.Lip != null &&
                    this.Lip.Equals(input.Lip))
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
                if (this.SpineTrim != null)
                    hashCode = hashCode * 59 + this.SpineTrim.GetHashCode();
                if (this.JogTrim != null)
                    hashCode = hashCode * 59 + this.JogTrim.GetHashCode();
                if (this.FaceTrim != null)
                    hashCode = hashCode * 59 + this.FaceTrim.GetHashCode();
                if (this.NonJogTrim != null)
                    hashCode = hashCode * 59 + this.NonJogTrim.GetHashCode();
                if (this.LipType != null)
                    hashCode = hashCode * 59 + this.LipType.GetHashCode();
                if (this.Lip != null)
                    hashCode = hashCode * 59 + this.Lip.GetHashCode();
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
