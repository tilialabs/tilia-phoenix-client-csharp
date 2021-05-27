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
    /// Settings used for vertical/horizontal/template strategies
    /// </summary>
    [DataContract]
        public partial class StripOptionsEntity :  IEquatable<StripOptionsEntity>, IValidatableObject
    {
        /// <summary>
        /// Strip rule
        /// </summary>
        /// <value>Strip rule</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StripRuleEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            /// <summary>
            /// Enum SameProduct for value: SameProduct
            /// </summary>
            [EnumMember(Value = "SameProduct")]
            SameProduct = 2,
            /// <summary>
            /// Enum SameDimensions for value: SameDimensions
            /// </summary>
            [EnumMember(Value = "SameDimensions")]
            SameDimensions = 3,
            /// <summary>
            /// Enum SameWidth for value: SameWidth
            /// </summary>
            [EnumMember(Value = "SameWidth")]
            SameWidth = 4,
            /// <summary>
            /// Enum SameHeight for value: SameHeight
            /// </summary>
            [EnumMember(Value = "SameHeight")]
            SameHeight = 5,
            /// <summary>
            /// Enum SameShape for value: SameShape
            /// </summary>
            [EnumMember(Value = "SameShape")]
            SameShape = 6,
            /// <summary>
            /// Enum SameColors for value: SameColors
            /// </summary>
            [EnumMember(Value = "SameColors")]
            SameColors = 7,
            /// <summary>
            /// Enum SameVarnish for value: SameVarnish
            /// </summary>
            [EnumMember(Value = "SameVarnish")]
            SameVarnish = 8,
            /// <summary>
            /// Enum SameFoil for value: SameFoil
            /// </summary>
            [EnumMember(Value = "SameFoil")]
            SameFoil = 9,
            /// <summary>
            /// Enum HasVarnish for value: HasVarnish
            /// </summary>
            [EnumMember(Value = "HasVarnish")]
            HasVarnish = 10,
            /// <summary>
            /// Enum HasFoil for value: HasFoil
            /// </summary>
            [EnumMember(Value = "HasFoil")]
            HasFoil = 11,
            /// <summary>
            /// Enum SameProperty for value: SameProperty
            /// </summary>
            [EnumMember(Value = "SameProperty")]
            SameProperty = 12        }
        /// <summary>
        /// Strip rule
        /// </summary>
        /// <value>Strip rule</value>
        [DataMember(Name="strip-rule", EmitDefaultValue=false)]
        public StripRuleEnum? StripRule { get; set; }
        /// <summary>
        /// Template rule
        /// </summary>
        /// <value>Template rule</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TemplateRuleEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            /// <summary>
            /// Enum Vertical for value: Vertical
            /// </summary>
            [EnumMember(Value = "Vertical")]
            Vertical = 2,
            /// <summary>
            /// Enum Horizontal for value: Horizontal
            /// </summary>
            [EnumMember(Value = "Horizontal")]
            Horizontal = 3        }
        /// <summary>
        /// Template rule
        /// </summary>
        /// <value>Template rule</value>
        [DataMember(Name="template-rule", EmitDefaultValue=false)]
        public TemplateRuleEnum? TemplateRule { get; set; }
        /// <summary>
        /// Strip alignment
        /// </summary>
        /// <value>Strip alignment</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum AlignmentEnum
        {
            /// <summary>
            /// Enum TopLeft for value: TopLeft
            /// </summary>
            [EnumMember(Value = "TopLeft")]
            TopLeft = 1,
            /// <summary>
            /// Enum TopCenter for value: TopCenter
            /// </summary>
            [EnumMember(Value = "TopCenter")]
            TopCenter = 2,
            /// <summary>
            /// Enum TopRight for value: TopRight
            /// </summary>
            [EnumMember(Value = "TopRight")]
            TopRight = 3,
            /// <summary>
            /// Enum CenterLeft for value: CenterLeft
            /// </summary>
            [EnumMember(Value = "CenterLeft")]
            CenterLeft = 4,
            /// <summary>
            /// Enum Center for value: Center
            /// </summary>
            [EnumMember(Value = "Center")]
            Center = 5,
            /// <summary>
            /// Enum CenterRight for value: CenterRight
            /// </summary>
            [EnumMember(Value = "CenterRight")]
            CenterRight = 6,
            /// <summary>
            /// Enum BottomLeft for value: BottomLeft
            /// </summary>
            [EnumMember(Value = "BottomLeft")]
            BottomLeft = 7,
            /// <summary>
            /// Enum BottomCenter for value: BottomCenter
            /// </summary>
            [EnumMember(Value = "BottomCenter")]
            BottomCenter = 8,
            /// <summary>
            /// Enum BottomRight for value: BottomRight
            /// </summary>
            [EnumMember(Value = "BottomRight")]
            BottomRight = 9        }
        /// <summary>
        /// Strip alignment
        /// </summary>
        /// <value>Strip alignment</value>
        [DataMember(Name="alignment", EmitDefaultValue=false)]
        public AlignmentEnum? Alignment { get; set; }
        /// <summary>
        /// Gutter rule
        /// </summary>
        /// <value>Gutter rule</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum GutterRuleEnum
        {
            /// <summary>
            /// Enum Always for value: Always
            /// </summary>
            [EnumMember(Value = "Always")]
            Always = 1,
            /// <summary>
            /// Enum ProductsDiffer for value: ProductsDiffer
            /// </summary>
            [EnumMember(Value = "ProductsDiffer")]
            ProductsDiffer = 2,
            /// <summary>
            /// Enum DimensionsDiffer for value: DimensionsDiffer
            /// </summary>
            [EnumMember(Value = "DimensionsDiffer")]
            DimensionsDiffer = 3,
            /// <summary>
            /// Enum WidthsDiffer for value: WidthsDiffer
            /// </summary>
            [EnumMember(Value = "WidthsDiffer")]
            WidthsDiffer = 4,
            /// <summary>
            /// Enum HeightsDiffer for value: HeightsDiffer
            /// </summary>
            [EnumMember(Value = "HeightsDiffer")]
            HeightsDiffer = 5,
            /// <summary>
            /// Enum ColorsDiffer for value: ColorsDiffer
            /// </summary>
            [EnumMember(Value = "ColorsDiffer")]
            ColorsDiffer = 6,
            /// <summary>
            /// Enum VarnishesDiffer for value: VarnishesDiffer
            /// </summary>
            [EnumMember(Value = "VarnishesDiffer")]
            VarnishesDiffer = 7,
            /// <summary>
            /// Enum FoilsDiffer for value: FoilsDiffer
            /// </summary>
            [EnumMember(Value = "FoilsDiffer")]
            FoilsDiffer = 8,
            /// <summary>
            /// Enum HasVarnish for value: HasVarnish
            /// </summary>
            [EnumMember(Value = "HasVarnish")]
            HasVarnish = 9,
            /// <summary>
            /// Enum HasFoil for value: HasFoil
            /// </summary>
            [EnumMember(Value = "HasFoil")]
            HasFoil = 10        }
        /// <summary>
        /// Gutter rule
        /// </summary>
        /// <value>Gutter rule</value>
        [DataMember(Name="gutter-rule", EmitDefaultValue=false)]
        public GutterRuleEnum? GutterRule { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StripOptionsEntity" /> class.
        /// </summary>
        /// <param name="stripRule">Strip rule.</param>
        /// <param name="templateRule">Template rule.</param>
        /// <param name="property">Product property to compare when using the \&quot;SameProperty\&quot; strip rule.</param>
        /// <param name="alignment">Strip alignment.</param>
        /// <param name="gutter">Gutter value.</param>
        /// <param name="gutterRule">Gutter rule.</param>
        public StripOptionsEntity(StripRuleEnum? stripRule = default(StripRuleEnum?), TemplateRuleEnum? templateRule = default(TemplateRuleEnum?), string property = default(string), AlignmentEnum? alignment = default(AlignmentEnum?), string gutter = default(string), GutterRuleEnum? gutterRule = default(GutterRuleEnum?))
        {
            this.StripRule = stripRule;
            this.TemplateRule = templateRule;
            this.Property = property;
            this.Alignment = alignment;
            this.Gutter = gutter;
            this.GutterRule = gutterRule;
        }
        


        /// <summary>
        /// Product property to compare when using the \&quot;SameProperty\&quot; strip rule
        /// </summary>
        /// <value>Product property to compare when using the \&quot;SameProperty\&quot; strip rule</value>
        [DataMember(Name="property", EmitDefaultValue=false)]
        public string Property { get; set; }


        /// <summary>
        /// Gutter value
        /// </summary>
        /// <value>Gutter value</value>
        [DataMember(Name="gutter", EmitDefaultValue=false)]
        public string Gutter { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StripOptionsEntity {\n");
            sb.Append("  StripRule: ").Append(StripRule).Append("\n");
            sb.Append("  TemplateRule: ").Append(TemplateRule).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  Alignment: ").Append(Alignment).Append("\n");
            sb.Append("  Gutter: ").Append(Gutter).Append("\n");
            sb.Append("  GutterRule: ").Append(GutterRule).Append("\n");
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
            return this.Equals(input as StripOptionsEntity);
        }

        /// <summary>
        /// Returns true if StripOptionsEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of StripOptionsEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StripOptionsEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StripRule == input.StripRule ||
                    (this.StripRule != null &&
                    this.StripRule.Equals(input.StripRule))
                ) && 
                (
                    this.TemplateRule == input.TemplateRule ||
                    (this.TemplateRule != null &&
                    this.TemplateRule.Equals(input.TemplateRule))
                ) && 
                (
                    this.Property == input.Property ||
                    (this.Property != null &&
                    this.Property.Equals(input.Property))
                ) && 
                (
                    this.Alignment == input.Alignment ||
                    (this.Alignment != null &&
                    this.Alignment.Equals(input.Alignment))
                ) && 
                (
                    this.Gutter == input.Gutter ||
                    (this.Gutter != null &&
                    this.Gutter.Equals(input.Gutter))
                ) && 
                (
                    this.GutterRule == input.GutterRule ||
                    (this.GutterRule != null &&
                    this.GutterRule.Equals(input.GutterRule))
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
                if (this.StripRule != null)
                    hashCode = hashCode * 59 + this.StripRule.GetHashCode();
                if (this.TemplateRule != null)
                    hashCode = hashCode * 59 + this.TemplateRule.GetHashCode();
                if (this.Property != null)
                    hashCode = hashCode * 59 + this.Property.GetHashCode();
                if (this.Alignment != null)
                    hashCode = hashCode * 59 + this.Alignment.GetHashCode();
                if (this.Gutter != null)
                    hashCode = hashCode * 59 + this.Gutter.GetHashCode();
                if (this.GutterRule != null)
                    hashCode = hashCode * 59 + this.GutterRule.GetHashCode();
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