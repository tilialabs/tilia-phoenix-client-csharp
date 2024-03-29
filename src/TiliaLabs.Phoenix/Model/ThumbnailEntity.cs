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
    /// Binary thumbnail image data
    /// </summary>
    [DataContract]
        public partial class ThumbnailEntity :  IEquatable<ThumbnailEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThumbnailEntity" /> class.
        /// </summary>
        /// <param name="data">Base64 encoded binary image data.</param>
        /// <param name="mediaType">Image media type format.</param>
        /// <param name="width">Width of thumbnail image in pixels.</param>
        /// <param name="height">Height of thumbnail image in pixels.</param>
        public ThumbnailEntity(string data = default(string), string mediaType = default(string), int? width = default(int?), int? height = default(int?))
        {
            this.Data = data;
            this.MediaType = mediaType;
            this.Width = width;
            this.Height = height;
        }
        
        /// <summary>
        /// Base64 encoded binary image data
        /// </summary>
        /// <value>Base64 encoded binary image data</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }

        /// <summary>
        /// Image media type format
        /// </summary>
        /// <value>Image media type format</value>
        [DataMember(Name="media-type", EmitDefaultValue=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// Width of thumbnail image in pixels
        /// </summary>
        /// <value>Width of thumbnail image in pixels</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Height of thumbnail image in pixels
        /// </summary>
        /// <value>Height of thumbnail image in pixels</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThumbnailEntity {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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
            return this.Equals(input as ThumbnailEntity);
        }

        /// <summary>
        /// Returns true if ThumbnailEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of ThumbnailEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThumbnailEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.MediaType == input.MediaType ||
                    (this.MediaType != null &&
                    this.MediaType.Equals(input.MediaType))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.MediaType != null)
                    hashCode = hashCode * 59 + this.MediaType.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
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
