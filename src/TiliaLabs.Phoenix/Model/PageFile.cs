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
    /// Page assignment state for the page
    /// </summary>
    [DataContract]
        public partial class PageFile :  IEquatable<PageFile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageFile" /> class.
        /// </summary>
        /// <param name="path">Full path to the file.</param>
        /// <param name="number">Page number used from the file.</param>
        /// <param name="width">Artwork page width.</param>
        /// <param name="height">Artwork page height.</param>
        /// <param name="checksum">File checksum.</param>
        /// <param name="timestamp">Timestamp recorded for file.</param>
        public PageFile(string path = default(string), int? number = default(int?), double? width = default(double?), double? height = default(double?), string checksum = default(string), long? timestamp = default(long?))
        {
            this.Path = path;
            this.Number = number;
            this.Width = width;
            this.Height = height;
            this.Checksum = checksum;
            this.Timestamp = timestamp;
        }
        
        /// <summary>
        /// Full path to the file
        /// </summary>
        /// <value>Full path to the file</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Page number used from the file
        /// </summary>
        /// <value>Page number used from the file</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public int? Number { get; set; }

        /// <summary>
        /// Artwork page width
        /// </summary>
        /// <value>Artwork page width</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public double? Width { get; set; }

        /// <summary>
        /// Artwork page height
        /// </summary>
        /// <value>Artwork page height</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public double? Height { get; set; }

        /// <summary>
        /// File checksum
        /// </summary>
        /// <value>File checksum</value>
        [DataMember(Name="checksum", EmitDefaultValue=false)]
        public string Checksum { get; set; }

        /// <summary>
        /// Timestamp recorded for file
        /// </summary>
        /// <value>Timestamp recorded for file</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageFile {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Checksum: ").Append(Checksum).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as PageFile);
        }

        /// <summary>
        /// Returns true if PageFile instances are equal
        /// </summary>
        /// <param name="input">Instance of PageFile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageFile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Checksum == input.Checksum ||
                    (this.Checksum != null &&
                    this.Checksum.Equals(input.Checksum))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Checksum != null)
                    hashCode = hashCode * 59 + this.Checksum.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
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
