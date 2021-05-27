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
    /// Guillotine cutter costing
    /// </summary>
    [DataContract]
        public partial class GcCosting :  IEquatable<GcCosting>, IValidatableObject
    {
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
        /// Initializes a new instance of the <see cref="GcCosting" /> class.
        /// </summary>
        /// <param name="currency">currency (required).</param>
        /// <param name="rate">rate (required).</param>
        /// <param name="setup">setup (required).</param>
        /// <param name="type">type (required).</param>
        public GcCosting(DctcostingCurrency currency = default(DctcostingCurrency), Rate rate = default(Rate), GcSetup setup = default(GcSetup), TypeEnum type = default(TypeEnum))
        {
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for GcCosting and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
            // to ensure "rate" is required (not null)
            if (rate == null)
            {
                throw new InvalidDataException("rate is a required property for GcCosting and cannot be null");
            }
            else
            {
                this.Rate = rate;
            }
            // to ensure "setup" is required (not null)
            if (setup == null)
            {
                throw new InvalidDataException("setup is a required property for GcCosting and cannot be null");
            }
            else
            {
                this.Setup = setup;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for GcCosting and cannot be null");
            }
            else
            {
                this.Type = type;
            }
        }
        
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public DctcostingCurrency Currency { get; set; }

        /// <summary>
        /// Gets or Sets Rate
        /// </summary>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public Rate Rate { get; set; }

        /// <summary>
        /// Gets or Sets Setup
        /// </summary>
        [DataMember(Name="setup", EmitDefaultValue=false)]
        public GcSetup Setup { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcCosting {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Setup: ").Append(Setup).Append("\n");
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
            return this.Equals(input as GcCosting);
        }

        /// <summary>
        /// Returns true if GcCosting instances are equal
        /// </summary>
        /// <param name="input">Instance of GcCosting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcCosting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.Setup == input.Setup ||
                    (this.Setup != null &&
                    this.Setup.Equals(input.Setup))
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
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
                if (this.Setup != null)
                    hashCode = hashCode * 59 + this.Setup.GetHashCode();
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
