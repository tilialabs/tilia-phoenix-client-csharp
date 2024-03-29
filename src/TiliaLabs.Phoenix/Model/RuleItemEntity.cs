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
    /// Rule item
    /// </summary>
    [DataContract]
        public partial class RuleItemEntity :  IEquatable<RuleItemEntity>, IValidatableObject
    {
        /// <summary>
        /// Value type of item being evaluated
        /// </summary>
        /// <value>Value type of item being evaluated</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ValueTypeEnum
        {
            /// <summary>
            /// Enum String for value: String
            /// </summary>
            [EnumMember(Value = "String")]
            String = 1,
            /// <summary>
            /// Enum Integer for value: Integer
            /// </summary>
            [EnumMember(Value = "Integer")]
            Integer = 2,
            /// <summary>
            /// Enum Double for value: Double
            /// </summary>
            [EnumMember(Value = "Double")]
            Double = 3,
            /// <summary>
            /// Enum Boolean for value: Boolean
            /// </summary>
            [EnumMember(Value = "Boolean")]
            Boolean = 4,
            /// <summary>
            /// Enum Scalar for value: Scalar
            /// </summary>
            [EnumMember(Value = "Scalar")]
            Scalar = 5,
            /// <summary>
            /// Enum Size for value: Size
            /// </summary>
            [EnumMember(Value = "Size")]
            Size = 6,
            /// <summary>
            /// Enum Date for value: Date
            /// </summary>
            [EnumMember(Value = "Date")]
            Date = 7,
            /// <summary>
            /// Enum IntegerRange for value: IntegerRange
            /// </summary>
            [EnumMember(Value = "IntegerRange")]
            IntegerRange = 8,
            /// <summary>
            /// Enum DoubleRange for value: DoubleRange
            /// </summary>
            [EnumMember(Value = "DoubleRange")]
            DoubleRange = 9,
            /// <summary>
            /// Enum ScalarRange for value: ScalarRange
            /// </summary>
            [EnumMember(Value = "ScalarRange")]
            ScalarRange = 10,
            /// <summary>
            /// Enum DateRange for value: DateRange
            /// </summary>
            [EnumMember(Value = "DateRange")]
            DateRange = 11,
            /// <summary>
            /// Enum Margins for value: Margins
            /// </summary>
            [EnumMember(Value = "Margins")]
            Margins = 12,
            /// <summary>
            /// Enum PlacementRule for value: PlacementRule
            /// </summary>
            [EnumMember(Value = "PlacementRule")]
            PlacementRule = 13,
            /// <summary>
            /// Enum Enum for value: Enum
            /// </summary>
            [EnumMember(Value = "Enum")]
            Enum = 14,
            /// <summary>
            /// Enum Matcher for value: Matcher
            /// </summary>
            [EnumMember(Value = "Matcher")]
            Matcher = 15,
            /// <summary>
            /// Enum TextList for value: TextList
            /// </summary>
            [EnumMember(Value = "TextList")]
            TextList = 16,
            /// <summary>
            /// Enum List for value: List
            /// </summary>
            [EnumMember(Value = "List")]
            List = 17,
            /// <summary>
            /// Enum AssetRef for value: AssetRef
            /// </summary>
            [EnumMember(Value = "AssetRef")]
            AssetRef = 18        }
        /// <summary>
        /// Value type of item being evaluated
        /// </summary>
        /// <value>Value type of item being evaluated</value>
        [DataMember(Name="value-type", EmitDefaultValue=false)]
        public ValueTypeEnum? ValueType { get; set; }
        /// <summary>
        /// Rule operator
        /// </summary>
        /// <value>Rule operator</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OperatorEnum
        {
            /// <summary>
            /// Enum Equals for value: Equals
            /// </summary>
            [EnumMember(Value = "Equals")]
            Equals = 1,
            /// <summary>
            /// Enum NotEquals for value: NotEquals
            /// </summary>
            [EnumMember(Value = "NotEquals")]
            NotEquals = 2,
            /// <summary>
            /// Enum Within for value: Within
            /// </summary>
            [EnumMember(Value = "Within")]
            Within = 3,
            /// <summary>
            /// Enum NotWithin for value: NotWithin
            /// </summary>
            [EnumMember(Value = "NotWithin")]
            NotWithin = 4,
            /// <summary>
            /// Enum CommonItems for value: CommonItems
            /// </summary>
            [EnumMember(Value = "CommonItems")]
            CommonItems = 5,
            /// <summary>
            /// Enum NoCommonItems for value: NoCommonItems
            /// </summary>
            [EnumMember(Value = "NoCommonItems")]
            NoCommonItems = 6,
            /// <summary>
            /// Enum IsBlank for value: IsBlank
            /// </summary>
            [EnumMember(Value = "IsBlank")]
            IsBlank = 7,
            /// <summary>
            /// Enum IsTrue for value: IsTrue
            /// </summary>
            [EnumMember(Value = "IsTrue")]
            IsTrue = 8,
            /// <summary>
            /// Enum IsFalse for value: IsFalse
            /// </summary>
            [EnumMember(Value = "IsFalse")]
            IsFalse = 9        }
        /// <summary>
        /// Rule operator
        /// </summary>
        /// <value>Rule operator</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? _Operator { get; set; }
        /// <summary>
        /// Rule type.  &#x27;Item&#x27; for item rules and &#x27;Group&#x27; for group rules
        /// </summary>
        /// <value>Rule type.  &#x27;Item&#x27; for item rules and &#x27;Group&#x27; for group rules</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Item for value: Item
            /// </summary>
            [EnumMember(Value = "Item")]
            Item = 1,
            /// <summary>
            /// Enum Group for value: Group
            /// </summary>
            [EnumMember(Value = "Group")]
            Group = 2        }
        /// <summary>
        /// Rule type.  &#x27;Item&#x27; for item rules and &#x27;Group&#x27; for group rules
        /// </summary>
        /// <value>Rule type.  &#x27;Item&#x27; for item rules and &#x27;Group&#x27; for group rules</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleItemEntity" /> class.
        /// </summary>
        /// <param name="name">Name of item being evaluated.</param>
        /// <param name="valueType">Value type of item being evaluated.</param>
        /// <param name="_operator">Rule operator.</param>
        /// <param name="valueNumber">Value number used in comparison operators.</param>
        /// <param name="valueScalar">Value scalar used in comparison operators.</param>
        /// <param name="type">Rule type.  &#x27;Item&#x27; for item rules and &#x27;Group&#x27; for group rules (required).</param>
        public RuleItemEntity(string name = default(string), ValueTypeEnum? valueType = default(ValueTypeEnum?), OperatorEnum? _operator = default(OperatorEnum?), double? valueNumber = default(double?), string valueScalar = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for RuleItemEntity and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Name = name;
            this.ValueType = valueType;
            this._Operator = _operator;
            this.ValueNumber = valueNumber;
            this.ValueScalar = valueScalar;
        }
        
        /// <summary>
        /// Name of item being evaluated
        /// </summary>
        /// <value>Name of item being evaluated</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Value number used in comparison operators
        /// </summary>
        /// <value>Value number used in comparison operators</value>
        [DataMember(Name="value-number", EmitDefaultValue=false)]
        public double? ValueNumber { get; set; }

        /// <summary>
        /// Value scalar used in comparison operators
        /// </summary>
        /// <value>Value scalar used in comparison operators</value>
        [DataMember(Name="value-scalar", EmitDefaultValue=false)]
        public string ValueScalar { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleItemEntity {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  ValueNumber: ").Append(ValueNumber).Append("\n");
            sb.Append("  ValueScalar: ").Append(ValueScalar).Append("\n");
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
            return this.Equals(input as RuleItemEntity);
        }

        /// <summary>
        /// Returns true if RuleItemEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleItemEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleItemEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
                ) && 
                (
                    this._Operator == input._Operator ||
                    (this._Operator != null &&
                    this._Operator.Equals(input._Operator))
                ) && 
                (
                    this.ValueNumber == input.ValueNumber ||
                    (this.ValueNumber != null &&
                    this.ValueNumber.Equals(input.ValueNumber))
                ) && 
                (
                    this.ValueScalar == input.ValueScalar ||
                    (this.ValueScalar != null &&
                    this.ValueScalar.Equals(input.ValueScalar))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ValueType != null)
                    hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                if (this._Operator != null)
                    hashCode = hashCode * 59 + this._Operator.GetHashCode();
                if (this.ValueNumber != null)
                    hashCode = hashCode * 59 + this.ValueNumber.GetHashCode();
                if (this.ValueScalar != null)
                    hashCode = hashCode * 59 + this.ValueScalar.GetHashCode();
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
