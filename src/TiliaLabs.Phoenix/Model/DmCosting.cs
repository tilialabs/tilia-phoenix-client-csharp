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
    /// Die Making Costing
    /// </summary>
    [DataContract]
        public partial class DmCosting :  IEquatable<DmCosting>, IValidatableObject
    {
        /// <summary>
        /// Cost per area units
        /// </summary>
        /// <value>Cost per area units</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum CostPerAreaUnitsEnum
        {
            /// <summary>
            /// Enum Sheets for value: Sheets
            /// </summary>
            [EnumMember(Value = "Sheets")]
            Sheets = 1,
            /// <summary>
            /// Enum FEET for value: FEET
            /// </summary>
            [EnumMember(Value = "FEET")]
            FEET = 2,
            /// <summary>
            /// Enum Inches for value: Inches
            /// </summary>
            [EnumMember(Value = "Inches")]
            Inches = 3,
            /// <summary>
            /// Enum Meters for value: Meters
            /// </summary>
            [EnumMember(Value = "Meters")]
            Meters = 4,
            /// <summary>
            /// Enum Centimeters for value: Centimeters
            /// </summary>
            [EnumMember(Value = "Centimeters")]
            Centimeters = 5,
            /// <summary>
            /// Enum Millimeters for value: Millimeters
            /// </summary>
            [EnumMember(Value = "Millimeters")]
            Millimeters = 6,
            /// <summary>
            /// Enum MSI for value: MSI
            /// </summary>
            [EnumMember(Value = "MSI")]
            MSI = 7,
            /// <summary>
            /// Enum Feet for value: Feet²
            /// </summary>
            [EnumMember(Value = "Feet²")]
            Feet = 8,
            /// <summary>
            /// Enum Inches_8 for value: Inches²
            /// </summary>
            [EnumMember(Value = "Inches²")]
            Inches_8 = 9,
            /// <summary>
            /// Enum Meters_9 for value: Meters²
            /// </summary>
            [EnumMember(Value = "Meters²")]
            Meters_9 = 10,
            /// <summary>
            /// Enum Centimeters_10 for value: Centimeters²
            /// </summary>
            [EnumMember(Value = "Centimeters²")]
            Centimeters_10 = 11,
            /// <summary>
            /// Enum Millimeters_11 for value: Millimeters²
            /// </summary>
            [EnumMember(Value = "Millimeters²")]
            Millimeters_11 = 12        }
        /// <summary>
        /// Cost per area units
        /// </summary>
        /// <value>Cost per area units</value>
        [DataMember(Name="cost-per-area-units", EmitDefaultValue=false)]
        public CostPerAreaUnitsEnum CostPerAreaUnits { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum SfdpCosting for value: SfdpCosting
            /// </summary>
            [EnumMember(Value = "SfdpCosting")]
            SfdpCosting = 1,
            /// <summary>
            /// Enum WfdpCosting for value: WfdpCosting
            /// </summary>
            [EnumMember(Value = "WfdpCosting")]
            WfdpCosting = 2,
            /// <summary>
            /// Enum SfopCosting for value: SfopCosting
            /// </summary>
            [EnumMember(Value = "SfopCosting")]
            SfopCosting = 3,
            /// <summary>
            /// Enum WfopCosting for value: WfopCosting
            /// </summary>
            [EnumMember(Value = "WfopCosting")]
            WfopCosting = 4,
            /// <summary>
            /// Enum FwfpCosting for value: FwfpCosting
            /// </summary>
            [EnumMember(Value = "FwfpCosting")]
            FwfpCosting = 5,
            /// <summary>
            /// Enum RfwfpCosting for value: RfwfpCosting
            /// </summary>
            [EnumMember(Value = "RfwfpCosting")]
            RfwfpCosting = 6,
            /// <summary>
            /// Enum GcCosting for value: GcCosting
            /// </summary>
            [EnumMember(Value = "GcCosting")]
            GcCosting = 7,
            /// <summary>
            /// Enum FdcCosting for value: FdcCosting
            /// </summary>
            [EnumMember(Value = "FdcCosting")]
            FdcCosting = 8,
            /// <summary>
            /// Enum DctCosting for value: DctCosting
            /// </summary>
            [EnumMember(Value = "DctCosting")]
            DctCosting = 9,
            /// <summary>
            /// Enum DmCosting for value: DmCosting
            /// </summary>
            [EnumMember(Value = "DmCosting")]
            DmCosting = 10        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DmCosting" /> class.
        /// </summary>
        /// <param name="cost">Cost (required).</param>
        /// <param name="costPerArea">Cost per area (required).</param>
        /// <param name="costPerAreaUnits">Cost per area units (required).</param>
        /// <param name="costPer1up">Cost per 1up (required).</param>
        /// <param name="steelRules">steelRules (required).</param>
        /// <param name="type">type (required).</param>
        public DmCosting(double? cost = default(double?), double? costPerArea = default(double?), CostPerAreaUnitsEnum costPerAreaUnits = default(CostPerAreaUnitsEnum), double? costPer1up = default(double?), SteelRules steelRules = default(SteelRules), TypeEnum type = default(TypeEnum))
        {
            // to ensure "cost" is required (not null)
            if (cost == null)
            {
                throw new InvalidDataException("cost is a required property for DmCosting and cannot be null");
            }
            else
            {
                this.Cost = cost;
            }
            // to ensure "costPerArea" is required (not null)
            if (costPerArea == null)
            {
                throw new InvalidDataException("costPerArea is a required property for DmCosting and cannot be null");
            }
            else
            {
                this.CostPerArea = costPerArea;
            }
            // to ensure "costPerAreaUnits" is required (not null)
            if (costPerAreaUnits == null)
            {
                throw new InvalidDataException("costPerAreaUnits is a required property for DmCosting and cannot be null");
            }
            else
            {
                this.CostPerAreaUnits = costPerAreaUnits;
            }
            // to ensure "costPer1up" is required (not null)
            if (costPer1up == null)
            {
                throw new InvalidDataException("costPer1up is a required property for DmCosting and cannot be null");
            }
            else
            {
                this.CostPer1up = costPer1up;
            }
            // to ensure "steelRules" is required (not null)
            if (steelRules == null)
            {
                throw new InvalidDataException("steelRules is a required property for DmCosting and cannot be null");
            }
            else
            {
                this.SteelRules = steelRules;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for DmCosting and cannot be null");
            }
            else
            {
                this.Type = type;
            }
        }
        
        /// <summary>
        /// Cost
        /// </summary>
        /// <value>Cost</value>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public double? Cost { get; set; }

        /// <summary>
        /// Cost per area
        /// </summary>
        /// <value>Cost per area</value>
        [DataMember(Name="cost-per-area", EmitDefaultValue=false)]
        public double? CostPerArea { get; set; }


        /// <summary>
        /// Cost per 1up
        /// </summary>
        /// <value>Cost per 1up</value>
        [DataMember(Name="cost-per-1up", EmitDefaultValue=false)]
        public double? CostPer1up { get; set; }

        /// <summary>
        /// Gets or Sets SteelRules
        /// </summary>
        [DataMember(Name="steel-rules", EmitDefaultValue=false)]
        public SteelRules SteelRules { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DmCosting {\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  CostPerArea: ").Append(CostPerArea).Append("\n");
            sb.Append("  CostPerAreaUnits: ").Append(CostPerAreaUnits).Append("\n");
            sb.Append("  CostPer1up: ").Append(CostPer1up).Append("\n");
            sb.Append("  SteelRules: ").Append(SteelRules).Append("\n");
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
            return this.Equals(input as DmCosting);
        }

        /// <summary>
        /// Returns true if DmCosting instances are equal
        /// </summary>
        /// <param name="input">Instance of DmCosting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DmCosting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.CostPerArea == input.CostPerArea ||
                    (this.CostPerArea != null &&
                    this.CostPerArea.Equals(input.CostPerArea))
                ) && 
                (
                    this.CostPerAreaUnits == input.CostPerAreaUnits ||
                    (this.CostPerAreaUnits != null &&
                    this.CostPerAreaUnits.Equals(input.CostPerAreaUnits))
                ) && 
                (
                    this.CostPer1up == input.CostPer1up ||
                    (this.CostPer1up != null &&
                    this.CostPer1up.Equals(input.CostPer1up))
                ) && 
                (
                    this.SteelRules == input.SteelRules ||
                    (this.SteelRules != null &&
                    this.SteelRules.Equals(input.SteelRules))
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
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.CostPerArea != null)
                    hashCode = hashCode * 59 + this.CostPerArea.GetHashCode();
                if (this.CostPerAreaUnits != null)
                    hashCode = hashCode * 59 + this.CostPerAreaUnits.GetHashCode();
                if (this.CostPer1up != null)
                    hashCode = hashCode * 59 + this.CostPer1up.GetHashCode();
                if (this.SteelRules != null)
                    hashCode = hashCode * 59 + this.SteelRules.GetHashCode();
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
