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
    /// Media rule
    /// </summary>
    [DataContract]
        public partial class MediaRule :  IEquatable<MediaRule>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum OperationMode for value: OperationMode
            /// </summary>
            [EnumMember(Value = "OperationMode")]
            OperationMode = 1,
            /// <summary>
            /// Enum MediaRule for value: MediaRule
            /// </summary>
            [EnumMember(Value = "MediaRule")]
            MediaRule = 2,
            /// <summary>
            /// Enum PressMediaRule for value: PressMediaRule
            /// </summary>
            [EnumMember(Value = "PressMediaRule")]
            PressMediaRule = 3,
            /// <summary>
            /// Enum DctRuleValue for value: DctRuleValue
            /// </summary>
            [EnumMember(Value = "DctRuleValue")]
            DctRuleValue = 4,
            /// <summary>
            /// Enum SteelRule for value: SteelRule
            /// </summary>
            [EnumMember(Value = "SteelRule")]
            SteelRule = 5        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaRule" /> class.
        /// </summary>
        /// <param name="marks">List of marks to apply with this media rule.</param>
        /// <param name="speedReduction">Speed reduction specified as a number where 1.0 represents no change.</param>
        /// <param name="content">content.</param>
        /// <param name="image">image.</param>
        /// <param name="type">type (required).</param>
        public MediaRule(List<DeviceMark> marks = default(List<DeviceMark>), string speedReduction = default(string), Margins content = default(Margins), Margins image = default(Margins), TypeEnum type = default(TypeEnum))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for MediaRule and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Marks = marks;
            this.SpeedReduction = speedReduction;
            this.Content = content;
            this.Image = image;
        }
        
        /// <summary>
        /// List of marks to apply with this media rule
        /// </summary>
        /// <value>List of marks to apply with this media rule</value>
        [DataMember(Name="marks", EmitDefaultValue=false)]
        public List<DeviceMark> Marks { get; set; }

        /// <summary>
        /// Speed reduction specified as a number where 1.0 represents no change
        /// </summary>
        /// <value>Speed reduction specified as a number where 1.0 represents no change</value>
        [DataMember(Name="speed-reduction", EmitDefaultValue=false)]
        public string SpeedReduction { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public Margins Content { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public Margins Image { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaRule {\n");
            sb.Append("  Marks: ").Append(Marks).Append("\n");
            sb.Append("  SpeedReduction: ").Append(SpeedReduction).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as MediaRule);
        }

        /// <summary>
        /// Returns true if MediaRule instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Marks == input.Marks ||
                    this.Marks != null &&
                    input.Marks != null &&
                    this.Marks.SequenceEqual(input.Marks)
                ) && 
                (
                    this.SpeedReduction == input.SpeedReduction ||
                    (this.SpeedReduction != null &&
                    this.SpeedReduction.Equals(input.SpeedReduction))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Marks != null)
                    hashCode = hashCode * 59 + this.Marks.GetHashCode();
                if (this.SpeedReduction != null)
                    hashCode = hashCode * 59 + this.SpeedReduction.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
