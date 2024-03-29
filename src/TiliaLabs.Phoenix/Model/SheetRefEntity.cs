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
    /// Reference to sheet or roll
    /// </summary>
    [DataContract]
        public partial class SheetRefEntity :  IEquatable<SheetRefEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SheetRefEntity" /> class.
        /// </summary>
        /// <param name="stock">Name of sheet stock.</param>
        /// <param name="grade">Name of sheet grade.</param>
        /// <param name="name">Name of sheet or roll within stock to use.</param>
        public SheetRefEntity(string stock = default(string), string grade = default(string), string name = default(string))
        {
            this.Stock = stock;
            this.Grade = grade;
            this.Name = name;
        }
        
        /// <summary>
        /// Name of sheet stock
        /// </summary>
        /// <value>Name of sheet stock</value>
        [DataMember(Name="stock", EmitDefaultValue=false)]
        public string Stock { get; set; }

        /// <summary>
        /// Name of sheet grade
        /// </summary>
        /// <value>Name of sheet grade</value>
        [DataMember(Name="grade", EmitDefaultValue=false)]
        public string Grade { get; set; }

        /// <summary>
        /// Name of sheet or roll within stock to use
        /// </summary>
        /// <value>Name of sheet or roll within stock to use</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SheetRefEntity {\n");
            sb.Append("  Stock: ").Append(Stock).Append("\n");
            sb.Append("  Grade: ").Append(Grade).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as SheetRefEntity);
        }

        /// <summary>
        /// Returns true if SheetRefEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of SheetRefEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SheetRefEntity input)
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
                    this.Grade == input.Grade ||
                    (this.Grade != null &&
                    this.Grade.Equals(input.Grade))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Grade != null)
                    hashCode = hashCode * 59 + this.Grade.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
