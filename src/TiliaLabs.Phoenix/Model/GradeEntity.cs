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
    /// Grade library item
    /// </summary>
    [DataContract]
        public partial class GradeEntity :  IEquatable<GradeEntity>, IValidatableObject
    {
        /// <summary>
        /// Grade display
        /// </summary>
        /// <value>Grade display</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum GradeDisplayEnum
        {
            /// <summary>
            /// Enum Weight for value: Weight
            /// </summary>
            [EnumMember(Value = "Weight")]
            Weight = 1,
            /// <summary>
            /// Enum Caliper for value: Caliper
            /// </summary>
            [EnumMember(Value = "Caliper")]
            Caliper = 2,
            /// <summary>
            /// Enum Both for value: Both
            /// </summary>
            [EnumMember(Value = "Both")]
            Both = 3        }
        /// <summary>
        /// Grade display
        /// </summary>
        /// <value>Grade display</value>
        [DataMember(Name="grade-display", EmitDefaultValue=false)]
        public GradeDisplayEnum? GradeDisplay { get; set; }
        /// <summary>
        /// Grade weight units
        /// </summary>
        /// <value>Grade weight units</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum WeightUnitsEnum
        {
            /// <summary>
            /// Enum GSM for value: GSM
            /// </summary>
            [EnumMember(Value = "GSM")]
            GSM = 1,
            /// <summary>
            /// Enum Lb for value: Lb
            /// </summary>
            [EnumMember(Value = "Lb")]
            Lb = 2        }
        /// <summary>
        /// Grade weight units
        /// </summary>
        /// <value>Grade weight units</value>
        [DataMember(Name="weight-units", EmitDefaultValue=false)]
        public WeightUnitsEnum? WeightUnits { get; set; }
        /// <summary>
        /// Grade weight type for pound (Lb) standard weights
        /// </summary>
        /// <value>Grade weight type for pound (Lb) standard weights</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum WeightTypeEnum
        {
            /// <summary>
            /// Enum Text for value: Text
            /// </summary>
            [EnumMember(Value = "Text")]
            Text = 1,
            /// <summary>
            /// Enum Book for value: Book
            /// </summary>
            [EnumMember(Value = "Book")]
            Book = 2,
            /// <summary>
            /// Enum Bond for value: Bond
            /// </summary>
            [EnumMember(Value = "Bond")]
            Bond = 3,
            /// <summary>
            /// Enum Offset for value: Offset
            /// </summary>
            [EnumMember(Value = "Offset")]
            Offset = 4,
            /// <summary>
            /// Enum Cover for value: Cover
            /// </summary>
            [EnumMember(Value = "Cover")]
            Cover = 5,
            /// <summary>
            /// Enum Bristol for value: Bristol
            /// </summary>
            [EnumMember(Value = "Bristol")]
            Bristol = 6,
            /// <summary>
            /// Enum Index for value: Index
            /// </summary>
            [EnumMember(Value = "Index")]
            Index = 7,
            /// <summary>
            /// Enum Tag for value: Tag
            /// </summary>
            [EnumMember(Value = "Tag")]
            Tag = 8,
            /// <summary>
            /// Enum Card for value: Card
            /// </summary>
            [EnumMember(Value = "Card")]
            Card = 9        }
        /// <summary>
        /// Grade weight type for pound (Lb) standard weights
        /// </summary>
        /// <value>Grade weight type for pound (Lb) standard weights</value>
        [DataMember(Name="weight-type", EmitDefaultValue=false)]
        public WeightTypeEnum? WeightType { get; set; }
        /// <summary>
        /// Cost unit type of grade
        /// </summary>
        /// <value>Cost unit type of grade</value>
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
        /// Cost unit type of grade
        /// </summary>
        /// <value>Cost unit type of grade</value>
        [DataMember(Name="cost-units", EmitDefaultValue=false)]
        public CostUnitsEnum? CostUnits { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GradeEntity" /> class.
        /// </summary>
        /// <param name="name">Name of library item (required).</param>
        /// <param name="id">Unique ID of this item (auto-generated, read-only).</param>
        /// <param name="externalId">Optional external ID of media item.</param>
        /// <param name="description">Asset description.</param>
        /// <param name="gradeDisplay">Grade display.</param>
        /// <param name="weight">Grade weight value (required).</param>
        /// <param name="weightUnits">Grade weight units.</param>
        /// <param name="weightType">Grade weight type for pound (Lb) standard weights.</param>
        /// <param name="caliper">Caliper value (required).</param>
        /// <param name="cost">Cost of grade.</param>
        /// <param name="costUnits">Cost unit type of grade.</param>
        /// <param name="anySheetSize">When true, any sheet size that can fit on a given press is assumed available via a sheet converter, custom order, etc..</param>
        /// <param name="sheets">List of sheets specified for this grade.</param>
        /// <param name="rolls">List of rolls specified for this grade.</param>
        public GradeEntity(string name = default(string), string id = default(string), string externalId = default(string), string description = default(string), GradeDisplayEnum? gradeDisplay = default(GradeDisplayEnum?), double? weight = default(double?), WeightUnitsEnum? weightUnits = default(WeightUnitsEnum?), WeightTypeEnum? weightType = default(WeightTypeEnum?), string caliper = default(string), double? cost = default(double?), CostUnitsEnum? costUnits = default(CostUnitsEnum?), bool? anySheetSize = default(bool?), List<SheetEntity> sheets = default(List<SheetEntity>), List<RollEntity> rolls = default(List<RollEntity>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GradeEntity and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "weight" is required (not null)
            if (weight == null)
            {
                throw new InvalidDataException("weight is a required property for GradeEntity and cannot be null");
            }
            else
            {
                this.Weight = weight;
            }
            // to ensure "caliper" is required (not null)
            if (caliper == null)
            {
                throw new InvalidDataException("caliper is a required property for GradeEntity and cannot be null");
            }
            else
            {
                this.Caliper = caliper;
            }
            this.Id = id;
            this.ExternalId = externalId;
            this.Description = description;
            this.GradeDisplay = gradeDisplay;
            this.WeightUnits = weightUnits;
            this.WeightType = weightType;
            this.Cost = cost;
            this.CostUnits = costUnits;
            this.AnySheetSize = anySheetSize;
            this.Sheets = sheets;
            this.Rolls = rolls;
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
        /// Grade weight value
        /// </summary>
        /// <value>Grade weight value</value>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public double? Weight { get; set; }



        /// <summary>
        /// Caliper value
        /// </summary>
        /// <value>Caliper value</value>
        [DataMember(Name="caliper", EmitDefaultValue=false)]
        public string Caliper { get; set; }

        /// <summary>
        /// Cost of grade
        /// </summary>
        /// <value>Cost of grade</value>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public double? Cost { get; set; }


        /// <summary>
        /// When true, any sheet size that can fit on a given press is assumed available via a sheet converter, custom order, etc.
        /// </summary>
        /// <value>When true, any sheet size that can fit on a given press is assumed available via a sheet converter, custom order, etc.</value>
        [DataMember(Name="any-sheet-size", EmitDefaultValue=false)]
        public bool? AnySheetSize { get; set; }

        /// <summary>
        /// List of sheets specified for this grade
        /// </summary>
        /// <value>List of sheets specified for this grade</value>
        [DataMember(Name="sheets", EmitDefaultValue=false)]
        public List<SheetEntity> Sheets { get; set; }

        /// <summary>
        /// List of rolls specified for this grade
        /// </summary>
        /// <value>List of rolls specified for this grade</value>
        [DataMember(Name="rolls", EmitDefaultValue=false)]
        public List<RollEntity> Rolls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GradeEntity {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  GradeDisplay: ").Append(GradeDisplay).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  WeightUnits: ").Append(WeightUnits).Append("\n");
            sb.Append("  WeightType: ").Append(WeightType).Append("\n");
            sb.Append("  Caliper: ").Append(Caliper).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  CostUnits: ").Append(CostUnits).Append("\n");
            sb.Append("  AnySheetSize: ").Append(AnySheetSize).Append("\n");
            sb.Append("  Sheets: ").Append(Sheets).Append("\n");
            sb.Append("  Rolls: ").Append(Rolls).Append("\n");
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
            return this.Equals(input as GradeEntity);
        }

        /// <summary>
        /// Returns true if GradeEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of GradeEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GradeEntity input)
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
                    this.GradeDisplay == input.GradeDisplay ||
                    (this.GradeDisplay != null &&
                    this.GradeDisplay.Equals(input.GradeDisplay))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.WeightUnits == input.WeightUnits ||
                    (this.WeightUnits != null &&
                    this.WeightUnits.Equals(input.WeightUnits))
                ) && 
                (
                    this.WeightType == input.WeightType ||
                    (this.WeightType != null &&
                    this.WeightType.Equals(input.WeightType))
                ) && 
                (
                    this.Caliper == input.Caliper ||
                    (this.Caliper != null &&
                    this.Caliper.Equals(input.Caliper))
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
                    this.AnySheetSize == input.AnySheetSize ||
                    (this.AnySheetSize != null &&
                    this.AnySheetSize.Equals(input.AnySheetSize))
                ) && 
                (
                    this.Sheets == input.Sheets ||
                    this.Sheets != null &&
                    input.Sheets != null &&
                    this.Sheets.SequenceEqual(input.Sheets)
                ) && 
                (
                    this.Rolls == input.Rolls ||
                    this.Rolls != null &&
                    input.Rolls != null &&
                    this.Rolls.SequenceEqual(input.Rolls)
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
                if (this.GradeDisplay != null)
                    hashCode = hashCode * 59 + this.GradeDisplay.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.WeightUnits != null)
                    hashCode = hashCode * 59 + this.WeightUnits.GetHashCode();
                if (this.WeightType != null)
                    hashCode = hashCode * 59 + this.WeightType.GetHashCode();
                if (this.Caliper != null)
                    hashCode = hashCode * 59 + this.Caliper.GetHashCode();
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.CostUnits != null)
                    hashCode = hashCode * 59 + this.CostUnits.GetHashCode();
                if (this.AnySheetSize != null)
                    hashCode = hashCode * 59 + this.AnySheetSize.GetHashCode();
                if (this.Sheets != null)
                    hashCode = hashCode * 59 + this.Sheets.GetHashCode();
                if (this.Rolls != null)
                    hashCode = hashCode * 59 + this.Rolls.GetHashCode();
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