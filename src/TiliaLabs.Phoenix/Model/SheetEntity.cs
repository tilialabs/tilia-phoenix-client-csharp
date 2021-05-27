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
    /// Sheet library item
    /// </summary>
    [DataContract]
        public partial class SheetEntity :  IEquatable<SheetEntity>, IValidatableObject
    {
        /// <summary>
        /// Cost unit type of this sheet when not defined from grade
        /// </summary>
        /// <value>Cost unit type of this sheet when not defined from grade</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum CostUnitsEnum
        {
            /// <summary>
            /// Enum FromGrade for value: FromGrade
            /// </summary>
            [EnumMember(Value = "FromGrade")]
            FromGrade = 1,
            /// <summary>
            /// Enum PerSheet for value: PerSheet
            /// </summary>
            [EnumMember(Value = "PerSheet")]
            PerSheet = 2,
            /// <summary>
            /// Enum Per500Sheets for value: Per500Sheets
            /// </summary>
            [EnumMember(Value = "Per500Sheets")]
            Per500Sheets = 3,
            /// <summary>
            /// Enum Per1000Sheets for value: Per1000Sheets
            /// </summary>
            [EnumMember(Value = "Per1000Sheets")]
            Per1000Sheets = 4,
            /// <summary>
            /// Enum PerLb for value: PerLb
            /// </summary>
            [EnumMember(Value = "PerLb")]
            PerLb = 5,
            /// <summary>
            /// Enum Per500Lb for value: Per500Lb
            /// </summary>
            [EnumMember(Value = "Per500Lb")]
            Per500Lb = 6,
            /// <summary>
            /// Enum Per1000Lb for value: Per1000Lb
            /// </summary>
            [EnumMember(Value = "Per1000Lb")]
            Per1000Lb = 7,
            /// <summary>
            /// Enum PerKg for value: PerKg
            /// </summary>
            [EnumMember(Value = "PerKg")]
            PerKg = 8,
            /// <summary>
            /// Enum Per1000Kg for value: Per1000Kg
            /// </summary>
            [EnumMember(Value = "Per1000Kg")]
            Per1000Kg = 9,
            /// <summary>
            /// Enum PerFt2 for value: PerFt2
            /// </summary>
            [EnumMember(Value = "PerFt2")]
            PerFt2 = 10,
            /// <summary>
            /// Enum PerM2 for value: PerM2
            /// </summary>
            [EnumMember(Value = "PerM2")]
            PerM2 = 11,
            /// <summary>
            /// Enum PerFt for value: PerFt
            /// </summary>
            [EnumMember(Value = "PerFt")]
            PerFt = 12,
            /// <summary>
            /// Enum PerM for value: PerM
            /// </summary>
            [EnumMember(Value = "PerM")]
            PerM = 13        }
        /// <summary>
        /// Cost unit type of this sheet when not defined from grade
        /// </summary>
        /// <value>Cost unit type of this sheet when not defined from grade</value>
        [DataMember(Name="cost-units", EmitDefaultValue=false)]
        public CostUnitsEnum? CostUnits { get; set; }
        /// <summary>
        /// The grain of this sheet.  Grain is inferred by dimension2 when not specified.
        /// </summary>
        /// <value>The grain of this sheet.  Grain is inferred by dimension2 when not specified.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum GrainEnum
        {
            /// <summary>
            /// Enum Long for value: Long
            /// </summary>
            [EnumMember(Value = "Long")]
            Long = 1,
            /// <summary>
            /// Enum Short for value: Short
            /// </summary>
            [EnumMember(Value = "Short")]
            Short = 2,
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 3        }
        /// <summary>
        /// The grain of this sheet.  Grain is inferred by dimension2 when not specified.
        /// </summary>
        /// <value>The grain of this sheet.  Grain is inferred by dimension2 when not specified.</value>
        [DataMember(Name="grain", EmitDefaultValue=false)]
        public GrainEnum? Grain { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SheetEntity" /> class.
        /// </summary>
        /// <param name="name">Name of library item (required).</param>
        /// <param name="id">Unique ID of this item (auto-generated, read-only).</param>
        /// <param name="externalId">Optional external ID of media item.</param>
        /// <param name="description">Asset description.</param>
        /// <param name="stockId">ID of the stock of this sheet.</param>
        /// <param name="gradeId">ID of the grade of this sheet.</param>
        /// <param name="dimension1">First dimension of this sheet (required).</param>
        /// <param name="dimension2">Second dimension of this sheet (required).</param>
        /// <param name="cost">Cost of this sheet when cost not defined from grade.</param>
        /// <param name="costUnits">Cost unit type of this sheet when not defined from grade.</param>
        /// <param name="grain">The grain of this sheet.  Grain is inferred by dimension2 when not specified..</param>
        public SheetEntity(string name = default(string), string id = default(string), string externalId = default(string), string description = default(string), string stockId = default(string), string gradeId = default(string), string dimension1 = default(string), string dimension2 = default(string), double? cost = default(double?), CostUnitsEnum? costUnits = default(CostUnitsEnum?), GrainEnum? grain = default(GrainEnum?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for SheetEntity and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "dimension1" is required (not null)
            if (dimension1 == null)
            {
                throw new InvalidDataException("dimension1 is a required property for SheetEntity and cannot be null");
            }
            else
            {
                this.Dimension1 = dimension1;
            }
            // to ensure "dimension2" is required (not null)
            if (dimension2 == null)
            {
                throw new InvalidDataException("dimension2 is a required property for SheetEntity and cannot be null");
            }
            else
            {
                this.Dimension2 = dimension2;
            }
            this.Id = id;
            this.ExternalId = externalId;
            this.Description = description;
            this.StockId = stockId;
            this.GradeId = gradeId;
            this.Cost = cost;
            this.CostUnits = costUnits;
            this.Grain = grain;
        }
        
        /// <summary>
        /// Name of library item
        /// </summary>
        /// <value>Name of library item</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Unique ID of this item (auto-generated, read-only)
        /// </summary>
        /// <value>Unique ID of this item (auto-generated, read-only)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Optional external ID of media item
        /// </summary>
        /// <value>Optional external ID of media item</value>
        [DataMember(Name="external-id", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Asset description
        /// </summary>
        /// <value>Asset description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// ID of the stock of this sheet
        /// </summary>
        /// <value>ID of the stock of this sheet</value>
        [DataMember(Name="stock-id", EmitDefaultValue=false)]
        public string StockId { get; set; }

        /// <summary>
        /// ID of the grade of this sheet
        /// </summary>
        /// <value>ID of the grade of this sheet</value>
        [DataMember(Name="grade-id", EmitDefaultValue=false)]
        public string GradeId { get; set; }

        /// <summary>
        /// First dimension of this sheet
        /// </summary>
        /// <value>First dimension of this sheet</value>
        [DataMember(Name="dimension1", EmitDefaultValue=false)]
        public string Dimension1 { get; set; }

        /// <summary>
        /// Second dimension of this sheet
        /// </summary>
        /// <value>Second dimension of this sheet</value>
        [DataMember(Name="dimension2", EmitDefaultValue=false)]
        public string Dimension2 { get; set; }

        /// <summary>
        /// Cost of this sheet when cost not defined from grade
        /// </summary>
        /// <value>Cost of this sheet when cost not defined from grade</value>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public double? Cost { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SheetEntity {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  StockId: ").Append(StockId).Append("\n");
            sb.Append("  GradeId: ").Append(GradeId).Append("\n");
            sb.Append("  Dimension1: ").Append(Dimension1).Append("\n");
            sb.Append("  Dimension2: ").Append(Dimension2).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  CostUnits: ").Append(CostUnits).Append("\n");
            sb.Append("  Grain: ").Append(Grain).Append("\n");
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
            return this.Equals(input as SheetEntity);
        }

        /// <summary>
        /// Returns true if SheetEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of SheetEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SheetEntity input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.StockId == input.StockId ||
                    (this.StockId != null &&
                    this.StockId.Equals(input.StockId))
                ) && 
                (
                    this.GradeId == input.GradeId ||
                    (this.GradeId != null &&
                    this.GradeId.Equals(input.GradeId))
                ) && 
                (
                    this.Dimension1 == input.Dimension1 ||
                    (this.Dimension1 != null &&
                    this.Dimension1.Equals(input.Dimension1))
                ) && 
                (
                    this.Dimension2 == input.Dimension2 ||
                    (this.Dimension2 != null &&
                    this.Dimension2.Equals(input.Dimension2))
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.CostUnits == input.CostUnits ||
                    (this.CostUnits != null &&
                    this.CostUnits.Equals(input.CostUnits))
                ) && 
                (
                    this.Grain == input.Grain ||
                    (this.Grain != null &&
                    this.Grain.Equals(input.Grain))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.StockId != null)
                    hashCode = hashCode * 59 + this.StockId.GetHashCode();
                if (this.GradeId != null)
                    hashCode = hashCode * 59 + this.GradeId.GetHashCode();
                if (this.Dimension1 != null)
                    hashCode = hashCode * 59 + this.Dimension1.GetHashCode();
                if (this.Dimension2 != null)
                    hashCode = hashCode * 59 + this.Dimension2.GetHashCode();
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.CostUnits != null)
                    hashCode = hashCode * 59 + this.CostUnits.GetHashCode();
                if (this.Grain != null)
                    hashCode = hashCode * 59 + this.Grain.GetHashCode();
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
