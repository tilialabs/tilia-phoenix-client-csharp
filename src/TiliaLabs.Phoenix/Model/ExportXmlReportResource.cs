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
    /// Export XML report action resource
    /// </summary>
    [DataContract]
        public partial class ExportXmlReportResource :  IEquatable<ExportXmlReportResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportXmlReportResource" /> class.
        /// </summary>
        /// <param name="idref">ID of action resource is being applied to (Hot Folders only).</param>
        /// <param name="path">Full path to store output file(s).  When not set, the output file(s) will be stored on the server and download link(s) will be provided in the response..</param>
        /// <param name="preset">Name of preset to use.</param>
        public ExportXmlReportResource(int? idref = default(int?), string path = default(string), string preset = default(string))
        {
            this.Idref = idref;
            this.Path = path;
            this.Preset = preset;
        }
        
        /// <summary>
        /// ID of action resource is being applied to (Hot Folders only)
        /// </summary>
        /// <value>ID of action resource is being applied to (Hot Folders only)</value>
        [DataMember(Name="idref", EmitDefaultValue=false)]
        public int? Idref { get; set; }

        /// <summary>
        /// Full path to store output file(s).  When not set, the output file(s) will be stored on the server and download link(s) will be provided in the response.
        /// </summary>
        /// <value>Full path to store output file(s).  When not set, the output file(s) will be stored on the server and download link(s) will be provided in the response.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Name of preset to use
        /// </summary>
        /// <value>Name of preset to use</value>
        [DataMember(Name="preset", EmitDefaultValue=false)]
        public string Preset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportXmlReportResource {\n");
            sb.Append("  Idref: ").Append(Idref).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Preset: ").Append(Preset).Append("\n");
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
            return this.Equals(input as ExportXmlReportResource);
        }

        /// <summary>
        /// Returns true if ExportXmlReportResource instances are equal
        /// </summary>
        /// <param name="input">Instance of ExportXmlReportResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportXmlReportResource input)
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
