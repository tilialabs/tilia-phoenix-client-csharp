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
    /// Run script action resource (Tech Preview)
    /// </summary>
    [DataContract]
        public partial class RunScriptResource :  IEquatable<RunScriptResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunScriptResource" /> class.
        /// </summary>
        /// <param name="idref">ID of action resource is being applied to (Hot Folders only).</param>
        /// <param name="name">Name of script in Scripts library including folder name(s).</param>
        /// <param name="inputs">inputs.</param>
        public RunScriptResource(int? idref = default(int?), string name = default(string), Dictionary<string, string> inputs = default(Dictionary<string, string>))
        {
            this.Idref = idref;
            this.Name = name;
            this.Inputs = inputs;
        }
        
        /// <summary>
        /// ID of action resource is being applied to (Hot Folders only)
        /// </summary>
        /// <value>ID of action resource is being applied to (Hot Folders only)</value>
        [DataMember(Name="idref", EmitDefaultValue=false)]
        public int? Idref { get; set; }

        /// <summary>
        /// Name of script in Scripts library including folder name(s)
        /// </summary>
        /// <value>Name of script in Scripts library including folder name(s)</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Inputs
        /// </summary>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        public Dictionary<string, string> Inputs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunScriptResource {\n");
            sb.Append("  Idref: ").Append(Idref).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
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
            return this.Equals(input as RunScriptResource);
        }

        /// <summary>
        /// Returns true if RunScriptResource instances are equal
        /// </summary>
        /// <param name="input">Instance of RunScriptResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunScriptResource input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    input.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
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
