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
    /// Creep settings
    /// </summary>
    [DataContract]
        public partial class CreepEntity :  IEquatable<CreepEntity>, IValidatableObject
    {
        /// <summary>
        /// Type of creep to apply to bound signatures
        /// </summary>
        /// <value>Type of creep to apply to bound signatures</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            /// <summary>
            /// Enum Inward for value: Inward
            /// </summary>
            [EnumMember(Value = "Inward")]
            Inward = 2,
            /// <summary>
            /// Enum Outward for value: Outward
            /// </summary>
            [EnumMember(Value = "Outward")]
            Outward = 3,
            /// <summary>
            /// Enum Both for value: Both
            /// </summary>
            [EnumMember(Value = "Both")]
            Both = 4,
            /// <summary>
            /// Enum Custom for value: Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom = 5        }
        /// <summary>
        /// Type of creep to apply to bound signatures
        /// </summary>
        /// <value>Type of creep to apply to bound signatures</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Creep method to use for performing creep on bound signatures
        /// </summary>
        /// <value>Creep method to use for performing creep on bound signatures</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum MethodEnum
        {
            /// <summary>
            /// Enum Offset for value: Offset
            /// </summary>
            [EnumMember(Value = "Offset")]
            Offset = 1,
            /// <summary>
            /// Enum Scale for value: Scale
            /// </summary>
            [EnumMember(Value = "Scale")]
            Scale = 2        }
        /// <summary>
        /// Creep method to use for performing creep on bound signatures
        /// </summary>
        /// <value>Creep method to use for performing creep on bound signatures</value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public MethodEnum? Method { get; set; }
        /// <summary>
        /// Creep calculation mode to use to determine creep amount to apply
        /// </summary>
        /// <value>Creep calculation mode to use to determine creep amount to apply</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum CalculationEnum
        {
            /// <summary>
            /// Enum FromStock for value: FromStock
            /// </summary>
            [EnumMember(Value = "FromStock")]
            FromStock = 1,
            /// <summary>
            /// Enum PerPage for value: PerPage
            /// </summary>
            [EnumMember(Value = "PerPage")]
            PerPage = 2,
            /// <summary>
            /// Enum Total for value: Total
            /// </summary>
            [EnumMember(Value = "Total")]
            Total = 3        }
        /// <summary>
        /// Creep calculation mode to use to determine creep amount to apply
        /// </summary>
        /// <value>Creep calculation mode to use to determine creep amount to apply</value>
        [DataMember(Name="calculation", EmitDefaultValue=false)]
        public CalculationEnum? Calculation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreepEntity" /> class.
        /// </summary>
        /// <param name="type">Type of creep to apply to bound signatures.</param>
        /// <param name="transition">Percentage from the inner most signatures towards the spine when to change creep direction from inward to outward when using &#x27;Custom&#x27; creep type.</param>
        /// <param name="method">Creep method to use for performing creep on bound signatures.</param>
        /// <param name="calculation">Creep calculation mode to use to determine creep amount to apply.</param>
        /// <param name="amount">Amount of creep to apply which can be total or per-page amount based on the calculation mode.</param>
        public CreepEntity(TypeEnum? type = default(TypeEnum?), string transition = default(string), MethodEnum? method = default(MethodEnum?), CalculationEnum? calculation = default(CalculationEnum?), string amount = default(string))
        {
            this.Type = type;
            this.Transition = transition;
            this.Method = method;
            this.Calculation = calculation;
            this.Amount = amount;
        }
        

        /// <summary>
        /// Percentage from the inner most signatures towards the spine when to change creep direction from inward to outward when using &#x27;Custom&#x27; creep type
        /// </summary>
        /// <value>Percentage from the inner most signatures towards the spine when to change creep direction from inward to outward when using &#x27;Custom&#x27; creep type</value>
        [DataMember(Name="transition", EmitDefaultValue=false)]
        public string Transition { get; set; }



        /// <summary>
        /// Amount of creep to apply which can be total or per-page amount based on the calculation mode
        /// </summary>
        /// <value>Amount of creep to apply which can be total or per-page amount based on the calculation mode</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreepEntity {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Transition: ").Append(Transition).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Calculation: ").Append(Calculation).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as CreepEntity);
        }

        /// <summary>
        /// Returns true if CreepEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of CreepEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreepEntity input)
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
                    this.Transition == input.Transition ||
                    (this.Transition != null &&
                    this.Transition.Equals(input.Transition))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.Calculation == input.Calculation ||
                    (this.Calculation != null &&
                    this.Calculation.Equals(input.Calculation))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                if (this.Transition != null)
                    hashCode = hashCode * 59 + this.Transition.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.Calculation != null)
                    hashCode = hashCode * 59 + this.Calculation.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
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
