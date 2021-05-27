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
    /// Material Reference
    /// </summary>
    [DataContract]
        public partial class MaterialRef :  IEquatable<MaterialRef>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialRef" /> class.
        /// </summary>
        /// <param name="stock">stock (required).</param>
        /// <param name="gradeId">Grade ID (required).</param>
        public MaterialRef(Reference stock = default(Reference), string gradeId = default(string))
        {
            // to ensure "stock" is required (not null)
            if (stock == null)
            {
                throw new InvalidDataException("stock is a required property for MaterialRef and cannot be null");
            }
            else
            {
                this.Stock = stock;
            }
            // to ensure "gradeId" is required (not null)
            if (gradeId == null)
            {
                throw new InvalidDataException("gradeId is a required property for MaterialRef and cannot be null");
            }
            else
            {
                this.GradeId = gradeId;
            }
        }
        
        /// <summary>
        /// Gets or Sets Stock
        /// </summary>
        [DataMember(Name="stock", EmitDefaultValue=false)]
        public Reference Stock { get; set; }

        /// <summary>
        /// Grade ID
        /// </summary>
        /// <value>Grade ID</value>
        [DataMember(Name="grade-id", EmitDefaultValue=false)]
        public string GradeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaterialRef {\n");
            sb.Append("  Stock: ").Append(Stock).Append("\n");
            sb.Append("  GradeId: ").Append(GradeId).Append("\n");
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
            return this.Equals(input as MaterialRef);
        }

        /// <summary>
        /// Returns true if MaterialRef instances are equal
        /// </summary>
        /// <param name="input">Instance of MaterialRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaterialRef input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Stock == input.Stock ||
                    (this.Stock != null &&
                    this.Stock.Equals(input.Stock))
                ) && 
                (
                    this.GradeId == input.GradeId ||
                    (this.GradeId != null &&
                    this.GradeId.Equals(input.GradeId))
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
                if (this.Stock != null)
                    hashCode = hashCode * 59 + this.Stock.GetHashCode();
                if (this.GradeId != null)
                    hashCode = hashCode * 59 + this.GradeId.GetHashCode();
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