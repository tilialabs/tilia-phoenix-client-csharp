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
    /// Die Making Capabilities
    /// </summary>
    [DataContract]
        public partial class DmCapabilities :  IEquatable<DmCapabilities>, IValidatableObject
    {
        /// <summary>
        /// Limit logic
        /// </summary>
        /// <value>Limit logic</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum LimitLogicEnum
        {
            /// <summary>
            /// Enum Inclusively for value: Inclusively
            /// </summary>
            [EnumMember(Value = "Inclusively")]
            Inclusively = 1,
            /// <summary>
            /// Enum Exclusively for value: Exclusively
            /// </summary>
            [EnumMember(Value = "Exclusively")]
            Exclusively = 2        }
        /// <summary>
        /// Limit logic
        /// </summary>
        /// <value>Limit logic</value>
        [DataMember(Name="limit-logic", EmitDefaultValue=false)]
        public LimitLogicEnum LimitLogic { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum PressCapabilities for value: PressCapabilities
            /// </summary>
            [EnumMember(Value = "PressCapabilities")]
            PressCapabilities = 1,
            /// <summary>
            /// Enum GcCapabilities for value: GcCapabilities
            /// </summary>
            [EnumMember(Value = "GcCapabilities")]
            GcCapabilities = 2,
            /// <summary>
            /// Enum FdcCapabilities for value: FdcCapabilities
            /// </summary>
            [EnumMember(Value = "FdcCapabilities")]
            FdcCapabilities = 3,
            /// <summary>
            /// Enum DctCapabilities for value: DctCapabilities
            /// </summary>
            [EnumMember(Value = "DctCapabilities")]
            DctCapabilities = 4,
            /// <summary>
            /// Enum DmCapabilities for value: DmCapabilities
            /// </summary>
            [EnumMember(Value = "DmCapabilities")]
            DmCapabilities = 5        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DmCapabilities" /> class.
        /// </summary>
        /// <param name="widthRange">widthRange (required).</param>
        /// <param name="heightRange">heightRange (required).</param>
        /// <param name="limit">Limit (required).</param>
        /// <param name="limitLogic">Limit logic (required).</param>
        /// <param name="processTypes">Process types.</param>
        /// <param name="specificDevices">Specific devices.</param>
        /// <param name="type">type (required).</param>
        public DmCapabilities(ScalarRange widthRange = default(ScalarRange), ScalarRange heightRange = default(ScalarRange), bool? limit = default(bool?), LimitLogicEnum limitLogic = default(LimitLogicEnum), List<AssetRefProcessType> processTypes = default(List<AssetRefProcessType>), List<AssetRefDevice> specificDevices = default(List<AssetRefDevice>), TypeEnum type = default(TypeEnum))
        {
            // to ensure "widthRange" is required (not null)
            if (widthRange == null)
            {
                throw new InvalidDataException("widthRange is a required property for DmCapabilities and cannot be null");
            }
            else
            {
                this.WidthRange = widthRange;
            }
            // to ensure "heightRange" is required (not null)
            if (heightRange == null)
            {
                throw new InvalidDataException("heightRange is a required property for DmCapabilities and cannot be null");
            }
            else
            {
                this.HeightRange = heightRange;
            }
            // to ensure "limit" is required (not null)
            if (limit == null)
            {
                throw new InvalidDataException("limit is a required property for DmCapabilities and cannot be null");
            }
            else
            {
                this.Limit = limit;
            }
            // to ensure "limitLogic" is required (not null)
            if (limitLogic == null)
            {
                throw new InvalidDataException("limitLogic is a required property for DmCapabilities and cannot be null");
            }
            else
            {
                this.LimitLogic = limitLogic;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for DmCapabilities and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.ProcessTypes = processTypes;
            this.SpecificDevices = specificDevices;
        }
        
        /// <summary>
        /// Gets or Sets WidthRange
        /// </summary>
        [DataMember(Name="width-range", EmitDefaultValue=false)]
        public ScalarRange WidthRange { get; set; }

        /// <summary>
        /// Gets or Sets HeightRange
        /// </summary>
        [DataMember(Name="height-range", EmitDefaultValue=false)]
        public ScalarRange HeightRange { get; set; }

        /// <summary>
        /// Limit
        /// </summary>
        /// <value>Limit</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public bool? Limit { get; set; }


        /// <summary>
        /// Process types
        /// </summary>
        /// <value>Process types</value>
        [DataMember(Name="process-types", EmitDefaultValue=false)]
        public List<AssetRefProcessType> ProcessTypes { get; set; }

        /// <summary>
        /// Specific devices
        /// </summary>
        /// <value>Specific devices</value>
        [DataMember(Name="specific-devices", EmitDefaultValue=false)]
        public List<AssetRefDevice> SpecificDevices { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DmCapabilities {\n");
            sb.Append("  WidthRange: ").Append(WidthRange).Append("\n");
            sb.Append("  HeightRange: ").Append(HeightRange).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  LimitLogic: ").Append(LimitLogic).Append("\n");
            sb.Append("  ProcessTypes: ").Append(ProcessTypes).Append("\n");
            sb.Append("  SpecificDevices: ").Append(SpecificDevices).Append("\n");
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
            return this.Equals(input as DmCapabilities);
        }

        /// <summary>
        /// Returns true if DmCapabilities instances are equal
        /// </summary>
        /// <param name="input">Instance of DmCapabilities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DmCapabilities input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WidthRange == input.WidthRange ||
                    (this.WidthRange != null &&
                    this.WidthRange.Equals(input.WidthRange))
                ) && 
                (
                    this.HeightRange == input.HeightRange ||
                    (this.HeightRange != null &&
                    this.HeightRange.Equals(input.HeightRange))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.LimitLogic == input.LimitLogic ||
                    (this.LimitLogic != null &&
                    this.LimitLogic.Equals(input.LimitLogic))
                ) && 
                (
                    this.ProcessTypes == input.ProcessTypes ||
                    this.ProcessTypes != null &&
                    input.ProcessTypes != null &&
                    this.ProcessTypes.SequenceEqual(input.ProcessTypes)
                ) && 
                (
                    this.SpecificDevices == input.SpecificDevices ||
                    this.SpecificDevices != null &&
                    input.SpecificDevices != null &&
                    this.SpecificDevices.SequenceEqual(input.SpecificDevices)
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
                if (this.WidthRange != null)
                    hashCode = hashCode * 59 + this.WidthRange.GetHashCode();
                if (this.HeightRange != null)
                    hashCode = hashCode * 59 + this.HeightRange.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.LimitLogic != null)
                    hashCode = hashCode * 59 + this.LimitLogic.GetHashCode();
                if (this.ProcessTypes != null)
                    hashCode = hashCode * 59 + this.ProcessTypes.GetHashCode();
                if (this.SpecificDevices != null)
                    hashCode = hashCode * 59 + this.SpecificDevices.GetHashCode();
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