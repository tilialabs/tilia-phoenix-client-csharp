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
    /// Sheet Reference
    /// </summary>
    [DataContract]
        public partial class SheetRef :  IEquatable<SheetRef>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SheetRef" /> class.
        /// </summary>
        /// <param name="media">media (required).</param>
        /// <param name="sheetId">Sheet ID (required).</param>
        public SheetRef(MaterialRef media = default(MaterialRef), string sheetId = default(string))
        {
            // to ensure "media" is required (not null)
            if (media == null)
            {
                throw new InvalidDataException("media is a required property for SheetRef and cannot be null");
            }
            else
            {
                this.Media = media;
            }
            // to ensure "sheetId" is required (not null)
            if (sheetId == null)
            {
                throw new InvalidDataException("sheetId is a required property for SheetRef and cannot be null");
            }
            else
            {
                this.SheetId = sheetId;
            }
        }
        
        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public MaterialRef Media { get; set; }

        /// <summary>
        /// Sheet ID
        /// </summary>
        /// <value>Sheet ID</value>
        [DataMember(Name="sheet-id", EmitDefaultValue=false)]
        public string SheetId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SheetRef {\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  SheetId: ").Append(SheetId).Append("\n");
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
            return this.Equals(input as SheetRef);
        }

        /// <summary>
        /// Returns true if SheetRef instances are equal
        /// </summary>
        /// <param name="input">Instance of SheetRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SheetRef input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Media == input.Media ||
                    (this.Media != null &&
                    this.Media.Equals(input.Media))
                ) && 
                (
                    this.SheetId == input.SheetId ||
                    (this.SheetId != null &&
                    this.SheetId.Equals(input.SheetId))
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
                if (this.Media != null)
                    hashCode = hashCode * 59 + this.Media.GetHashCode();
                if (this.SheetId != null)
                    hashCode = hashCode * 59 + this.SheetId.GetHashCode();
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
