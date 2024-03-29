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
    /// Import product CSV action resource
    /// </summary>
    [DataContract]
        public partial class ImportProductCsvResource :  IEquatable<ImportProductCsvResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProductCsvResource" /> class.
        /// </summary>
        /// <param name="idref">ID of action resource is being applied to (Hot Folders only).</param>
        /// <param name="path">Full path of file name (required).</param>
        /// <param name="preset">Name of CSV import preset to use.</param>
        /// <param name="baseFolder">Optional base folder to use for relative paths.</param>
        public ImportProductCsvResource(int? idref = default(int?), string path = default(string), string preset = default(string), string baseFolder = default(string))
        {
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new InvalidDataException("path is a required property for ImportProductCsvResource and cannot be null");
            }
            else
            {
                this.Path = path;
            }
            this.Idref = idref;
            this.Preset = preset;
            this.BaseFolder = baseFolder;
        }
        
        /// <summary>
        /// ID of action resource is being applied to (Hot Folders only)
        /// </summary>
        /// <value>ID of action resource is being applied to (Hot Folders only)</value>
        [DataMember(Name="idref", EmitDefaultValue=false)]
        public int? Idref { get; set; }

        /// <summary>
        /// Full path of file name
        /// </summary>
        /// <value>Full path of file name</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Name of CSV import preset to use
        /// </summary>
        /// <value>Name of CSV import preset to use</value>
        [DataMember(Name="preset", EmitDefaultValue=false)]
        public string Preset { get; set; }

        /// <summary>
        /// Optional base folder to use for relative paths
        /// </summary>
        /// <value>Optional base folder to use for relative paths</value>
        [DataMember(Name="base-folder", EmitDefaultValue=false)]
        public string BaseFolder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportProductCsvResource {\n");
            sb.Append("  Idref: ").Append(Idref).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Preset: ").Append(Preset).Append("\n");
            sb.Append("  BaseFolder: ").Append(BaseFolder).Append("\n");
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
            return this.Equals(input as ImportProductCsvResource);
        }

        /// <summary>
        /// Returns true if ImportProductCsvResource instances are equal
        /// </summary>
        /// <param name="input">Instance of ImportProductCsvResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportProductCsvResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Idref == input.Idref ||
                    (this.Idref != null &&
                    this.Idref.Equals(input.Idref))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Preset == input.Preset ||
                    (this.Preset != null &&
                    this.Preset.Equals(input.Preset))
                ) && 
                (
                    this.BaseFolder == input.BaseFolder ||
                    (this.BaseFolder != null &&
                    this.BaseFolder.Equals(input.BaseFolder))
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
                if (this.Idref != null)
                    hashCode = hashCode * 59 + this.Idref.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Preset != null)
                    hashCode = hashCode * 59 + this.Preset.GetHashCode();
                if (this.BaseFolder != null)
                    hashCode = hashCode * 59 + this.BaseFolder.GetHashCode();
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
