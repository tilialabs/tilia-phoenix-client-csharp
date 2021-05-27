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
    /// Imposition AI Profile preset
    /// </summary>
    [DataContract]
        public partial class ImpositionAiProfileEntity :  IEquatable<ImpositionAiProfileEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImpositionAiProfileEntity" /> class.
        /// </summary>
        /// <param name="name">Name of library item (required).</param>
        /// <param name="id">Unique ID of this item (auto-generated, read-only).</param>
        /// <param name="externalId">Optional external ID of media item.</param>
        /// <param name="description">Asset description.</param>
        /// <param name="strategies">strategies.</param>
        /// <param name="stripOptions">stripOptions.</param>
        /// <param name="layoutOptions">layoutOptions.</param>
        /// <param name="planOptions">planOptions.</param>
        /// <param name="webOptions">webOptions.</param>
        /// <param name="applyingOptions">applyingOptions.</param>
        /// <param name="planRules">planRules.</param>
        /// <param name="scripts">Scripts.</param>
        public ImpositionAiProfileEntity(string name = default(string), string id = default(string), string externalId = default(string), string description = default(string), StrategiesEntity strategies = default(StrategiesEntity), StripOptionsEntity stripOptions = default(StripOptionsEntity), LayoutOptionsEntity layoutOptions = default(LayoutOptionsEntity), PlanOptionsEntity planOptions = default(PlanOptionsEntity), WebOptionsEntity webOptions = default(WebOptionsEntity), ApplyingResultsEntity applyingOptions = default(ApplyingResultsEntity), RuleGroupEntity planRules = default(RuleGroupEntity), List<LibraryItemEntity> scripts = default(List<LibraryItemEntity>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ImpositionAiProfileEntity and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Id = id;
            this.ExternalId = externalId;
            this.Description = description;
            this.Strategies = strategies;
            this.StripOptions = stripOptions;
            this.LayoutOptions = layoutOptions;
            this.PlanOptions = planOptions;
            this.WebOptions = webOptions;
            this.ApplyingOptions = applyingOptions;
            this.PlanRules = planRules;
            this.Scripts = scripts;
        }
        
        /// <summary>
        /// Name of library item
        /// </summary>
        /// <value>Name of library item</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Unique ID of this item (auto-generated, read-only)
        /// </summary>
        /// <value>Unique ID of this item (auto-generated, read-only)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Optional external ID of media item
        /// </summary>
        /// <value>Optional external ID of media item</value>
        [DataMember(Name="external-id", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Asset description
        /// </summary>
        /// <value>Asset description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Strategies
        /// </summary>
        [DataMember(Name="strategies", EmitDefaultValue=false)]
        public StrategiesEntity Strategies { get; set; }

        /// <summary>
        /// Gets or Sets StripOptions
        /// </summary>
        [DataMember(Name="strip-options", EmitDefaultValue=false)]
        public StripOptionsEntity StripOptions { get; set; }

        /// <summary>
        /// Gets or Sets LayoutOptions
        /// </summary>
        [DataMember(Name="layout-options", EmitDefaultValue=false)]
        public LayoutOptionsEntity LayoutOptions { get; set; }

        /// <summary>
        /// Gets or Sets PlanOptions
        /// </summary>
        [DataMember(Name="plan-options", EmitDefaultValue=false)]
        public PlanOptionsEntity PlanOptions { get; set; }

        /// <summary>
        /// Gets or Sets WebOptions
        /// </summary>
        [DataMember(Name="web-options", EmitDefaultValue=false)]
        public WebOptionsEntity WebOptions { get; set; }

        /// <summary>
        /// Gets or Sets ApplyingOptions
        /// </summary>
        [DataMember(Name="applying-options", EmitDefaultValue=false)]
        public ApplyingResultsEntity ApplyingOptions { get; set; }

        /// <summary>
        /// Gets or Sets PlanRules
        /// </summary>
        [DataMember(Name="plan-rules", EmitDefaultValue=false)]
        public RuleGroupEntity PlanRules { get; set; }

        /// <summary>
        /// Scripts
        /// </summary>
        /// <value>Scripts</value>
        [DataMember(Name="scripts", EmitDefaultValue=false)]
        public List<LibraryItemEntity> Scripts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImpositionAiProfileEntity {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Strategies: ").Append(Strategies).Append("\n");
            sb.Append("  StripOptions: ").Append(StripOptions).Append("\n");
            sb.Append("  LayoutOptions: ").Append(LayoutOptions).Append("\n");
            sb.Append("  PlanOptions: ").Append(PlanOptions).Append("\n");
            sb.Append("  WebOptions: ").Append(WebOptions).Append("\n");
            sb.Append("  ApplyingOptions: ").Append(ApplyingOptions).Append("\n");
            sb.Append("  PlanRules: ").Append(PlanRules).Append("\n");
            sb.Append("  Scripts: ").Append(Scripts).Append("\n");
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
            return this.Equals(input as ImpositionAiProfileEntity);
        }

        /// <summary>
        /// Returns true if ImpositionAiProfileEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of ImpositionAiProfileEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImpositionAiProfileEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Strategies == input.Strategies ||
                    (this.Strategies != null &&
                    this.Strategies.Equals(input.Strategies))
                ) && 
                (
                    this.StripOptions == input.StripOptions ||
                    (this.StripOptions != null &&
                    this.StripOptions.Equals(input.StripOptions))
                ) && 
                (
                    this.LayoutOptions == input.LayoutOptions ||
                    (this.LayoutOptions != null &&
                    this.LayoutOptions.Equals(input.LayoutOptions))
                ) && 
                (
                    this.PlanOptions == input.PlanOptions ||
                    (this.PlanOptions != null &&
                    this.PlanOptions.Equals(input.PlanOptions))
                ) && 
                (
                    this.WebOptions == input.WebOptions ||
                    (this.WebOptions != null &&
                    this.WebOptions.Equals(input.WebOptions))
                ) && 
                (
                    this.ApplyingOptions == input.ApplyingOptions ||
                    (this.ApplyingOptions != null &&
                    this.ApplyingOptions.Equals(input.ApplyingOptions))
                ) && 
                (
                    this.PlanRules == input.PlanRules ||
                    (this.PlanRules != null &&
                    this.PlanRules.Equals(input.PlanRules))
                ) && 
                (
                    this.Scripts == input.Scripts ||
                    this.Scripts != null &&
                    input.Scripts != null &&
                    this.Scripts.SequenceEqual(input.Scripts)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Strategies != null)
                    hashCode = hashCode * 59 + this.Strategies.GetHashCode();
                if (this.StripOptions != null)
                    hashCode = hashCode * 59 + this.StripOptions.GetHashCode();
                if (this.LayoutOptions != null)
                    hashCode = hashCode * 59 + this.LayoutOptions.GetHashCode();
                if (this.PlanOptions != null)
                    hashCode = hashCode * 59 + this.PlanOptions.GetHashCode();
                if (this.WebOptions != null)
                    hashCode = hashCode * 59 + this.WebOptions.GetHashCode();
                if (this.ApplyingOptions != null)
                    hashCode = hashCode * 59 + this.ApplyingOptions.GetHashCode();
                if (this.PlanRules != null)
                    hashCode = hashCode * 59 + this.PlanRules.GetHashCode();
                if (this.Scripts != null)
                    hashCode = hashCode * 59 + this.Scripts.GetHashCode();
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