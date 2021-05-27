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
    /// Bound part for creating books
    /// </summary>
    [DataContract]
        public partial class BoundPart :  IEquatable<BoundPart>, IValidatableObject
    {
        /// <summary>
        /// Part grain
        /// </summary>
        /// <value>Part grain</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum GrainEnum
        {
            /// <summary>
            /// Enum Horizontal for value: Horizontal
            /// </summary>
            [EnumMember(Value = "Horizontal")]
            Horizontal = 1,
            /// <summary>
            /// Enum Vertical for value: Vertical
            /// </summary>
            [EnumMember(Value = "Vertical")]
            Vertical = 2,
            /// <summary>
            /// Enum Consistent for value: Consistent
            /// </summary>
            [EnumMember(Value = "Consistent")]
            Consistent = 3,
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 4        }
        /// <summary>
        /// Part grain
        /// </summary>
        /// <value>Part grain</value>
        [DataMember(Name="grain", EmitDefaultValue=false)]
        public GrainEnum Grain { get; set; }
        /// <summary>
        /// Binding method of this part
        /// </summary>
        /// <value>Binding method of this part</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum BindingMethodEnum
        {
            /// <summary>
            /// Enum PerfectBound for value: Perfect Bound
            /// </summary>
            [EnumMember(Value = "Perfect Bound")]
            PerfectBound = 1,
            /// <summary>
            /// Enum SaddleStitch for value: Saddle Stitch
            /// </summary>
            [EnumMember(Value = "Saddle Stitch")]
            SaddleStitch = 2,
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 3        }
        /// <summary>
        /// Binding method of this part
        /// </summary>
        /// <value>Binding method of this part</value>
        [DataMember(Name="binding-method", EmitDefaultValue=false)]
        public BindingMethodEnum BindingMethod { get; set; }
        /// <summary>
        /// Binding edge of this part
        /// </summary>
        /// <value>Binding edge of this part</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum BindingEdgeEnum
        {
            /// <summary>
            /// Enum Top for value: Top
            /// </summary>
            [EnumMember(Value = "Top")]
            Top = 1,
            /// <summary>
            /// Enum Bottom for value: Bottom
            /// </summary>
            [EnumMember(Value = "Bottom")]
            Bottom = 2,
            /// <summary>
            /// Enum Right for value: Right
            /// </summary>
            [EnumMember(Value = "Right")]
            Right = 3,
            /// <summary>
            /// Enum Left for value: Left
            /// </summary>
            [EnumMember(Value = "Left")]
            Left = 4        }
        /// <summary>
        /// Binding edge of this part
        /// </summary>
        /// <value>Binding edge of this part</value>
        [DataMember(Name="binding-edge", EmitDefaultValue=false)]
        public BindingEdgeEnum BindingEdge { get; set; }
        /// <summary>
        /// Jog edge of this part
        /// </summary>
        /// <value>Jog edge of this part</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum JogEdgeEnum
        {
            /// <summary>
            /// Enum Top for value: Top
            /// </summary>
            [EnumMember(Value = "Top")]
            Top = 1,
            /// <summary>
            /// Enum Bottom for value: Bottom
            /// </summary>
            [EnumMember(Value = "Bottom")]
            Bottom = 2,
            /// <summary>
            /// Enum Right for value: Right
            /// </summary>
            [EnumMember(Value = "Right")]
            Right = 3,
            /// <summary>
            /// Enum Left for value: Left
            /// </summary>
            [EnumMember(Value = "Left")]
            Left = 4        }
        /// <summary>
        /// Jog edge of this part
        /// </summary>
        /// <value>Jog edge of this part</value>
        [DataMember(Name="jog-edge", EmitDefaultValue=false)]
        public JogEdgeEnum JogEdge { get; set; }
        /// <summary>
        /// Reading order of this part
        /// </summary>
        /// <value>Reading order of this part</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ReadingOrderEnum
        {
            /// <summary>
            /// Enum Normal for value: Normal
            /// </summary>
            [EnumMember(Value = "Normal")]
            Normal = 1,
            /// <summary>
            /// Enum Calendar for value: Calendar
            /// </summary>
            [EnumMember(Value = "Calendar")]
            Calendar = 2        }
        /// <summary>
        /// Reading order of this part
        /// </summary>
        /// <value>Reading order of this part</value>
        [DataMember(Name="reading-order", EmitDefaultValue=false)]
        public ReadingOrderEnum ReadingOrder { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Flat for value: Flat
            /// </summary>
            [EnumMember(Value = "Flat")]
            Flat = 1,
            /// <summary>
            /// Enum Bound for value: Bound
            /// </summary>
            [EnumMember(Value = "Bound")]
            Bound = 2,
            /// <summary>
            /// Enum Folded for value: Folded
            /// </summary>
            [EnumMember(Value = "Folded")]
            Folded = 3,
            /// <summary>
            /// Enum Tiled for value: Tiled
            /// </summary>
            [EnumMember(Value = "Tiled")]
            Tiled = 4        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BoundPart" /> class.
        /// </summary>
        /// <param name="name">Name (required).</param>
        /// <param name="grain">Part grain (required).</param>
        /// <param name="pages">Part pages (required).</param>
        /// <param name="processSettings">Part process settings (required).</param>
        /// <param name="rotation">rotation (required).</param>
        /// <param name="pageSize">pageSize (required).</param>
        /// <param name="sections">Part sections (required).</param>
        /// <param name="bindingMethod">Binding method of this part (required).</param>
        /// <param name="pagesPerSection">Pages per section in this part.</param>
        /// <param name="bindingEdge">Binding edge of this part (required).</param>
        /// <param name="jogEdge">Jog edge of this part (required).</param>
        /// <param name="readingOrder">Reading order of this part (required).</param>
        /// <param name="selfCover">Whether this part has a self cover or not (required).</param>
        /// <param name="trim">trim (required).</param>
        /// <param name="creep">creep (required).</param>
        /// <param name="allowedFolds">Allowed folds in this part.</param>
        /// <param name="type">type (required).</param>
        /// <param name="material">material.</param>
        /// <param name="processes">Part processes.</param>
        public BoundPart(string name = default(string), GrainEnum grain = default(GrainEnum), List<Page> pages = default(List<Page>), List<ProcessSetting> processSettings = default(List<ProcessSetting>), Rotation rotation = default(Rotation), Size pageSize = default(Size), List<BoundSection> sections = default(List<BoundSection>), BindingMethodEnum bindingMethod = default(BindingMethodEnum), int? pagesPerSection = default(int?), BindingEdgeEnum bindingEdge = default(BindingEdgeEnum), JogEdgeEnum jogEdge = default(JogEdgeEnum), ReadingOrderEnum readingOrder = default(ReadingOrderEnum), bool? selfCover = default(bool?), Trim trim = default(Trim), Creep creep = default(Creep), List<FoldingPattern> allowedFolds = default(List<FoldingPattern>), TypeEnum type = default(TypeEnum), Material material = default(Material), List<Process> processes = default(List<Process>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for BoundPart and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "grain" is required (not null)
            if (grain == null)
            {
                throw new InvalidDataException("grain is a required property for BoundPart and cannot be null");
            }
            else
            {
                this.Grain = grain;
            }
            // to ensure "pages" is required (not null)
            if (pages == null)
            {
                throw new InvalidDataException("pages is a required property for BoundPart and cannot be null");
            }
            else
            {
                this.Pages = pages;
            }
            // to ensure "processSettings" is required (not null)
            if (processSettings == null)
            {
                throw new InvalidDataException("processSettings is a required property for BoundPart and cannot be null");
            }
            else
            {
                this.ProcessSettings = processSettings;
            }
            // to ensure "rotation" is required (not null)
            if (rotation == null)
            {
                throw new InvalidDataException("rotation is a required property for BoundPart and cannot be null");
            }
            else
            {
                this.Rotation = rotation;
            }
            // to ensure "pageSize" is required (not null)
            if (pageSize == null)
            {
                throw new InvalidDataException("pageSize is a required property for BoundPart and cannot be null");
            }
            else
            {
                this.PageSize = pageSize;
            }
            // to ensure "sections" is required (not null)
            if (sections == null)
            {
                throw new InvalidDataException("sections is a required property for BoundPart and cannot be null");
            }
            else
            {
                this.Sections = sections;
            }
            // to ensure "bindingMethod" is required (not null)
            if (bindingMethod == null)
            {
                throw new InvalidDataException("bindingMethod is a required property for BoundPart and cannot be null");
            }
            else
            {
                this.BindingMethod = bindingMethod;
            }
            // to ensure "bindingEdge" is required (not null)
            if (bindingEdge == null)
            {
                throw new InvalidDataException("bindingEdge is a required property for BoundPart and cannot be null");
            }
            else
            {
                this.BindingEdge = bindingEdge;
            }
            // to ensure "jogEdge" is required (not null)
            if (jogEdge == null)
            {
                throw new InvalidDataException("jogEdge is a required property for BoundPart and cannot be null");
            }
            else
            {
                this.JogEdge = jogEdge;
            }
            // to ensure "readingOrder" is required (not null)
            if (readingOrder == null)
            {
                throw new InvalidDataException("readingOrder is a required property for BoundPart and cannot be null");
            }
            else
            {
                this.ReadingOrder = readingOrder;
            }
            // to ensure "selfCover" is required (not null)
            if (selfCover == null)
            {
                throw new InvalidDataException("selfCover is a required property for BoundPart and cannot be null");
            }
            else
            {
                this.SelfCover = selfCover;
            }
            // to ensure "trim" is required (not null)
            if (trim == null)
            {
                throw new InvalidDataException("trim is a required property for BoundPart and cannot be null");
            }
            else
            {
                this.Trim = trim;
            }
            // to ensure "creep" is required (not null)
            if (creep == null)
            {
                throw new InvalidDataException("creep is a required property for BoundPart and cannot be null");
            }
            else
            {
                this.Creep = creep;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for BoundPart and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.PagesPerSection = pagesPerSection;
            this.AllowedFolds = allowedFolds;
            this.Material = material;
            this.Processes = processes;
        }
        
        /// <summary>
        /// Unique ID
        /// </summary>
        /// <value>Unique ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Part pages
        /// </summary>
        /// <value>Part pages</value>
        [DataMember(Name="pages", EmitDefaultValue=false)]
        public List<Page> Pages { get; set; }

        /// <summary>
        /// Part process settings
        /// </summary>
        /// <value>Part process settings</value>
        [DataMember(Name="process-settings", EmitDefaultValue=false)]
        public List<ProcessSetting> ProcessSettings { get; set; }

        /// <summary>
        /// Gets or Sets Rotation
        /// </summary>
        [DataMember(Name="rotation", EmitDefaultValue=false)]
        public Rotation Rotation { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name="page-size", EmitDefaultValue=false)]
        public Size PageSize { get; set; }

        /// <summary>
        /// Part sections
        /// </summary>
        /// <value>Part sections</value>
        [DataMember(Name="sections", EmitDefaultValue=false)]
        public List<BoundSection> Sections { get; set; }


        /// <summary>
        /// Pages per section in this part
        /// </summary>
        /// <value>Pages per section in this part</value>
        [DataMember(Name="pages-per-section", EmitDefaultValue=false)]
        public int? PagesPerSection { get; set; }




        /// <summary>
        /// Whether this part has a self cover or not
        /// </summary>
        /// <value>Whether this part has a self cover or not</value>
        [DataMember(Name="self-cover", EmitDefaultValue=false)]
        public bool? SelfCover { get; set; }

        /// <summary>
        /// Gets or Sets Trim
        /// </summary>
        [DataMember(Name="trim", EmitDefaultValue=false)]
        public Trim Trim { get; set; }

        /// <summary>
        /// Gets or Sets Creep
        /// </summary>
        [DataMember(Name="creep", EmitDefaultValue=false)]
        public Creep Creep { get; set; }

        /// <summary>
        /// Allowed folds in this part
        /// </summary>
        /// <value>Allowed folds in this part</value>
        [DataMember(Name="allowed-folds", EmitDefaultValue=false)]
        public List<FoldingPattern> AllowedFolds { get; set; }


        /// <summary>
        /// Gets or Sets Material
        /// </summary>
        [DataMember(Name="material", EmitDefaultValue=false)]
        public Material Material { get; set; }

        /// <summary>
        /// Part processes
        /// </summary>
        /// <value>Part processes</value>
        [DataMember(Name="processes", EmitDefaultValue=false)]
        public List<Process> Processes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoundPart {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Grain: ").Append(Grain).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
            sb.Append("  ProcessSettings: ").Append(ProcessSettings).Append("\n");
            sb.Append("  Rotation: ").Append(Rotation).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Sections: ").Append(Sections).Append("\n");
            sb.Append("  BindingMethod: ").Append(BindingMethod).Append("\n");
            sb.Append("  PagesPerSection: ").Append(PagesPerSection).Append("\n");
            sb.Append("  BindingEdge: ").Append(BindingEdge).Append("\n");
            sb.Append("  JogEdge: ").Append(JogEdge).Append("\n");
            sb.Append("  ReadingOrder: ").Append(ReadingOrder).Append("\n");
            sb.Append("  SelfCover: ").Append(SelfCover).Append("\n");
            sb.Append("  Trim: ").Append(Trim).Append("\n");
            sb.Append("  Creep: ").Append(Creep).Append("\n");
            sb.Append("  AllowedFolds: ").Append(AllowedFolds).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Material: ").Append(Material).Append("\n");
            sb.Append("  Processes: ").Append(Processes).Append("\n");
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
            return this.Equals(input as BoundPart);
        }

        /// <summary>
        /// Returns true if BoundPart instances are equal
        /// </summary>
        /// <param name="input">Instance of BoundPart to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoundPart input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Grain == input.Grain ||
                    (this.Grain != null &&
                    this.Grain.Equals(input.Grain))
                ) && 
                (
                    this.Pages == input.Pages ||
                    this.Pages != null &&
                    input.Pages != null &&
                    this.Pages.SequenceEqual(input.Pages)
                ) && 
                (
                    this.ProcessSettings == input.ProcessSettings ||
                    this.ProcessSettings != null &&
                    input.ProcessSettings != null &&
                    this.ProcessSettings.SequenceEqual(input.ProcessSettings)
                ) && 
                (
                    this.Rotation == input.Rotation ||
                    (this.Rotation != null &&
                    this.Rotation.Equals(input.Rotation))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.Sections == input.Sections ||
                    this.Sections != null &&
                    input.Sections != null &&
                    this.Sections.SequenceEqual(input.Sections)
                ) && 
                (
                    this.BindingMethod == input.BindingMethod ||
                    (this.BindingMethod != null &&
                    this.BindingMethod.Equals(input.BindingMethod))
                ) && 
                (
                    this.PagesPerSection == input.PagesPerSection ||
                    (this.PagesPerSection != null &&
                    this.PagesPerSection.Equals(input.PagesPerSection))
                ) && 
                (
                    this.BindingEdge == input.BindingEdge ||
                    (this.BindingEdge != null &&
                    this.BindingEdge.Equals(input.BindingEdge))
                ) && 
                (
                    this.JogEdge == input.JogEdge ||
                    (this.JogEdge != null &&
                    this.JogEdge.Equals(input.JogEdge))
                ) && 
                (
                    this.ReadingOrder == input.ReadingOrder ||
                    (this.ReadingOrder != null &&
                    this.ReadingOrder.Equals(input.ReadingOrder))
                ) && 
                (
                    this.SelfCover == input.SelfCover ||
                    (this.SelfCover != null &&
                    this.SelfCover.Equals(input.SelfCover))
                ) && 
                (
                    this.Trim == input.Trim ||
                    (this.Trim != null &&
                    this.Trim.Equals(input.Trim))
                ) && 
                (
                    this.Creep == input.Creep ||
                    (this.Creep != null &&
                    this.Creep.Equals(input.Creep))
                ) && 
                (
                    this.AllowedFolds == input.AllowedFolds ||
                    this.AllowedFolds != null &&
                    input.AllowedFolds != null &&
                    this.AllowedFolds.SequenceEqual(input.AllowedFolds)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Material == input.Material ||
                    (this.Material != null &&
                    this.Material.Equals(input.Material))
                ) && 
                (
                    this.Processes == input.Processes ||
                    this.Processes != null &&
                    input.Processes != null &&
                    this.Processes.SequenceEqual(input.Processes)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Grain != null)
                    hashCode = hashCode * 59 + this.Grain.GetHashCode();
                if (this.Pages != null)
                    hashCode = hashCode * 59 + this.Pages.GetHashCode();
                if (this.ProcessSettings != null)
                    hashCode = hashCode * 59 + this.ProcessSettings.GetHashCode();
                if (this.Rotation != null)
                    hashCode = hashCode * 59 + this.Rotation.GetHashCode();
                if (this.PageSize != null)
                    hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.Sections != null)
                    hashCode = hashCode * 59 + this.Sections.GetHashCode();
                if (this.BindingMethod != null)
                    hashCode = hashCode * 59 + this.BindingMethod.GetHashCode();
                if (this.PagesPerSection != null)
                    hashCode = hashCode * 59 + this.PagesPerSection.GetHashCode();
                if (this.BindingEdge != null)
                    hashCode = hashCode * 59 + this.BindingEdge.GetHashCode();
                if (this.JogEdge != null)
                    hashCode = hashCode * 59 + this.JogEdge.GetHashCode();
                if (this.ReadingOrder != null)
                    hashCode = hashCode * 59 + this.ReadingOrder.GetHashCode();
                if (this.SelfCover != null)
                    hashCode = hashCode * 59 + this.SelfCover.GetHashCode();
                if (this.Trim != null)
                    hashCode = hashCode * 59 + this.Trim.GetHashCode();
                if (this.Creep != null)
                    hashCode = hashCode * 59 + this.Creep.GetHashCode();
                if (this.AllowedFolds != null)
                    hashCode = hashCode * 59 + this.AllowedFolds.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Material != null)
                    hashCode = hashCode * 59 + this.Material.GetHashCode();
                if (this.Processes != null)
                    hashCode = hashCode * 59 + this.Processes.GetHashCode();
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