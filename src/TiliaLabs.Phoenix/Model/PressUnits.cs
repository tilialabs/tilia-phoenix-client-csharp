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
    /// Press Units
    /// </summary>
    [DataContract]
        public partial class PressUnits :  IEquatable<PressUnits>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PressUnits" /> class.
        /// </summary>
        /// <param name="units">Units (required).</param>
        /// <param name="coatings">Coatings (required).</param>
        /// <param name="foils">Foils (required).</param>
        public PressUnits(int? units = default(int?), int? coatings = default(int?), int? foils = default(int?))
        {
            // to ensure "units" is required (not null)
            if (units == null)
            {
                throw new InvalidDataException("units is a required property for PressUnits and cannot be null");
            }
            else
            {
                this.Units = units;
            }
            // to ensure "coatings" is required (not null)
            if (coatings == null)
            {
                throw new InvalidDataException("coatings is a required property for PressUnits and cannot be null");
            }
            else
            {
                this.Coatings = coatings;
            }
            // to ensure "foils" is required (not null)
            if (foils == null)
            {
                throw new InvalidDataException("foils is a required property for PressUnits and cannot be null");
            }
            else
            {
                this.Foils = foils;
            }
        }
        
        /// <summary>
        /// Units
        /// </summary>
        /// <value>Units</value>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public int? Units { get; set; }

        /// <summary>
        /// Coatings
        /// </summary>
        /// <value>Coatings</value>
        [DataMember(Name="coatings", EmitDefaultValue=false)]
        public int? Coatings { get; set; }

        /// <summary>
        /// Foils
        /// </summary>
        /// <value>Foils</value>
        [DataMember(Name="foils", EmitDefaultValue=false)]
        public int? Foils { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PressUnits {\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  Coatings: ").Append(Coatings).Append("\n");
            sb.Append("  Foils: ").Append(Foils).Append("\n");
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
            return this.Equals(input as PressUnits);
        }

        /// <summary>
        /// Returns true if PressUnits instances are equal
        /// </summary>
        /// <param name="input">Instance of PressUnits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PressUnits input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Units == input.Units ||
                    (this.Units != null &&
                    this.Units.Equals(input.Units))
                ) && 
                (
                    this.Coatings == input.Coatings ||
                    (this.Coatings != null &&
                    this.Coatings.Equals(input.Coatings))
                ) && 
                (
                    this.Foils == input.Foils ||
                    (this.Foils != null &&
                    this.Foils.Equals(input.Foils))
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
                if (this.Units != null)
                    hashCode = hashCode * 59 + this.Units.GetHashCode();
                if (this.Coatings != null)
                    hashCode = hashCode * 59 + this.Coatings.GetHashCode();
                if (this.Foils != null)
                    hashCode = hashCode * 59 + this.Foils.GetHashCode();
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
