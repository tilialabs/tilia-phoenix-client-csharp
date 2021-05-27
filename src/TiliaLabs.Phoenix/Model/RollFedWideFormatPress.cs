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
    /// Roll-fed Wide Format Press
    /// </summary>
    [DataContract]
        public partial class RollFedWideFormatPress :  IEquatable<RollFedWideFormatPress>, IValidatableObject
    {
        /// <summary>
        /// Feed type of this device
        /// </summary>
        /// <value>Feed type of this device</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum FeedTypeEnum
        {
            /// <summary>
            /// Enum Roll for value: Roll
            /// </summary>
            [EnumMember(Value = "Roll")]
            Roll = 1,
            /// <summary>
            /// Enum Sheet for value: Sheet
            /// </summary>
            [EnumMember(Value = "Sheet")]
            Sheet = 2        }
        /// <summary>
        /// Feed type of this device
        /// </summary>
        /// <value>Feed type of this device</value>
        [DataMember(Name="feed-type", EmitDefaultValue=false)]
        public FeedTypeEnum FeedType { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum SheetFedDigitalPress for value: SheetFedDigitalPress
            /// </summary>
            [EnumMember(Value = "SheetFedDigitalPress")]
            SheetFedDigitalPress = 1,
            /// <summary>
            /// Enum WebFedDigitalPress for value: WebFedDigitalPress
            /// </summary>
            [EnumMember(Value = "WebFedDigitalPress")]
            WebFedDigitalPress = 2,
            /// <summary>
            /// Enum SheetFedOffsetPress for value: SheetFedOffsetPress
            /// </summary>
            [EnumMember(Value = "SheetFedOffsetPress")]
            SheetFedOffsetPress = 3,
            /// <summary>
            /// Enum WebFedOffsetPress for value: WebFedOffsetPress
            /// </summary>
            [EnumMember(Value = "WebFedOffsetPress")]
            WebFedOffsetPress = 4,
            /// <summary>
            /// Enum FlatbedWideFormatPress for value: FlatbedWideFormatPress
            /// </summary>
            [EnumMember(Value = "FlatbedWideFormatPress")]
            FlatbedWideFormatPress = 5,
            /// <summary>
            /// Enum RollFedWideFormatPress for value: RollFedWideFormatPress
            /// </summary>
            [EnumMember(Value = "RollFedWideFormatPress")]
            RollFedWideFormatPress = 6,
            /// <summary>
            /// Enum GuillotineCutter for value: GuillotineCutter
            /// </summary>
            [EnumMember(Value = "GuillotineCutter")]
            GuillotineCutter = 7,
            /// <summary>
            /// Enum FlatbedDieCutter for value: FlatbedDieCutter
            /// </summary>
            [EnumMember(Value = "FlatbedDieCutter")]
            FlatbedDieCutter = 8,
            /// <summary>
            /// Enum DigitalCuttingTable for value: DigitalCuttingTable
            /// </summary>
            [EnumMember(Value = "DigitalCuttingTable")]
            DigitalCuttingTable = 9,
            /// <summary>
            /// Enum DieMaking for value: DieMaking
            /// </summary>
            [EnumMember(Value = "DieMaking")]
            DieMaking = 10        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RollFedWideFormatPress" /> class.
        /// </summary>
        /// <param name="name">Name (required).</param>
        /// <param name="description">Description.</param>
        /// <param name="notes">Notes.</param>
        /// <param name="externalId">External ID.</param>
        /// <param name="allowPassThrough">Allow pass-through.</param>
        /// <param name="connections">Direct connections to other things.</param>
        /// <param name="costing">costing (required).</param>
        /// <param name="capabilities">capabilities (required).</param>
        /// <param name="script">script.</param>
        /// <param name="manufacturer">Manufacturer (required).</param>
        /// <param name="mediaRules">mediaRules (required).</param>
        /// <param name="placement">placement (required).</param>
        /// <param name="operation">operation (required).</param>
        /// <param name="frontUnits">frontUnits (required).</param>
        /// <param name="singlePassDoubleSided">Single Pass Double Sided.</param>
        /// <param name="backUnits">backUnits.</param>
        /// <param name="doubleSidedSpeedReduction">Double Sided Speed Reduction.</param>
        /// <param name="gripper">Gripper.</param>
        /// <param name="feedType">Feed type of this device (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="processType">processType (required).</param>
        /// <param name="properties">Custom properties.</param>
        /// <param name="path">Path.</param>
        public RollFedWideFormatPress(string name = default(string), string description = default(string), string notes = default(string), string externalId = default(string), bool? allowPassThrough = default(bool?), List<Connector> connections = default(List<Connector>), RfwfpCosting costing = default(RfwfpCosting), PressCapabilities capabilities = default(PressCapabilities), Reference script = default(Reference), string manufacturer = default(string), PressMediaRules mediaRules = default(PressMediaRules), PressPlacement placement = default(PressPlacement), OperationModes operation = default(OperationModes), PressUnits frontUnits = default(PressUnits), bool? singlePassDoubleSided = default(bool?), PressUnits backUnits = default(PressUnits), string doubleSidedSpeedReduction = default(string), string gripper = default(string), FeedTypeEnum feedType = default(FeedTypeEnum), TypeEnum type = default(TypeEnum), ProcessType processType = default(ProcessType), List<PropertyObject> properties = default(List<PropertyObject>), string path = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for RollFedWideFormatPress and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "costing" is required (not null)
            if (costing == null)
            {
                throw new InvalidDataException("costing is a required property for RollFedWideFormatPress and cannot be null");
            }
            else
            {
                this.Costing = costing;
            }
            // to ensure "capabilities" is required (not null)
            if (capabilities == null)
            {
                throw new InvalidDataException("capabilities is a required property for RollFedWideFormatPress and cannot be null");
            }
            else
            {
                this.Capabilities = capabilities;
            }
            // to ensure "manufacturer" is required (not null)
            if (manufacturer == null)
            {
                throw new InvalidDataException("manufacturer is a required property for RollFedWideFormatPress and cannot be null");
            }
            else
            {
                this.Manufacturer = manufacturer;
            }
            // to ensure "mediaRules" is required (not null)
            if (mediaRules == null)
            {
                throw new InvalidDataException("mediaRules is a required property for RollFedWideFormatPress and cannot be null");
            }
            else
            {
                this.MediaRules = mediaRules;
            }
            // to ensure "placement" is required (not null)
            if (placement == null)
            {
                throw new InvalidDataException("placement is a required property for RollFedWideFormatPress and cannot be null");
            }
            else
            {
                this.Placement = placement;
            }
            // to ensure "operation" is required (not null)
            if (operation == null)
            {
                throw new InvalidDataException("operation is a required property for RollFedWideFormatPress and cannot be null");
            }
            else
            {
                this.Operation = operation;
            }
            // to ensure "frontUnits" is required (not null)
            if (frontUnits == null)
            {
                throw new InvalidDataException("frontUnits is a required property for RollFedWideFormatPress and cannot be null");
            }
            else
            {
                this.FrontUnits = frontUnits;
            }
            // to ensure "feedType" is required (not null)
            if (feedType == null)
            {
                throw new InvalidDataException("feedType is a required property for RollFedWideFormatPress and cannot be null");
            }
            else
            {
                this.FeedType = feedType;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for RollFedWideFormatPress and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "processType" is required (not null)
            if (processType == null)
            {
                throw new InvalidDataException("processType is a required property for RollFedWideFormatPress and cannot be null");
            }
            else
            {
                this.ProcessType = processType;
            }
            this.Description = description;
            this.Notes = notes;
            this.ExternalId = externalId;
            this.AllowPassThrough = allowPassThrough;
            this.Connections = connections;
            this.Script = script;
            this.SinglePassDoubleSided = singlePassDoubleSided;
            this.BackUnits = backUnits;
            this.DoubleSidedSpeedReduction = doubleSidedSpeedReduction;
            this.Gripper = gripper;
            this.Properties = properties;
            this.Path = path;
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
        /// Created On
        /// </summary>
        /// <value>Created On</value>
        [DataMember(Name="created-on", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// Modified On
        /// </summary>
        /// <value>Modified On</value>
        [DataMember(Name="modified-on", EmitDefaultValue=false)]
        public DateTime? ModifiedOn { get; private set; }

        /// <summary>
        /// Version
        /// </summary>
        /// <value>Version</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; private set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        /// <value>Notes</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// External ID
        /// </summary>
        /// <value>External ID</value>
        [DataMember(Name="external-id", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Allow pass-through
        /// </summary>
        /// <value>Allow pass-through</value>
        [DataMember(Name="allow-pass-through", EmitDefaultValue=false)]
        public bool? AllowPassThrough { get; set; }

        /// <summary>
        /// Direct connections to other things
        /// </summary>
        /// <value>Direct connections to other things</value>
        [DataMember(Name="connections", EmitDefaultValue=false)]
        public List<Connector> Connections { get; set; }

        /// <summary>
        /// Gets or Sets Costing
        /// </summary>
        [DataMember(Name="costing", EmitDefaultValue=false)]
        public RfwfpCosting Costing { get; set; }

        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name="capabilities", EmitDefaultValue=false)]
        public PressCapabilities Capabilities { get; set; }

        /// <summary>
        /// Gets or Sets Script
        /// </summary>
        [DataMember(Name="script", EmitDefaultValue=false)]
        public Reference Script { get; set; }

        /// <summary>
        /// Manufacturer
        /// </summary>
        /// <value>Manufacturer</value>
        [DataMember(Name="manufacturer", EmitDefaultValue=false)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// Gets or Sets MediaRules
        /// </summary>
        [DataMember(Name="media-rules", EmitDefaultValue=false)]
        public PressMediaRules MediaRules { get; set; }

        /// <summary>
        /// Gets or Sets Placement
        /// </summary>
        [DataMember(Name="placement", EmitDefaultValue=false)]
        public PressPlacement Placement { get; set; }

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public OperationModes Operation { get; set; }

        /// <summary>
        /// Gets or Sets FrontUnits
        /// </summary>
        [DataMember(Name="front-units", EmitDefaultValue=false)]
        public PressUnits FrontUnits { get; set; }

        /// <summary>
        /// Single Pass Double Sided
        /// </summary>
        /// <value>Single Pass Double Sided</value>
        [DataMember(Name="single-pass-double-sided", EmitDefaultValue=false)]
        public bool? SinglePassDoubleSided { get; set; }

        /// <summary>
        /// Gets or Sets BackUnits
        /// </summary>
        [DataMember(Name="back-units", EmitDefaultValue=false)]
        public PressUnits BackUnits { get; set; }

        /// <summary>
        /// Double Sided Speed Reduction
        /// </summary>
        /// <value>Double Sided Speed Reduction</value>
        [DataMember(Name="double-sided-speed-reduction", EmitDefaultValue=false)]
        public string DoubleSidedSpeedReduction { get; set; }

        /// <summary>
        /// Gripper
        /// </summary>
        /// <value>Gripper</value>
        [DataMember(Name="gripper", EmitDefaultValue=false)]
        public string Gripper { get; set; }



        /// <summary>
        /// Gets or Sets ProcessType
        /// </summary>
        [DataMember(Name="process-type", EmitDefaultValue=false)]
        public ProcessType ProcessType { get; set; }

        /// <summary>
        /// Custom properties
        /// </summary>
        /// <value>Custom properties</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<PropertyObject> Properties { get; set; }

        /// <summary>
        /// Path
        /// </summary>
        /// <value>Path</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RollFedWideFormatPress {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  AllowPassThrough: ").Append(AllowPassThrough).Append("\n");
            sb.Append("  Connections: ").Append(Connections).Append("\n");
            sb.Append("  Costing: ").Append(Costing).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  Script: ").Append(Script).Append("\n");
            sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
            sb.Append("  MediaRules: ").Append(MediaRules).Append("\n");
            sb.Append("  Placement: ").Append(Placement).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  FrontUnits: ").Append(FrontUnits).Append("\n");
            sb.Append("  SinglePassDoubleSided: ").Append(SinglePassDoubleSided).Append("\n");
            sb.Append("  BackUnits: ").Append(BackUnits).Append("\n");
            sb.Append("  DoubleSidedSpeedReduction: ").Append(DoubleSidedSpeedReduction).Append("\n");
            sb.Append("  Gripper: ").Append(Gripper).Append("\n");
            sb.Append("  FeedType: ").Append(FeedType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ProcessType: ").Append(ProcessType).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
            return this.Equals(input as RollFedWideFormatPress);
        }

        /// <summary>
        /// Returns true if RollFedWideFormatPress instances are equal
        /// </summary>
        /// <param name="input">Instance of RollFedWideFormatPress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RollFedWideFormatPress input)
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
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.ModifiedOn == input.ModifiedOn ||
                    (this.ModifiedOn != null &&
                    this.ModifiedOn.Equals(input.ModifiedOn))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.AllowPassThrough == input.AllowPassThrough ||
                    (this.AllowPassThrough != null &&
                    this.AllowPassThrough.Equals(input.AllowPassThrough))
                ) && 
                (
                    this.Connections == input.Connections ||
                    this.Connections != null &&
                    input.Connections != null &&
                    this.Connections.SequenceEqual(input.Connections)
                ) && 
                (
                    this.Costing == input.Costing ||
                    (this.Costing != null &&
                    this.Costing.Equals(input.Costing))
                ) && 
                (
                    this.Capabilities == input.Capabilities ||
                    (this.Capabilities != null &&
                    this.Capabilities.Equals(input.Capabilities))
                ) && 
                (
                    this.Script == input.Script ||
                    (this.Script != null &&
                    this.Script.Equals(input.Script))
                ) && 
                (
                    this.Manufacturer == input.Manufacturer ||
                    (this.Manufacturer != null &&
                    this.Manufacturer.Equals(input.Manufacturer))
                ) && 
                (
                    this.MediaRules == input.MediaRules ||
                    (this.MediaRules != null &&
                    this.MediaRules.Equals(input.MediaRules))
                ) && 
                (
                    this.Placement == input.Placement ||
                    (this.Placement != null &&
                    this.Placement.Equals(input.Placement))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.FrontUnits == input.FrontUnits ||
                    (this.FrontUnits != null &&
                    this.FrontUnits.Equals(input.FrontUnits))
                ) && 
                (
                    this.SinglePassDoubleSided == input.SinglePassDoubleSided ||
                    (this.SinglePassDoubleSided != null &&
                    this.SinglePassDoubleSided.Equals(input.SinglePassDoubleSided))
                ) && 
                (
                    this.BackUnits == input.BackUnits ||
                    (this.BackUnits != null &&
                    this.BackUnits.Equals(input.BackUnits))
                ) && 
                (
                    this.DoubleSidedSpeedReduction == input.DoubleSidedSpeedReduction ||
                    (this.DoubleSidedSpeedReduction != null &&
                    this.DoubleSidedSpeedReduction.Equals(input.DoubleSidedSpeedReduction))
                ) && 
                (
                    this.Gripper == input.Gripper ||
                    (this.Gripper != null &&
                    this.Gripper.Equals(input.Gripper))
                ) && 
                (
                    this.FeedType == input.FeedType ||
                    (this.FeedType != null &&
                    this.FeedType.Equals(input.FeedType))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ProcessType == input.ProcessType ||
                    (this.ProcessType != null &&
                    this.ProcessType.Equals(input.ProcessType))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.ModifiedOn != null)
                    hashCode = hashCode * 59 + this.ModifiedOn.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.AllowPassThrough != null)
                    hashCode = hashCode * 59 + this.AllowPassThrough.GetHashCode();
                if (this.Connections != null)
                    hashCode = hashCode * 59 + this.Connections.GetHashCode();
                if (this.Costing != null)
                    hashCode = hashCode * 59 + this.Costing.GetHashCode();
                if (this.Capabilities != null)
                    hashCode = hashCode * 59 + this.Capabilities.GetHashCode();
                if (this.Script != null)
                    hashCode = hashCode * 59 + this.Script.GetHashCode();
                if (this.Manufacturer != null)
                    hashCode = hashCode * 59 + this.Manufacturer.GetHashCode();
                if (this.MediaRules != null)
                    hashCode = hashCode * 59 + this.MediaRules.GetHashCode();
                if (this.Placement != null)
                    hashCode = hashCode * 59 + this.Placement.GetHashCode();
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.FrontUnits != null)
                    hashCode = hashCode * 59 + this.FrontUnits.GetHashCode();
                if (this.SinglePassDoubleSided != null)
                    hashCode = hashCode * 59 + this.SinglePassDoubleSided.GetHashCode();
                if (this.BackUnits != null)
                    hashCode = hashCode * 59 + this.BackUnits.GetHashCode();
                if (this.DoubleSidedSpeedReduction != null)
                    hashCode = hashCode * 59 + this.DoubleSidedSpeedReduction.GetHashCode();
                if (this.Gripper != null)
                    hashCode = hashCode * 59 + this.Gripper.GetHashCode();
                if (this.FeedType != null)
                    hashCode = hashCode * 59 + this.FeedType.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ProcessType != null)
                    hashCode = hashCode * 59 + this.ProcessType.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
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
