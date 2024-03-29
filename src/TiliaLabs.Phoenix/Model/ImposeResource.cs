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
    /// Impose action resource
    /// </summary>
    [DataContract]
        public partial class ImposeResource :  IEquatable<ImposeResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImposeResource" /> class.
        /// </summary>
        /// <param name="idref">ID of action resource is being applied to (Hot Folders only).</param>
        /// <param name="products">Names of products to include.  When not specified all products in the job are included.</param>
        /// <param name="profiles">Optional profiles to use when running Imposition AI.  The default profile is used when this field is not set.</param>
        /// <param name="profilesInline">Optional inline fully defined profiles to use when running Imposition AI..</param>
        /// <param name="stopMinutes">Number of minutes to allow this action to run before stopping.  Default is 60 minutes when not specified..</param>
        /// <param name="templates">Names of templates to use during Impose (required).</param>
        public ImposeResource(int? idref = default(int?), List<string> products = default(List<string>), List<string> profiles = default(List<string>), List<ImpositionAiProfileEntity> profilesInline = default(List<ImpositionAiProfileEntity>), int? stopMinutes = default(int?), List<string> templates = default(List<string>))
        {
            // to ensure "templates" is required (not null)
            if (templates == null)
            {
                throw new InvalidDataException("templates is a required property for ImposeResource and cannot be null");
            }
            else
            {
                this.Templates = templates;
            }
            this.Idref = idref;
            this.Products = products;
            this.Profiles = profiles;
            this.ProfilesInline = profilesInline;
            this.StopMinutes = stopMinutes;
        }
        
        /// <summary>
        /// ID of action resource is being applied to (Hot Folders only)
        /// </summary>
        /// <value>ID of action resource is being applied to (Hot Folders only)</value>
        [DataMember(Name="idref", EmitDefaultValue=false)]
        public int? Idref { get; set; }

        /// <summary>
        /// Names of products to include.  When not specified all products in the job are included
        /// </summary>
        /// <value>Names of products to include.  When not specified all products in the job are included</value>
        [DataMember(Name="products", EmitDefaultValue=false)]
        public List<string> Products { get; set; }

        /// <summary>
        /// Optional profiles to use when running Imposition AI.  The default profile is used when this field is not set
        /// </summary>
        /// <value>Optional profiles to use when running Imposition AI.  The default profile is used when this field is not set</value>
        [DataMember(Name="profiles", EmitDefaultValue=false)]
        public List<string> Profiles { get; set; }

        /// <summary>
        /// Optional inline fully defined profiles to use when running Imposition AI.
        /// </summary>
        /// <value>Optional inline fully defined profiles to use when running Imposition AI.</value>
        [DataMember(Name="profiles-inline", EmitDefaultValue=false)]
        public List<ImpositionAiProfileEntity> ProfilesInline { get; set; }

        /// <summary>
        /// Number of minutes to allow this action to run before stopping.  Default is 60 minutes when not specified.
        /// </summary>
        /// <value>Number of minutes to allow this action to run before stopping.  Default is 60 minutes when not specified.</value>
        [DataMember(Name="stop-minutes", EmitDefaultValue=false)]
        public int? StopMinutes { get; set; }

        /// <summary>
        /// Names of templates to use during Impose
        /// </summary>
        /// <value>Names of templates to use during Impose</value>
        [DataMember(Name="templates", EmitDefaultValue=false)]
        public List<string> Templates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImposeResource {\n");
            sb.Append("  Idref: ").Append(Idref).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
            sb.Append("  ProfilesInline: ").Append(ProfilesInline).Append("\n");
            sb.Append("  StopMinutes: ").Append(StopMinutes).Append("\n");
            sb.Append("  Templates: ").Append(Templates).Append("\n");
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
            return this.Equals(input as ImposeResource);
        }

        /// <summary>
        /// Returns true if ImposeResource instances are equal
        /// </summary>
        /// <param name="input">Instance of ImposeResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImposeResource input)
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
                    this.Products == input.Products ||
                    this.Products != null &&
                    input.Products != null &&
                    this.Products.SequenceEqual(input.Products)
                ) && 
                (
                    this.Profiles == input.Profiles ||
                    this.Profiles != null &&
                    input.Profiles != null &&
                    this.Profiles.SequenceEqual(input.Profiles)
                ) && 
                (
                    this.ProfilesInline == input.ProfilesInline ||
                    this.ProfilesInline != null &&
                    input.ProfilesInline != null &&
                    this.ProfilesInline.SequenceEqual(input.ProfilesInline)
                ) && 
                (
                    this.StopMinutes == input.StopMinutes ||
                    (this.StopMinutes != null &&
                    this.StopMinutes.Equals(input.StopMinutes))
                ) && 
                (
                    this.Templates == input.Templates ||
                    this.Templates != null &&
                    input.Templates != null &&
                    this.Templates.SequenceEqual(input.Templates)
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
                if (this.Products != null)
                    hashCode = hashCode * 59 + this.Products.GetHashCode();
                if (this.Profiles != null)
                    hashCode = hashCode * 59 + this.Profiles.GetHashCode();
                if (this.ProfilesInline != null)
                    hashCode = hashCode * 59 + this.ProfilesInline.GetHashCode();
                if (this.StopMinutes != null)
                    hashCode = hashCode * 59 + this.StopMinutes.GetHashCode();
                if (this.Templates != null)
                    hashCode = hashCode * 59 + this.Templates.GetHashCode();
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
