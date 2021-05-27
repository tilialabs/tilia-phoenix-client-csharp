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
    /// Sheet position
    /// </summary>
    [DataContract]
        public partial class SheetPosition :  IEquatable<SheetPosition>, IValidatableObject
    {
        /// <summary>
        /// Align X
        /// </summary>
        /// <value>Align X</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum AlignXEnum
        {
            /// <summary>
            /// Enum Left for value: Left
            /// </summary>
            [EnumMember(Value = "Left")]
            Left = 1,
            /// <summary>
            /// Enum Right for value: Right
            /// </summary>
            [EnumMember(Value = "Right")]
            Right = 2,
            /// <summary>
            /// Enum Center for value: Center
            /// </summary>
            [EnumMember(Value = "Center")]
            Center = 3        }
        /// <summary>
        /// Align X
        /// </summary>
        /// <value>Align X</value>
        [DataMember(Name="align-x", EmitDefaultValue=false)]
        public AlignXEnum AlignX { get; set; }
        /// <summary>
        /// Align Y
        /// </summary>
        /// <value>Align Y</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum AlignYEnum
        {
            /// <summary>
            /// Enum Top for value: Top
            /// </summary>
            [EnumMember(Value = "Top")]
            Top = 1,
            /// <summary>
            /// Enum Center for value: Center
            /// </summary>
            [EnumMember(Value = "Center")]
            Center = 2,
            /// <summary>
            /// Enum Bottom for value: Bottom
            /// </summary>
            [EnumMember(Value = "Bottom")]
            Bottom = 3,
            /// <summary>
            /// Enum Punch for value: Punch
            /// </summary>
            [EnumMember(Value = "Punch")]
            Punch = 4        }
        /// <summary>
        /// Align Y
        /// </summary>
        /// <value>Align Y</value>
        [DataMember(Name="align-y", EmitDefaultValue=false)]
        public AlignYEnum AlignY { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SheetPosition" /> class.
        /// </summary>
        /// <param name="alignX">Align X (required).</param>
        /// <param name="alignY">Align Y (required).</param>
        /// <param name="offsetX">Offset X.</param>
        /// <param name="offsetY">Offset Y.</param>
        public SheetPosition(AlignXEnum alignX = default(AlignXEnum), AlignYEnum alignY = default(AlignYEnum), string offsetX = default(string), string offsetY = default(string))
        {
            // to ensure "alignX" is required (not null)
            if (alignX == null)
            {
                throw new InvalidDataException("alignX is a required property for SheetPosition and cannot be null");
            }
            else
            {
                this.AlignX = alignX;
            }
            // to ensure "alignY" is required (not null)
            if (alignY == null)
            {
                throw new InvalidDataException("alignY is a required property for SheetPosition and cannot be null");
            }
            else
            {
                this.AlignY = alignY;
            }
            this.OffsetX = offsetX;
            this.OffsetY = offsetY;
        }
        


        /// <summary>
        /// Offset X
        /// </summary>
        /// <value>Offset X</value>
        [DataMember(Name="offset-x", EmitDefaultValue=false)]
        public string OffsetX { get; set; }

        /// <summary>
        /// Offset Y
        /// </summary>
        /// <value>Offset Y</value>
        [DataMember(Name="offset-y", EmitDefaultValue=false)]
        public string OffsetY { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SheetPosition {\n");
            sb.Append("  AlignX: ").Append(AlignX).Append("\n");
            sb.Append("  AlignY: ").Append(AlignY).Append("\n");
            sb.Append("  OffsetX: ").Append(OffsetX).Append("\n");
            sb.Append("  OffsetY: ").Append(OffsetY).Append("\n");
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
            return this.Equals(input as SheetPosition);
        }

        /// <summary>
        /// Returns true if SheetPosition instances are equal
        /// </summary>
        /// <param name="input">Instance of SheetPosition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SheetPosition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlignX == input.AlignX ||
                    (this.AlignX != null &&
                    this.AlignX.Equals(input.AlignX))
                ) && 
                (
                    this.AlignY == input.AlignY ||
                    (this.AlignY != null &&
                    this.AlignY.Equals(input.AlignY))
                ) && 
                (
                    this.OffsetX == input.OffsetX ||
                    (this.OffsetX != null &&
                    this.OffsetX.Equals(input.OffsetX))
                ) && 
                (
                    this.OffsetY == input.OffsetY ||
                    (this.OffsetY != null &&
                    this.OffsetY.Equals(input.OffsetY))
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
                if (this.AlignX != null)
                    hashCode = hashCode * 59 + this.AlignX.GetHashCode();
                if (this.AlignY != null)
                    hashCode = hashCode * 59 + this.AlignY.GetHashCode();
                if (this.OffsetX != null)
                    hashCode = hashCode * 59 + this.OffsetX.GetHashCode();
                if (this.OffsetY != null)
                    hashCode = hashCode * 59 + this.OffsetY.GetHashCode();
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