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
        public partial class Sheet :  IEquatable<Sheet>, IValidatableObject
    {
        /// <summary>
        /// Cost unit type of this sheet when not defined from grade
        /// </summary>
        /// <value>Cost unit type of this sheet when not defined from grade</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum CostUnitsEnum
        {
            /// <summary>
            /// Enum FromGrade for value: From Grade
            /// </summary>
            [EnumMember(Value = "From Grade")]
            FromGrade = 1,
            /// <summary>
            /// Enum PerSheet for value: Per Sheet
            /// </summary>
            [EnumMember(Value = "Per Sheet")]
            PerSheet = 2,
            /// <summary>
            /// Enum Per500Sheets for value: Per 500 Sheets
            /// </summary>
            [EnumMember(Value = "Per 500 Sheets")]
            Per500Sheets = 3,
            /// <summary>
            /// Enum Per1000Sheets for value: Per 1000 Sheets
            /// </summary>
            [EnumMember(Value = "Per 1000 Sheets")]
            Per1000Sheets = 4,
            /// <summary>
            /// Enum Perlb for value: Per lb
            /// </summary>
            [EnumMember(Value = "Per lb")]
            Perlb = 5,
            /// <summary>
            /// Enum Per500lb for value: Per 500 lb
            /// </summary>
            [EnumMember(Value = "Per 500 lb")]
            Per500lb = 6,
            /// <summary>
            /// Enum Per1000lb for value: Per 1000 lb
            /// </summary>
            [EnumMember(Value = "Per 1000 lb")]
            Per1000lb = 7,
            /// <summary>
            /// Enum Perkg for value: Per kg
            /// </summary>
            [EnumMember(Value = "Per kg")]
            Perkg = 8,
            /// <summary>
            /// Enum Per1000kg for value: Per 1000 kg
            /// </summary>
            [EnumMember(Value = "Per 1000 kg")]
            Per1000kg = 9,
            /// <summary>
            /// Enum Perft for value: Per ft²
            /// </summary>
            [EnumMember(Value = "Per ft²")]
            Perft = 10,
            /// <summary>
            /// Enum Perm for value: Per m²
            /// </summary>
            [EnumMember(Value = "Per m²")]
            Perm = 11,
            /// <summary>
            /// Enum Perft_11 for value: Per ft
            /// </summary>
            [EnumMember(Value = "Per ft")]
            Perft_11 = 12,
            /// <summary>
            /// Enum Perm_12 for value: Per m
            /// </summary>
            [EnumMember(Value = "Per m")]
            Perm_12 = 13        }
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
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Sheet for value: Sheet
            /// </summary>
            [EnumMember(Value = "Sheet")]
            Sheet = 1,
            /// <summary>
            /// Enum Roll for value: Roll
            /// </summary>
            [EnumMember(Value = "Roll")]
            Roll = 2        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Sheet" /> class.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <param name="notes">Notes.</param>
        /// <param name="externalId">External ID.</param>
        /// <param name="dimension1">First dimension of this sheet (required).</param>
        /// <param name="cost">Cost of this sheet when cost not defined from grade.</param>
        /// <param name="costUnits">Cost unit type of this sheet when not defined from grade.</param>
        /// <param name="dimension2">Second dimension of this sheet (required).</param>
        /// <param name="grain">The grain of this sheet.  Grain is inferred by dimension2 when not specified..</param>
        /// <param name="type">type (required).</param>
        /// <param name="properties">Custom properties.</param>
        /// <param name="path">Path.</param>
        public Sheet(string description = default(string), string notes = default(string), string externalId = default(string), string dimension1 = default(string), double? cost = default(double?), CostUnitsEnum? costUnits = default(CostUnitsEnum?), string dimension2 = default(string), GrainEnum? grain = default(GrainEnum?), TypeEnum type = default(TypeEnum), List<PropertyObject> properties = default(List<PropertyObject>), string path = default(string))
        {
            // to ensure "dimension1" is required (not null)
            if (dimension1 == null)
            {
                throw new InvalidDataException("dimension1 is a required property for Sheet and cannot be null");
            }
            else
            {
                this.Dimension1 = dimension1;
            }
            // to ensure "dimension2" is required (not null)
            if (dimension2 == null)
            {
                throw new InvalidDataException("dimension2 is a required property for Sheet and cannot be null");
            }
            else
            {
                this.Dimension2 = dimension2;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Sheet and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Description = description;
            this.Notes = notes;
            this.ExternalId = externalId;
            this.Cost = cost;
            this.CostUnits = costUnits;
            this.Grain = grain;
            this.Properties = properties;
            this.Path = path;
        }
        
        /// <summary>
        /// Unique ID
        /// </summary>
        /// <value>Unique ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// Read-only sheet name derived from the sheet dimensions
        /// </summary>
        /// <value>Read-only sheet name derived from the sheet dimensions</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Created On
        /// </summary>
        /// <value>Created On</value>
        [DataMember(Name="created-on", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// Modified On
        /// </summary>
        /// <value>Modified On</value>
        [DataMember(Name="modified-on", EmitDefaultValue=false)]
        public DateTime? ModifiedOn { get; private set; }

        /// <summary>
        /// Version
        /// </summary>
        /// <value>Version</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; private set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        /// <value>Notes</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// External ID
        /// </summary>
        /// <value>External ID</value>
        [DataMember(Name="external-id", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// First dimension of this sheet
        /// </summary>
        /// <value>First dimension of this sheet</value>
        [DataMember(Name="dimension1", EmitDefaultValue=false)]
        public string Dimension1 { get; set; }

        /// <summary>
        /// Cost of this sheet when cost not defined from grade
        /// </summary>
        /// <value>Cost of this sheet when cost not defined from grade</value>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public double? Cost { get; set; }


        /// <summary>
        /// Second dimension of this sheet
        /// </summary>
        /// <value>Second dimension of this sheet</value>
        [DataMember(Name="dimension2", EmitDefaultValue=false)]
        public string Dimension2 { get; set; }



        /// <summary>
        /// Custom properties
        /// </summary>
        /// <value>Custom properties</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<PropertyObject> Properties { get; set; }

        /// <summary>
        /// Path
        /// </summary>
        /// <value>Path</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Sheet {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Dimension1: ").Append(Dimension1).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  CostUnits: ").Append(CostUnits).Append("\n");
            sb.Append("  Dimension2: ").Append(Dimension2).Append("\n");
            sb.Append("  Grain: ").Append(Grain).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
            return this.Equals(input as Sheet);
        }

        /// <summary>
        /// Returns true if Sheet instances are equal
        /// </summary>
        /// <param name="input">Instance of Sheet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Sheet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.ModifiedOn == input.ModifiedOn ||
                    (this.ModifiedOn != null &&
                    this.ModifiedOn.Equals(input.ModifiedOn))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Dimension1 == input.Dimension1 ||
                    (this.Dimension1 != null &&
                    this.Dimension1.Equals(input.Dimension1))
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
                    this.Dimension2 == input.Dimension2 ||
                    (this.Dimension2 != null &&
                    this.Dimension2.Equals(input.Dimension2))
                ) && 
                (
                    this.Grain == input.Grain ||
                    (this.Grain != null &&
                    this.Grain.Equals(input.Grain))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.ModifiedOn != null)
                    hashCode = hashCode * 59 + this.ModifiedOn.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Dimension1 != null)
                    hashCode = hashCode * 59 + this.Dimension1.GetHashCode();
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.CostUnits != null)
                    hashCode = hashCode * 59 + this.CostUnits.GetHashCode();
                if (this.Dimension2 != null)
                    hashCode = hashCode * 59 + this.Dimension2.GetHashCode();
                if (this.Grain != null)
                    hashCode = hashCode * 59 + this.Grain.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
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
