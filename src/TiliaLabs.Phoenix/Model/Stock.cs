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
    /// Stock library item
    /// </summary>
    [DataContract]
        public partial class Stock :  IEquatable<Stock>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stock" /> class.
        /// </summary>
        /// <param name="name">Name (required).</param>
        /// <param name="description">Description.</param>
        /// <param name="notes">Notes.</param>
        /// <param name="externalId">External ID.</param>
        /// <param name="stockType">stockType.</param>
        /// <param name="vendor">Stock vendor name.</param>
        /// <param name="grades">List of grades specified for this stock.</param>
        /// <param name="properties">Custom properties.</param>
        /// <param name="path">Path.</param>
        public Stock(string name = default(string), string description = default(string), string notes = default(string), string externalId = default(string), Reference stockType = default(Reference), string vendor = default(string), List<Grade> grades = default(List<Grade>), List<PropertyObject> properties = default(List<PropertyObject>), string path = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Stock and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Description = description;
            this.Notes = notes;
            this.ExternalId = externalId;
            this.StockType = stockType;
            this.Vendor = vendor;
            this.Grades = grades;
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
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
        /// Gets or Sets StockType
        /// </summary>
        [DataMember(Name="stock-type", EmitDefaultValue=false)]
        public Reference StockType { get; set; }

        /// <summary>
        /// Stock vendor name
        /// </summary>
        /// <value>Stock vendor name</value>
        [DataMember(Name="vendor", EmitDefaultValue=false)]
        public string Vendor { get; set; }

        /// <summary>
        /// List of grades specified for this stock
        /// </summary>
        /// <value>List of grades specified for this stock</value>
        [DataMember(Name="grades", EmitDefaultValue=false)]
        public List<Grade> Grades { get; set; }

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
            sb.Append("class Stock {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  StockType: ").Append(StockType).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  Grades: ").Append(Grades).Append("\n");
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
            return this.Equals(input as Stock);
        }

        /// <summary>
        /// Returns true if Stock instances are equal
        /// </summary>
        /// <param name="input">Instance of Stock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Stock input)
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
                    this.StockType == input.StockType ||
                    (this.StockType != null &&
                    this.StockType.Equals(input.StockType))
                ) && 
                (
                    this.Vendor == input.Vendor ||
                    (this.Vendor != null &&
                    this.Vendor.Equals(input.Vendor))
                ) && 
                (
                    this.Grades == input.Grades ||
                    this.Grades != null &&
                    input.Grades != null &&
                    this.Grades.SequenceEqual(input.Grades)
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
                if (this.StockType != null)
                    hashCode = hashCode * 59 + this.StockType.GetHashCode();
                if (this.Vendor != null)
                    hashCode = hashCode * 59 + this.Vendor.GetHashCode();
                if (this.Grades != null)
                    hashCode = hashCode * 59 + this.Grades.GetHashCode();
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