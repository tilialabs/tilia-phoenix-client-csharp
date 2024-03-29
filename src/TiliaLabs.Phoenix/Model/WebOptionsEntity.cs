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
    /// Settings used for web-based plans
    /// </summary>
    [DataContract]
        public partial class WebOptionsEntity :  IEquatable<WebOptionsEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebOptionsEntity" /> class.
        /// </summary>
        /// <param name="allowSignatureFrameSpanning">Allow signatures to span frames.</param>
        public WebOptionsEntity(bool? allowSignatureFrameSpanning = default(bool?))
        {
            this.AllowSignatureFrameSpanning = allowSignatureFrameSpanning;
        }
        
        /// <summary>
        /// Allow signatures to span frames
        /// </summary>
        /// <value>Allow signatures to span frames</value>
        [DataMember(Name="allow-signature-frame-spanning", EmitDefaultValue=false)]
        public bool? AllowSignatureFrameSpanning { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebOptionsEntity {\n");
            sb.Append("  AllowSignatureFrameSpanning: ").Append(AllowSignatureFrameSpanning).Append("\n");
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
            return this.Equals(input as WebOptionsEntity);
        }

        /// <summary>
        /// Returns true if WebOptionsEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of WebOptionsEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebOptionsEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowSignatureFrameSpanning == input.AllowSignatureFrameSpanning ||
                    (this.AllowSignatureFrameSpanning != null &&
                    this.AllowSignatureFrameSpanning.Equals(input.AllowSignatureFrameSpanning))
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
                if (this.AllowSignatureFrameSpanning != null)
                    hashCode = hashCode * 59 + this.AllowSignatureFrameSpanning.GetHashCode();
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
